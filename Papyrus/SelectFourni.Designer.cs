namespace Papyrus
{
    partial class SelectFourni
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
            this.textBoxCdeFourni = new System.Windows.Forms.TextBox();
            this.labelCdeFourni = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCdeFourni
            // 
            this.textBoxCdeFourni.Location = new System.Drawing.Point(172, 21);
            this.textBoxCdeFourni.Name = "textBoxCdeFourni";
            this.textBoxCdeFourni.Size = new System.Drawing.Size(100, 20);
            this.textBoxCdeFourni.TabIndex = 0;
            // 
            // labelCdeFourni
            // 
            this.labelCdeFourni.AutoSize = true;
            this.labelCdeFourni.Location = new System.Drawing.Point(43, 21);
            this.labelCdeFourni.Name = "labelCdeFourni";
            this.labelCdeFourni.Size = new System.Drawing.Size(86, 13);
            this.labelCdeFourni.TabIndex = 1;
            this.labelCdeFourni.Text = "Code fournisseur";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(46, 63);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(172, 63);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(75, 23);
            this.buttonLeave.TabIndex = 3;
            this.buttonLeave.Text = "Quitter";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // SelectFourni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelCdeFourni);
            this.Controls.Add(this.textBoxCdeFourni);
            this.Name = "SelectFourni";
            this.Text = "Sélection";
            this.Load += new System.EventHandler(this.Papyrus2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCdeFourni;
        private System.Windows.Forms.Label labelCdeFourni;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonLeave;
    }
}