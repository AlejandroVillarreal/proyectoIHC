﻿namespace ihc
{
    partial class ventanaEditarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaEditarCategoria));
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(226, 212);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(76, 20);
            this.TextBox4.TabIndex = 15;
            this.TextBox4.Text = "Rafael Orozco";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(102, 207);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 24);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Encargado";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(226, 159);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(76, 20);
            this.TextBox3.TabIndex = 13;
            this.TextBox3.Text = "100,000";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(99, 154);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(118, 24);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Precio Renta";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(175, 105);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(279, 20);
            this.TextBox2.TabIndex = 11;
            this.TextBox2.Text = "Regla Laser S-240";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(103, 105);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 24);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Línea";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(175, 61);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(76, 20);
            this.TextBox1.TabIndex = 9;
            this.TextBox1.Text = "00001";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(103, 61);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(27, 24);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "ID";
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(342, 310);
            this.button15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 32);
            this.button15.TabIndex = 36;
            this.button15.Text = "Guardar";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ihc.Properties.Resources.go_back_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(477, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ventanaEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 371);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}