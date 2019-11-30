namespace ihc
{
    partial class ventanaConsultaEquipos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaConsultaEquipos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEconomicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet = new ihc.bdDataSet();
            this.equiposTableAdapter = new ihc.bdDataSetTableAdapters.EquiposTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.noEconomicoDataGridViewTextBoxColumn,
            this.noSerieDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.diasRentaDataGridViewTextBoxColumn,
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn,
            this.contratoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.encargadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equiposBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(675, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // lineaDataGridViewTextBoxColumn
            // 
            this.lineaDataGridViewTextBoxColumn.DataPropertyName = "Linea";
            this.lineaDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineaDataGridViewTextBoxColumn.Name = "lineaDataGridViewTextBoxColumn";
            this.lineaDataGridViewTextBoxColumn.Width = 125;
            // 
            // noEconomicoDataGridViewTextBoxColumn
            // 
            this.noEconomicoDataGridViewTextBoxColumn.DataPropertyName = "NoEconomico";
            this.noEconomicoDataGridViewTextBoxColumn.HeaderText = "NoEconomico";
            this.noEconomicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noEconomicoDataGridViewTextBoxColumn.Name = "noEconomicoDataGridViewTextBoxColumn";
            this.noEconomicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // noSerieDataGridViewTextBoxColumn
            // 
            this.noSerieDataGridViewTextBoxColumn.DataPropertyName = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.HeaderText = "NoSerie";
            this.noSerieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noSerieDataGridViewTextBoxColumn.Name = "noSerieDataGridViewTextBoxColumn";
            this.noSerieDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // diasRentaDataGridViewTextBoxColumn
            // 
            this.diasRentaDataGridViewTextBoxColumn.DataPropertyName = "Dias Renta";
            this.diasRentaDataGridViewTextBoxColumn.HeaderText = "Dias Renta";
            this.diasRentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diasRentaDataGridViewTextBoxColumn.Name = "diasRentaDataGridViewTextBoxColumn";
            this.diasRentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // diasUltimoMantenimientoDataGridViewTextBoxColumn
            // 
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "Dias Ultimo Mantenimiento";
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn.HeaderText = "Dias Ultimo Mantenimiento";
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn.Name = "diasUltimoMantenimientoDataGridViewTextBoxColumn";
            this.diasUltimoMantenimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contratoDataGridViewTextBoxColumn
            // 
            this.contratoDataGridViewTextBoxColumn.DataPropertyName = "Contrato";
            this.contratoDataGridViewTextBoxColumn.HeaderText = "Contrato";
            this.contratoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contratoDataGridViewTextBoxColumn.Name = "contratoDataGridViewTextBoxColumn";
            this.contratoDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // encargadoDataGridViewTextBoxColumn
            // 
            this.encargadoDataGridViewTextBoxColumn.DataPropertyName = "Encargado";
            this.encargadoDataGridViewTextBoxColumn.HeaderText = "Encargado";
            this.encargadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.encargadoDataGridViewTextBoxColumn.Name = "encargadoDataGridViewTextBoxColumn";
            this.encargadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.bdDataSet;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(418, 478);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(701, 478);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(448, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1131, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::ihc.Properties.Resources.casa;
            this.pictureBox7.Location = new System.Drawing.Point(11, 11);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // ventanaConsultaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ventanaConsultaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador De Equipos";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private bdDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEconomicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasUltimoMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}