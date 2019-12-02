namespace ihc
{
    partial class ventanaCategorias
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioRentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioEncargadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet11 = new ihc.bdDataSet11();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lineasTableAdapter = new ihc.bdDataSet11TableAdapters.LineasTableAdapter();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet11)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(27, 29);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(691, 374);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.button16);
            this.TabPage1.Controls.Add(this.button1);
            this.TabPage1.Controls.Add(this.button14);
            this.TabPage1.Controls.Add(this.DataGridView1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(683, 348);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Lineas";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(548, 297);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 32);
            this.button16.TabIndex = 29;
            this.button16.Text = "Borrar";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(17, 297);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 32);
            this.button14.TabIndex = 27;
            this.button14.Text = "Nuevo";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.precioRentaDataGridViewTextBoxColumn,
            this.usuarioEncargadoDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.lineasBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(110, 50);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(460, 204);
            this.DataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // lineaDataGridViewTextBoxColumn
            // 
            this.lineaDataGridViewTextBoxColumn.DataPropertyName = "Linea";
            this.lineaDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaDataGridViewTextBoxColumn.Name = "lineaDataGridViewTextBoxColumn";
            // 
            // precioRentaDataGridViewTextBoxColumn
            // 
            this.precioRentaDataGridViewTextBoxColumn.DataPropertyName = "Precio Renta";
            this.precioRentaDataGridViewTextBoxColumn.HeaderText = "Precio Renta";
            this.precioRentaDataGridViewTextBoxColumn.Name = "precioRentaDataGridViewTextBoxColumn";
            // 
            // usuarioEncargadoDataGridViewTextBoxColumn
            // 
            this.usuarioEncargadoDataGridViewTextBoxColumn.DataPropertyName = "Usuario Encargado";
            this.usuarioEncargadoDataGridViewTextBoxColumn.HeaderText = "Usuario Encargado";
            this.usuarioEncargadoDataGridViewTextBoxColumn.Name = "usuarioEncargadoDataGridViewTextBoxColumn";
            // 
            // lineasBindingSource
            // 
            this.lineasBindingSource.DataMember = "Lineas";
            this.lineasBindingSource.DataSource = this.bdDataSet11;
            // 
            // bdDataSet11
            // 
            this.bdDataSet11.DataSetName = "bdDataSet11";
            this.bdDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.button15);
            this.TabPage2.Controls.Add(this.TextBox4);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Controls.Add(this.TextBox3);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.TextBox2);
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this.TextBox1);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(683, 348);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Detalles";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(274, 298);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 32);
            this.button15.TabIndex = 26;
            this.button15.Text = "Guardar";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // TextBox4
            // 
            this.TextBox4.Enabled = false;
            this.TextBox4.Location = new System.Drawing.Point(176, 190);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(76, 20);
            this.TextBox4.TabIndex = 7;
            this.TextBox4.Text = "Rafael Orozco";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(52, 185);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 24);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Encargado";
            // 
            // TextBox3
            // 
            this.TextBox3.Enabled = false;
            this.TextBox3.Location = new System.Drawing.Point(176, 137);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(76, 20);
            this.TextBox3.TabIndex = 5;
            this.TextBox3.Text = "100,000";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(49, 132);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(118, 24);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Precio Renta";
            // 
            // TextBox2
            // 
            this.TextBox2.Enabled = false;
            this.TextBox2.Location = new System.Drawing.Point(125, 83);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(279, 20);
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Text = "Regla Laser S-240";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(53, 83);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Línea";
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(125, 39);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(76, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "00001";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(53, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "ID";
            // 
            // lineasTableAdapter
            // 
            this.lineasTableAdapter.ClearBeforeFill = true;
            // 
            // ventanaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 431);
            this.Controls.Add(this.TabControl1);
            this.Name = "ventanaCategorias";
            this.Text = "ventanaCategorias";
            this.Load += new System.EventHandler(this.ventanaCategorias_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet11)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        private bdDataSet11 bdDataSet11;
        private System.Windows.Forms.BindingSource lineasBindingSource;
        private bdDataSet11TableAdapters.LineasTableAdapter lineasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioRentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioEncargadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
    }
}