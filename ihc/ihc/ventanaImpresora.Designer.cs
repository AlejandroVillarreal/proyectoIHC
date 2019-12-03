namespace ihc
{
    partial class ventanaImpresora
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
            this.Button1 = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(224, 69);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 26);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Guardar cambios";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Brother MFC-J6930 DW",
            "HP Lasser Jet Pro1212 ",
            "PDF"});
            this.ComboBox1.Location = new System.Drawing.Point(12, 28);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(316, 21);
            this.ComboBox1.TabIndex = 3;
            this.ComboBox1.Text = "Seleccionar:";
            // 
            // ventanaImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 121);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ComboBox1);
            this.Name = "ventanaImpresora";
            this.Text = "ventanaImpresora";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ComboBox ComboBox1;
    }
}