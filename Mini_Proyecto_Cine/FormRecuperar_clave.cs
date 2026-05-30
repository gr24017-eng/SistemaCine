using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Proyecto_Cine
{
    public partial class FormRecuperar_clave : Form
    {
        int idUsuario = 0;
        string codigoGenerado = "";

        public FormRecuperar_clave()
        {
            InitializeComponent();
            
        }

        private void btnSolicitarCodigo_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Ingresa tu usuario y correo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = @"SELECT id_usuario FROM usuarios 
                                   WHERE usuario=@u AND correo=@c AND estado='activo'";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@u", usuario);
                        cmd.Parameters.AddWithValue("@c", correo);
                        var dato = cmd.ExecuteScalar();

                        if (dato == null)
                        {
                            MessageBox.Show("Usuario o correo incorrectos.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        idUsuario = Convert.ToInt32(dato);
                    }
                }

                codigoGenerado = new Random().Next(100000, 999999).ToString();

                if (EnviarCorreo(correo, codigoGenerado))
                {
                    MessageBox.Show("Código enviado a tu correo.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelCambio.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            string codigoIngresado = txtCodigo.Text.Trim();
            string nuevaClave = txtNuevaClave.Text.Trim();

            if (codigoIngresado != codigoGenerado)
            {
                MessageBox.Show("Código incorrecto.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nuevaClave))
            {
                MessageBox.Show("Ingresa la nueva contraseña.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string sql = "UPDATE usuarios SET clave=@c WHERE id_usuario=@id";
                    using (var cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@c", HashearClave(nuevaClave));
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Contraseña actualizada correctamente!", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EnviarCorreo(string destino, string codigo)
        {
            try
            {
                // *** CORREO DE GMAIL DESDE EL QUE SE ENVÍAN LOS CÓDIGOS ***
                string correoRemitente = "projectcine02@gmail.com";
                // *** CLAVE DE APLICACIÓN (no la clave normal de Gmail) ***
                string claveApp = "iufb ylaq sydh tqof";

                MailMessage mail = new MailMessage(correoRemitente, destino);
                mail.Subject = "Recuperación de contraseña — Cine Plus";
                mail.Body = $"Tu código de verificación es: {codigo}\n\nNo lo compartas con nadie.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(correoRemitente, claveApp);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string HashearClave(string clave)
        {
            return Utilidades.HashSHA256(clave);
        }

        
    }
}
