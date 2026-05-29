namespace Mini_Proyecto_Cine
{
    partial class Reportes_Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            grbSelecion_reporte = new GroupBox();
            btnGenerar = new Button();
            label3 = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            label2 = new Label();
            cmbSelecion_repor = new ComboBox();
            label1 = new Label();
            grbVentas = new GroupBox();
            chartVentas_dia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grbDetalle = new GroupBox();
            dgvDetalle_reporte = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Boletos_Vendidos = new DataGridViewTextBoxColumn();
            Venta_Boletos = new DataGridViewTextBoxColumn();
            Ventas_Cofiteria = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            chartMas_vistas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            grbPelis_masvistas = new GroupBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            lblSubMes = new Label();
            lblVentasMes = new Label();
            label14 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            lblConfitHoy = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            label16 = new Label();
            lblBoletosHoy = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label15 = new Label();
            lblVentasHoy = new Label();
            label4 = new Label();
            grbSelecion_reporte.SuspendLayout();
            grbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas_dia).BeginInit();
            grbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle_reporte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMas_vistas).BeginInit();
            grbPelis_masvistas.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbSelecion_reporte
            // 
            grbSelecion_reporte.Controls.Add(btnGenerar);
            grbSelecion_reporte.Controls.Add(label3);
            grbSelecion_reporte.Controls.Add(dtpDesde);
            grbSelecion_reporte.Controls.Add(dtpHasta);
            grbSelecion_reporte.Controls.Add(label2);
            grbSelecion_reporte.Controls.Add(cmbSelecion_repor);
            grbSelecion_reporte.Controls.Add(label1);
            grbSelecion_reporte.Location = new Point(9, 15);
            grbSelecion_reporte.Name = "grbSelecion_reporte";
            grbSelecion_reporte.Size = new Size(1041, 75);
            grbSelecion_reporte.TabIndex = 0;
            grbSelecion_reporte.TabStop = false;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(843, 30);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 34);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(379, 34);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(124, 27);
            dtpDesde.TabIndex = 3;
            dtpDesde.Value = new DateTime(2026, 5, 24, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(617, 34);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(124, 27);
            dtpHasta.TabIndex = 5;
            dtpHasta.Value = new DateTime(2026, 5, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 34);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Desde:";
            // 
            // cmbSelecion_repor
            // 
            cmbSelecion_repor.FormattingEnabled = true;
            cmbSelecion_repor.Location = new Point(160, 31);
            cmbSelecion_repor.Name = "cmbSelecion_repor";
            cmbSelecion_repor.Size = new Size(126, 28);
            cmbSelecion_repor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 34);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Selecione el reporte:";
            // 
            // grbVentas
            // 
            grbVentas.Controls.Add(chartVentas_dia);
            grbVentas.Location = new Point(9, 251);
            grbVentas.Name = "grbVentas";
            grbVentas.Size = new Size(535, 226);
            grbVentas.TabIndex = 1;
            grbVentas.TabStop = false;
            grbVentas.Text = "Ventas por dia";
            // 
            // chartVentas_dia
            // 
            chartArea1.AxisX.MajorGrid.LineColor = Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorGrid.LineColor = Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chartVentas_dia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentas_dia.Legends.Add(legend1);
            chartVentas_dia.Location = new Point(7, 21);
            chartVentas_dia.Name = "chartVentas_dia";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentas_dia.Series.Add(series1);
            chartVentas_dia.Size = new Size(522, 199);
            chartVentas_dia.TabIndex = 0;
            chartVentas_dia.Text = "chart1";
            // 
            // grbDetalle
            // 
            grbDetalle.Controls.Add(dgvDetalle_reporte);
            grbDetalle.Location = new Point(9, 483);
            grbDetalle.Name = "grbDetalle";
            grbDetalle.Size = new Size(1041, 240);
            grbDetalle.TabIndex = 2;
            grbDetalle.TabStop = false;
            grbDetalle.Text = "Detalle del reporte";
            // 
            // dgvDetalle_reporte
            // 
            dgvDetalle_reporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle_reporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle_reporte.Columns.AddRange(new DataGridViewColumn[] { Fecha, Boletos_Vendidos, Venta_Boletos, Ventas_Cofiteria, Total });
            dgvDetalle_reporte.Location = new Point(6, 26);
            dgvDetalle_reporte.Name = "dgvDetalle_reporte";
            dgvDetalle_reporte.RowHeadersWidth = 51;
            dgvDetalle_reporte.Size = new Size(1026, 208);
            dgvDetalle_reporte.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Boletos_Vendidos
            // 
            Boletos_Vendidos.HeaderText = "Boletos Vendidos";
            Boletos_Vendidos.MinimumWidth = 6;
            Boletos_Vendidos.Name = "Boletos_Vendidos";
            Boletos_Vendidos.ReadOnly = true;
            // 
            // Venta_Boletos
            // 
            Venta_Boletos.HeaderText = "Venta Boletos";
            Venta_Boletos.MinimumWidth = 6;
            Venta_Boletos.Name = "Venta_Boletos";
            Venta_Boletos.ReadOnly = true;
            // 
            // Ventas_Cofiteria
            // 
            Ventas_Cofiteria.HeaderText = "Ventas Cofiteria";
            Ventas_Cofiteria.MinimumWidth = 6;
            Ventas_Cofiteria.Name = "Ventas_Cofiteria";
            Ventas_Cofiteria.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // chartMas_vistas
            // 
            chartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = Color.Gray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorGrid.LineColor = Color.Gray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            chartMas_vistas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartMas_vistas.Legends.Add(legend2);
            chartMas_vistas.Location = new Point(12, 21);
            chartMas_vistas.Name = "chartMas_vistas";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartMas_vistas.Series.Add(series2);
            chartMas_vistas.Size = new Size(463, 199);
            chartMas_vistas.TabIndex = 1;
            chartMas_vistas.Text = "chart2";
            // 
            // grbPelis_masvistas
            // 
            grbPelis_masvistas.Controls.Add(chartMas_vistas);
            grbPelis_masvistas.Location = new Point(566, 251);
            grbPelis_masvistas.Name = "grbPelis_masvistas";
            grbPelis_masvistas.Size = new Size(484, 226);
            grbPelis_masvistas.TabIndex = 3;
            grbPelis_masvistas.TabStop = false;
            grbPelis_masvistas.Text = "Peliculas mas vistas";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(9, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 160);
            panel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSubMes);
            groupBox4.Controls.Add(lblVentasMes);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(780, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 154);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // lblSubMes
            // 
            lblSubMes.Location = new Point(50, 116);
            lblSubMes.Name = "lblSubMes";
            lblSubMes.Size = new Size(150, 25);
            lblSubMes.TabIndex = 4;
            lblSubMes.Text = "Mes";
            lblSubMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasMes
            // 
            lblVentasMes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentasMes.Location = new Point(50, 67);
            lblVentasMes.Name = "lblVentasMes";
            lblVentasMes.Size = new Size(150, 25);
            lblVentasMes.TabIndex = 3;
            lblVentasMes.Text = "$0.00";
            lblVentasMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Location = new Point(50, 23);
            label14.Name = "label14";
            label14.Size = new Size(150, 25);
            label14.TabIndex = 0;
            label14.Text = "Ventas Totales (Mes)";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblConfitHoy);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(524, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 154);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // label10
            // 
            label10.Location = new Point(60, 116);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 4;
            label10.Text = "Hoy";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfitHoy
            // 
            lblConfitHoy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblConfitHoy.Location = new Point(60, 67);
            lblConfitHoy.Name = "lblConfitHoy";
            lblConfitHoy.Size = new Size(130, 25);
            lblConfitHoy.TabIndex = 3;
            lblConfitHoy.Text = "$0.00";
            lblConfitHoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Location = new Point(60, 23);
            label11.Name = "label11";
            label11.Size = new Size(130, 25);
            label11.TabIndex = 0;
            label11.Text = "Ingresos Cofiteria";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(lblBoletosHoy);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(268, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 154);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label16
            // 
            label16.Location = new Point(60, 116);
            label16.Name = "label16";
            label16.Size = new Size(130, 25);
            label16.TabIndex = 6;
            label16.Text = "Hoy";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBoletosHoy
            // 
            lblBoletosHoy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBoletosHoy.Location = new Point(60, 67);
            lblBoletosHoy.Name = "lblBoletosHoy";
            lblBoletosHoy.Size = new Size(130, 25);
            lblBoletosHoy.TabIndex = 3;
            lblBoletosHoy.Text = "0";
            lblBoletosHoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(60, 23);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 0;
            label8.Text = "Boletos Vendidos";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(lblVentasHoy);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label15
            // 
            label15.Location = new Point(60, 116);
            label15.Name = "label15";
            label15.Size = new Size(120, 25);
            label15.TabIndex = 5;
            label15.Text = "Hoy";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVentasHoy.Location = new Point(60, 67);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(120, 25);
            lblVentasHoy.TabIndex = 3;
            lblVentasHoy.Text = "$0.00";
            lblVentasHoy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(60, 23);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 0;
            label4.Text = "Ventas Totales";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reportes_Estadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 735);
            Controls.Add(panel1);
            Controls.Add(grbPelis_masvistas);
            Controls.Add(grbDetalle);
            Controls.Add(grbVentas);
            Controls.Add(grbSelecion_reporte);
            Name = "Reportes_Estadisticas";
            Text = "Reportes_Estadisticas";
            Load += Reportes_Estadisticas_Load;
            grbSelecion_reporte.ResumeLayout(false);
            grbSelecion_reporte.PerformLayout();
            grbVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentas_dia).EndInit();
            grbDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalle_reporte).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMas_vistas).EndInit();
            grbPelis_masvistas.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSelecion_reporte;
        private DateTimePicker dtpDesde;
        private Label label2;
        private ComboBox cmbSelecion_repor;
        private Label label1;
        private Label label3;
        private DateTimePicker dtpHasta;
        private Button btnGenerar;
        private GroupBox grbVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas_dia;
        private GroupBox grbDetalle;
        private DataGridView dgvDetalle_reporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMas_vistas;
        private GroupBox grbPelis_masvistas;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Boletos_Vendidos;
        private DataGridViewTextBoxColumn Venta_Boletos;
        private DataGridViewTextBoxColumn Ventas_Cofiteria;
        private DataGridViewTextBoxColumn Total;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblConfitHoy;
        private Label label11;
        private Label lblBoletosHoy;
        private Label label8;
        private Label lblVentasHoy;
        private GroupBox groupBox4;
        private Label lblSubMes;
        private Label lblVentasMes;
        private Label label14;
        private Label label10;
        private Label label16;
        private Label label15;
    }
}