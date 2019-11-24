namespace ihc
{
    partial class Form26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdDataSet5 = new ihc.bdDataSet5();
            this.mantenimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientosTableAdapter = new ihc.bdDataSet5TableAdapters.MantenimientosTableAdapter();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEconomicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mecanicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDeMantenimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horometroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientoEnSitioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.terminadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtRefacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenciaDataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.noEconomicoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.motorDataGridViewTextBoxColumn,
            this.mecanicoDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.tiempoDeMantenimientoDataGridViewTextBoxColumn,
            this.horometroDataGridViewTextBoxColumn,
            this.mantenimientoEnSitioDataGridViewCheckBoxColumn,
            this.terminadoDataGridViewTextBoxColumn,
            this.subtServicioDataGridViewTextBoxColumn,
            this.subtRefacDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mantenimientosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdDataSet5
            // 
            this.bdDataSet5.DataSetName = "bdDataSet5";
            this.bdDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientosBindingSource
            // 
            this.mantenimientosBindingSource.DataMember = "Mantenimientos";
            this.mantenimientosBindingSource.DataSource = this.bdDataSet5;
            // 
            // mantenimientosTableAdapter
            // 
            this.mantenimientosTableAdapter.ClearBeforeFill = true;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            // 
            // lineaDataGridViewTextBoxColumn
            // 
            this.lineaDataGridViewTextBoxColumn.DataPropertyName = "Linea";
            this.lineaDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaDataGridViewTextBoxColumn.Name = "lineaDataGridViewTextBoxColumn";
            // 
            // noEconomicoDataGridViewTextBoxColumn
            // 
            this.noEconomicoDataGridViewTextBoxColumn.DataPropertyName = "NoEconomico";
            this.noEconomicoDataGridViewTextBoxColumn.HeaderText = "NoEconomico";
            this.noEconomicoDataGridViewTextBoxColumn.Name = "noEconomicoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // motorDataGridViewTextBoxColumn
            // 
            this.motorDataGridViewTextBoxColumn.DataPropertyName = "Motor";
            this.motorDataGridViewTextBoxColumn.HeaderText = "Motor";
            this.motorDataGridViewTextBoxColumn.Name = "motorDataGridViewTextBoxColumn";
            // 
            // mecanicoDataGridViewTextBoxColumn
            // 
            this.mecanicoDataGridViewTextBoxColumn.DataPropertyName = "Mecanico";
            this.mecanicoDataGridViewTextBoxColumn.HeaderText = "Mecanico";
            this.mecanicoDataGridViewTextBoxColumn.Name = "mecanicoDataGridViewTextBoxColumn";
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            // 
            // tiempoDeMantenimientoDataGridViewTextBoxColumn
            // 
            this.tiempoDeMantenimientoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo de mantenimiento";
            this.tiempoDeMantenimientoDataGridViewTextBoxColumn.HeaderText = "Tiempo de mantenimiento";
            this.tiempoDeMantenimientoDataGridViewTextBoxColumn.Name = "tiempoDeMantenimientoDataGridViewTextBoxColumn";
            // 
            // horometroDataGridViewTextBoxColumn
            // 
            this.horometroDataGridViewTextBoxColumn.DataPropertyName = "Horometro";
            this.horometroDataGridViewTextBoxColumn.HeaderText = "Horometro";
            this.horometroDataGridViewTextBoxColumn.Name = "horometroDataGridViewTextBoxColumn";
            // 
            // mantenimientoEnSitioDataGridViewCheckBoxColumn
            // 
            this.mantenimientoEnSitioDataGridViewCheckBoxColumn.DataPropertyName = "Mantenimiento en sitio";
            this.mantenimientoEnSitioDataGridViewCheckBoxColumn.HeaderText = "Mantenimiento en sitio";
            this.mantenimientoEnSitioDataGridViewCheckBoxColumn.Name = "mantenimientoEnSitioDataGridViewCheckBoxColumn";
            // 
            // terminadoDataGridViewTextBoxColumn
            // 
            this.terminadoDataGridViewTextBoxColumn.DataPropertyName = "Terminado";
            this.terminadoDataGridViewTextBoxColumn.HeaderText = "Terminado";
            this.terminadoDataGridViewTextBoxColumn.Name = "terminadoDataGridViewTextBoxColumn";
            // 
            // subtServicioDataGridViewTextBoxColumn
            // 
            this.subtServicioDataGridViewTextBoxColumn.DataPropertyName = "Subt_Servicio";
            this.subtServicioDataGridViewTextBoxColumn.HeaderText = "Subt_Servicio";
            this.subtServicioDataGridViewTextBoxColumn.Name = "subtServicioDataGridViewTextBoxColumn";
            // 
            // subtRefacDataGridViewTextBoxColumn
            // 
            this.subtRefacDataGridViewTextBoxColumn.DataPropertyName = "Subt_Refac";
            this.subtRefacDataGridViewTextBoxColumn.HeaderText = "Subt_Refac";
            this.subtRefacDataGridViewTextBoxColumn.Name = "subtRefacDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1316, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 41);
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
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(568, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consulta De Mantenimientos";
            // 
            // Form26
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1386, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form26";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Form26_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet5 bdDataSet5;
        private System.Windows.Forms.BindingSource mantenimientosBindingSource;
        private bdDataSet5TableAdapters.MantenimientosTableAdapter mantenimientosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEconomicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mecanicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDeMantenimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horometroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mantenimientoEnSitioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtRefacDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
    }
}