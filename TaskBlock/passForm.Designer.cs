﻿namespace TaskBlock
{
    partial class passForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passForm));
            this.img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(12, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(207, 196);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 3;
            this.img.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha:";
            // 
            // tbox_pass
            // 
            this.tbox_pass.Location = new System.Drawing.Point(68, 215);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.Size = new System.Drawing.Size(151, 20);
            this.tbox_pass.TabIndex = 5;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(12, 243);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(207, 25);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Entrar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(11, 274);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(207, 25);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Fechar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // passForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 309);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "passForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBlock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.passForm_FormClosing);
            this.Load += new System.EventHandler(this.passForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_close;
    }
}