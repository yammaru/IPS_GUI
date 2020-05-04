namespace LiquidacionGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttGuardar = new System.Windows.Forms.Button();
            this.bttConsutar = new System.Windows.Forms.Button();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNLiquidacion = new System.Windows.Forms.TextBox();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.CbmAfiliacion = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CalendarioSkill = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lbbTotalizar = new System.Windows.Forms.Label();
            this.combo_afiliacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConsultaMES = new System.Windows.Forms.TextBox();
            this.txtConsultaAÑO = new System.Windows.Forms.TextBox();
            this.txtValorServicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(12, 93);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // bttConsutar
            // 
            this.bttConsutar.Location = new System.Drawing.Point(12, 136);
            this.bttConsutar.Name = "bttConsutar";
            this.bttConsutar.Size = new System.Drawing.Size(75, 23);
            this.bttConsutar.TabIndex = 1;
            this.bttConsutar.Text = "Consultar";
            this.bttConsutar.UseVisualStyleBackColor = true;
            this.bttConsutar.Click += new System.EventHandler(this.bttConsultar_Click);
            // 
            // bttFiltrar
            // 
            this.bttFiltrar.Location = new System.Drawing.Point(807, 214);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(75, 23);
            this.bttFiltrar.TabIndex = 3;
            this.bttFiltrar.Text = "Filtrar";
            this.bttFiltrar.UseVisualStyleBackColor = true;
            this.bttFiltrar.Click += new System.EventHandler(this.btnFltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero liquidacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Identificacion Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Liquidacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo afiliacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salario paciente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor servicio:";
            // 
            // txtNLiquidacion
            // 
            this.txtNLiquidacion.Location = new System.Drawing.Point(257, 60);
            this.txtNLiquidacion.Name = "txtNLiquidacion";
            this.txtNLiquidacion.Size = new System.Drawing.Size(100, 20);
            this.txtNLiquidacion.TabIndex = 11;
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(257, 112);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(100, 20);
            this.txtIDPaciente.TabIndex = 13;
            this.txtIDPaciente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CbmAfiliacion
            // 
            this.CbmAfiliacion.FormattingEnabled = true;
            this.CbmAfiliacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.CbmAfiliacion.Location = new System.Drawing.Point(257, 137);
            this.CbmAfiliacion.Name = "CbmAfiliacion";
            this.CbmAfiliacion.Size = new System.Drawing.Size(100, 21);
            this.CbmAfiliacion.TabIndex = 14;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(257, 164);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // CalendarioSkill
            // 
            this.CalendarioSkill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarioSkill.Location = new System.Drawing.Point(257, 86);
            this.CalendarioSkill.Name = "CalendarioSkill";
            this.CalendarioSkill.Size = new System.Drawing.Size(100, 20);
            this.CalendarioSkill.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Totalizar:";
            // 
            // lbbTotalizar
            // 
            this.lbbTotalizar.AutoSize = true;
            this.lbbTotalizar.Location = new System.Drawing.Point(471, 18);
            this.lbbTotalizar.Name = "lbbTotalizar";
            this.lbbTotalizar.Size = new System.Drawing.Size(31, 13);
            this.lbbTotalizar.TabIndex = 19;
            this.lbbTotalizar.Text = "$$$$";
            // 
            // combo_afiliacion
            // 
            this.combo_afiliacion.FormattingEnabled = true;
            this.combo_afiliacion.Items.AddRange(new object[] {
            "Subsidiado",
            "Contributivo"});
            this.combo_afiliacion.Location = new System.Drawing.Point(481, 214);
            this.combo_afiliacion.Name = "combo_afiliacion";
            this.combo_afiliacion.Size = new System.Drawing.Size(100, 21);
            this.combo_afiliacion.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo afiliacion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(585, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mes:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(671, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Año:";
            // 
            // txtConsultaMES
            // 
            this.txtConsultaMES.Location = new System.Drawing.Point(619, 214);
            this.txtConsultaMES.Name = "txtConsultaMES";
            this.txtConsultaMES.Size = new System.Drawing.Size(48, 20);
            this.txtConsultaMES.TabIndex = 25;
            this.txtConsultaMES.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtConsultaAÑO
            // 
            this.txtConsultaAÑO.Location = new System.Drawing.Point(704, 214);
            this.txtConsultaAÑO.Name = "txtConsultaAÑO";
            this.txtConsultaAÑO.Size = new System.Drawing.Size(82, 20);
            this.txtConsultaAÑO.TabIndex = 26;
            this.txtConsultaAÑO.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtValorServicio
            // 
            this.txtValorServicio.Location = new System.Drawing.Point(257, 190);
            this.txtValorServicio.Name = "txtValorServicio";
            this.txtValorServicio.Size = new System.Drawing.Size(100, 20);
            this.txtValorServicio.TabIndex = 27;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 249);
            this.Controls.Add(this.txtValorServicio);
            this.Controls.Add(this.txtConsultaAÑO);
            this.Controls.Add(this.txtConsultaMES);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_afiliacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbbTotalizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CalendarioSkill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.CbmAfiliacion);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.txtNLiquidacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttFiltrar);
            this.Controls.Add(this.bttConsutar);
            this.Controls.Add(this.bttGuardar);
            this.Name = "FrmPrincipal";
            this.Text = "Liqidacion cuota moderadora";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Button bttConsutar;
        private System.Windows.Forms.Button bttFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNLiquidacion;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.ComboBox CbmAfiliacion;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker CalendarioSkill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbbTotalizar;
        private System.Windows.Forms.ComboBox combo_afiliacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConsultaMES;
        private System.Windows.Forms.TextBox txtConsultaAÑO;
        private System.Windows.Forms.TextBox txtValorServicio;
    }
}

