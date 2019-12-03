namespace ihc
{
    partial class ventanaContratosFalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaContratosFalla));
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Button5 = new System.Windows.Forms.Button();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.Button4.Location = new System.Drawing.Point(52, 418);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(90, 27);
            this.Button4.TabIndex = 30;
            this.Button4.Text = "Nuevo Reporte";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.Button3.Location = new System.Drawing.Point(200, 418);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(91, 27);
            this.Button3.TabIndex = 29;
            this.Button3.Text = "Editar";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.Button2.Location = new System.Drawing.Point(336, 418);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(90, 27);
            this.Button2.TabIndex = 28;
            this.Button2.Text = "Eliminar";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.Button1.Location = new System.Drawing.Point(483, 418);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 27);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "Cerrar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 411);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta de Fallas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consecutivo,
            this.Contrato,
            this.Cliente,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Descripcion});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // Consecutivo
            // 
            this.Consecutivo.HeaderText = "Consecutivo";
            this.Consecutivo.Name = "Consecutivo";
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha de Renta";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Equipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numero Equipo";
            this.Column3.Name = "Column3";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.Button5);
            this.tabPage2.Controls.Add(this.TextBox6);
            this.tabPage2.Controls.Add(this.Label6);
            this.tabPage2.Controls.Add(this.TextBox5);
            this.tabPage2.Controls.Add(this.Label5);
            this.tabPage2.Controls.Add(this.TextBox4);
            this.tabPage2.Controls.Add(this.Label4);
            this.tabPage2.Controls.Add(this.TextBox3);
            this.tabPage2.Controls.Add(this.Label3);
            this.tabPage2.Controls.Add(this.TextBox2);
            this.tabPage2.Controls.Add(this.Label2);
            this.tabPage2.Controls.Add(this.TextBox1);
            this.tabPage2.Controls.Add(this.Label1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes de Falla";
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(578, 336);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(89, 29);
            this.Button5.TabIndex = 40;
            this.Button5.Text = "Guardar";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // TextBox6
            // 
            this.TextBox6.Enabled = false;
            this.TextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox6.Location = new System.Drawing.Point(189, 260);
            this.TextBox6.Multiline = true;
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(378, 91);
            this.TextBox6.TabIndex = 53;
            this.TextBox6.Text = "LA MAQUINA EMPEZO A ECHAR HUMO Y DESPUES YA NO QUIZO ENCENDER";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(10, 263);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(183, 20);
            this.Label6.TabIndex = 52;
            this.Label6.Text = "Descripción de Falla";
            // 
            // TextBox5
            // 
            this.TextBox5.Enabled = false;
            this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.Location = new System.Drawing.Point(183, 120);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(100, 27);
            this.TextBox5.TabIndex = 51;
            this.TextBox5.Text = "1";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(3, 120);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(163, 20);
            this.Label5.TabIndex = 50;
            this.Label5.Text = "Numero de Equipo";
            // 
            // TextBox4
            // 
            this.TextBox4.Enabled = false;
            this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.Location = new System.Drawing.Point(80, 205);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(263, 27);
            this.TextBox4.TabIndex = 49;
            this.TextBox4.Text = "ALLANADORA DOBLE 36\"";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(6, 212);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(66, 20);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "Equipo";
            // 
            // TextBox3
            // 
            this.TextBox3.Enabled = false;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(140, 74);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(170, 27);
            this.TextBox3.TabIndex = 47;
            this.TextBox3.Text = "2 ENERO 2009";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(3, 77);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(141, 20);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "Fecha de Renta";
            // 
            // TextBox2
            // 
            this.TextBox2.Enabled = false;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(80, 167);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(267, 27);
            this.TextBox2.TabIndex = 45;
            this.TextBox2.Text = "IC CONSTRUCCIONES Y EQUIPOS";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(6, 170);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 20);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Cliente";
            // 
            // TextBox1
            // 
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(93, 26);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 27);
            this.TextBox1.TabIndex = 42;
            this.TextBox1.Text = "23234";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(6, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 20);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Contrato";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(690, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ventanaContratosFalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 460);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaContratosFalla";
            this.Text = "ventanaContratosFalla";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}