namespace ihc
{
    partial class ventanaModeloMotor
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bdDataSet14 = new ihc.bdDataSet14();
            this.modeloMotorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloMotorTableAdapter = new ihc.bdDataSet14TableAdapters.ModeloMotorTableAdapter();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloMotorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(422, 258);
            this.TabControl1.TabIndex = 10;
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
            this.TabPage1.Size = new System.Drawing.Size(414, 232);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Lineas";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.potenciaDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.modeloMotorBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(36, 28);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(343, 134);
            this.DataGridView1.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.button2);
            this.TabPage2.Controls.Add(this.TextBox2);
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this.TextBox1);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(414, 232);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Detalles";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBox2
            // 
            this.TextBox2.Enabled = false;
            this.TextBox2.Location = new System.Drawing.Point(132, 86);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(76, 20);
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Text = "25 HP";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(28, 86);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Potencia";
            // 
            // TextBox1
            // 
            this.TextBox1.Enabled = false;
            this.TextBox1.Location = new System.Drawing.Point(132, 37);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(76, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "100SE";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(28, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Clave";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(277, 195);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(126, 32);
            this.button16.TabIndex = 33;
            this.button16.Text = "Borrar";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(146, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(11, 195);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 32);
            this.button14.TabIndex = 31;
            this.button14.Text = "Nuevo";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 147);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 36;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bdDataSet14
            // 
            this.bdDataSet14.DataSetName = "bdDataSet14";
            this.bdDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloMotorBindingSource
            // 
            this.modeloMotorBindingSource.DataMember = "ModeloMotor";
            this.modeloMotorBindingSource.DataSource = this.bdDataSet14;
            // 
            // modeloMotorTableAdapter
            // 
            this.modeloMotorTableAdapter.ClearBeforeFill = true;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // potenciaDataGridViewTextBoxColumn
            // 
            this.potenciaDataGridViewTextBoxColumn.DataPropertyName = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.HeaderText = "Potencia";
            this.potenciaDataGridViewTextBoxColumn.Name = "potenciaDataGridViewTextBoxColumn";
            // 
            // ventanaModeloMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.TabControl1);
            this.Name = "ventanaModeloMotor";
            this.Text = "ventanaModeloMotor";
            this.Load += new System.EventHandler(this.ventanaModeloMotor_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloMotorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button2;
        private bdDataSet14 bdDataSet14;
        private System.Windows.Forms.BindingSource modeloMotorBindingSource;
        private bdDataSet14TableAdapters.ModeloMotorTableAdapter modeloMotorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potenciaDataGridViewTextBoxColumn;
    }
}