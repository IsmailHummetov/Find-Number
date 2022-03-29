namespace kontrol_yapilar_form
{
    partial class Form1
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
            this.btnTexmin = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblCavab = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTexmin
            // 
            this.btnTexmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTexmin.Location = new System.Drawing.Point(71, 61);
            this.btnTexmin.Name = "btnTexmin";
            this.btnTexmin.Size = new System.Drawing.Size(93, 27);
            this.btnTexmin.TabIndex = 0;
            this.btnTexmin.Text = "Texmin et";
            this.btnTexmin.UseVisualStyleBackColor = true;
            this.btnTexmin.Click += new System.EventHandler(this.btnTexmin_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasla.Location = new System.Drawing.Point(71, 94);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(93, 27);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Yeni eded";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblCavab
            // 
            this.lblCavab.AutoSize = true;
            this.lblCavab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCavab.Location = new System.Drawing.Point(8, 142);
            this.lblCavab.Name = "lblCavab";
            this.lblCavab.Size = new System.Drawing.Size(0, 16);
            this.lblCavab.TabIndex = 2;
            this.lblCavab.Click += new System.EventHandler(this.lblCavab_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(27, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(60, 22);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "label1";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 201);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblCavab);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnTexmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTexmin;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblCavab;
        public System.Windows.Forms.Label lblText;
    }
}

