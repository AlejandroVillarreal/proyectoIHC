﻿namespace ihc
{
    partial class ventanaEditarServicio
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(576, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 96;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 95;
            this.label1.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "CAMBIO ACEITE DE MOTOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 29);
            this.label9.TabIndex = 93;
            this.label9.Text = "ID";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(375, 67);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(200, 22);
            this.textBox10.TabIndex = 92;
            this.textBox10.Text = "1";
            // 
            // ventanaEditarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox10);
            this.Name = "ventanaEditarServicio";
            this.Text = "ventanaEditarServicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
    }
}