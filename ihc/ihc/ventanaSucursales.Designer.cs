namespace ihc
{
    partial class ventanaSucursales
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
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Button5 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.bdDataSet22 = new ihc.bdDataSet22();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalesTableAdapter = new ihc.bdDataSet22TableAdapters.SucursalesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(102, 342);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(119, 30);
            this.Button4.TabIndex = 9;
            this.Button4.Text = "Suspender";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(260, 342);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 28);
            this.Button3.TabIndex = 8;
            this.Button3.Text = "Nuevo";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(12, 343);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(68, 29);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "Editar";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(327, 311);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.DataGridView1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(319, 285);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Listado";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.sucursalesBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(29, 42);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(256, 202);
            this.DataGridView1.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Button5);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Controls.Add(this.TextBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(319, 285);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Detalle";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(95, 94);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(81, 23);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "Guardar";
            this.Button5.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(83, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Nombre de Sucursal";
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(41, 68);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(184, 20);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "Guadalajara";
            // 
            // bdDataSet22
            // 
            this.bdDataSet22.DataSetName = "bdDataSet22";
            this.bdDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataMember = "Sucursales";
            this.sucursalesBindingSource.DataSource = this.bdDataSet22;
            // 
            // sucursalesTableAdapter
            // 
            this.sucursalesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            // 
            // ventanaSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button2);
            this.Name = "ventanaSucursales";
            this.Text = "ventanaSucursales";
            this.Load += new System.EventHandler(this.ventanaSucursales_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        private bdDataSet22 bdDataSet22;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private bdDataSet22TableAdapters.SucursalesTableAdapter sucursalesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
    }
}