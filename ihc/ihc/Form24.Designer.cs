namespace ihc
{
    partial class Form24
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoCorteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conctactoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aditamentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet3 = new ihc.bdDataSet3();
            this.contratosTableAdapter = new ihc.bdDataSet3TableAdapters.ContratosTableAdapter();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referenciaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ultimoCorteDataGridViewTextBoxColumn,
            this.conctactoClienteDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.refDataGridViewTextBoxColumn,
            this.coloniaDataGridViewTextBoxColumn,
            this.municipioDataGridViewTextBoxColumn,
            this.telResponsableDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.equipoDataGridViewTextBoxColumn,
            this.aditamentosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contratosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1646, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ultimoCorteDataGridViewTextBoxColumn
            // 
            this.ultimoCorteDataGridViewTextBoxColumn.DataPropertyName = "UltimoCorte";
            this.ultimoCorteDataGridViewTextBoxColumn.HeaderText = "UltimoCorte";
            this.ultimoCorteDataGridViewTextBoxColumn.Name = "ultimoCorteDataGridViewTextBoxColumn";
            // 
            // conctactoClienteDataGridViewTextBoxColumn
            // 
            this.conctactoClienteDataGridViewTextBoxColumn.DataPropertyName = "ConctactoCliente";
            this.conctactoClienteDataGridViewTextBoxColumn.HeaderText = "ConctactoCliente";
            this.conctactoClienteDataGridViewTextBoxColumn.Name = "conctactoClienteDataGridViewTextBoxColumn";
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // refDataGridViewTextBoxColumn
            // 
            this.refDataGridViewTextBoxColumn.DataPropertyName = "Ref";
            this.refDataGridViewTextBoxColumn.HeaderText = "Ref";
            this.refDataGridViewTextBoxColumn.Name = "refDataGridViewTextBoxColumn";
            // 
            // coloniaDataGridViewTextBoxColumn
            // 
            this.coloniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.HeaderText = "Colonia";
            this.coloniaDataGridViewTextBoxColumn.Name = "coloniaDataGridViewTextBoxColumn";
            // 
            // municipioDataGridViewTextBoxColumn
            // 
            this.municipioDataGridViewTextBoxColumn.DataPropertyName = "Municipio";
            this.municipioDataGridViewTextBoxColumn.HeaderText = "Municipio";
            this.municipioDataGridViewTextBoxColumn.Name = "municipioDataGridViewTextBoxColumn";
            // 
            // telResponsableDataGridViewTextBoxColumn
            // 
            this.telResponsableDataGridViewTextBoxColumn.DataPropertyName = "TelResponsable";
            this.telResponsableDataGridViewTextBoxColumn.HeaderText = "TelResponsable";
            this.telResponsableDataGridViewTextBoxColumn.Name = "telResponsableDataGridViewTextBoxColumn";
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            // 
            // equipoDataGridViewTextBoxColumn
            // 
            this.equipoDataGridViewTextBoxColumn.DataPropertyName = "Equipo";
            this.equipoDataGridViewTextBoxColumn.HeaderText = "Equipo";
            this.equipoDataGridViewTextBoxColumn.Name = "equipoDataGridViewTextBoxColumn";
            // 
            // aditamentosDataGridViewTextBoxColumn
            // 
            this.aditamentosDataGridViewTextBoxColumn.DataPropertyName = "Aditamentos";
            this.aditamentosDataGridViewTextBoxColumn.HeaderText = "Aditamentos";
            this.aditamentosDataGridViewTextBoxColumn.Name = "aditamentosDataGridViewTextBoxColumn";
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataMember = "Contratos";
            this.contratosBindingSource.DataSource = this.bdDataSet3;
            // 
            // bdDataSet3
            // 
            this.bdDataSet3.DataSetName = "bdDataSet3";
            this.bdDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratosTableAdapter
            // 
            this.contratosTableAdapter.ClearBeforeFill = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 73);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1470, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form24";
            this.Text = "Consulta de Contratos";
            this.Load += new System.EventHandler(this.Form24_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet3 bdDataSet3;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private bdDataSet3TableAdapters.ContratosTableAdapter contratosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoCorteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conctactoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aditamentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}