namespace Papyrus
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxADD = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.textBoxCONT = new System.Windows.Forms.TextBox();
            this.textBoxStatis = new System.Windows.Forms.TextBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelCP = new System.Windows.Forms.Label();
            this.labelCont = new System.Windows.Forms.Label();
            this.labelSatisf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(255, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxADD
            // 
            this.textBoxADD.Location = new System.Drawing.Point(255, 70);
            this.textBoxADD.Name = "textBoxADD";
            this.textBoxADD.Size = new System.Drawing.Size(100, 20);
            this.textBoxADD.TabIndex = 1;
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(290, 105);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 2;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(255, 105);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(29, 20);
            this.textBoxCP.TabIndex = 3;
            // 
            // textBoxCONT
            // 
            this.textBoxCONT.Location = new System.Drawing.Point(255, 164);
            this.textBoxCONT.Name = "textBoxCONT";
            this.textBoxCONT.Size = new System.Drawing.Size(100, 20);
            this.textBoxCONT.TabIndex = 4;
            // 
            // textBoxStatis
            // 
            this.textBoxStatis.Location = new System.Drawing.Point(255, 190);
            this.textBoxStatis.Name = "textBoxStatis";
            this.textBoxStatis.Size = new System.Drawing.Size(29, 20);
            this.textBoxStatis.TabIndex = 5;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(280, 217);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(75, 23);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(142, 32);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 7;
            this.labelNom.Text = "Nom :";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(142, 70);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(54, 13);
            this.labeladdress.TabIndex = 8;
            this.labeladdress.Text = "Adresse : ";
            // 
            // labelCP
            // 
            this.labelCP.AutoSize = true;
            this.labelCP.Location = new System.Drawing.Point(142, 105);
            this.labelCP.Name = "labelCP";
            this.labelCP.Size = new System.Drawing.Size(67, 13);
            this.labelCP.TabIndex = 9;
            this.labelCP.Text = "CP / VILLE :";
            // 
            // labelCont
            // 
            this.labelCont.AutoSize = true;
            this.labelCont.Location = new System.Drawing.Point(142, 164);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(50, 13);
            this.labelCont.TabIndex = 10;
            this.labelCont.Text = "Contact :";
            // 
            // labelSatisf
            // 
            this.labelSatisf.AutoSize = true;
            this.labelSatisf.Location = new System.Drawing.Point(142, 190);
            this.labelSatisf.Name = "labelSatisf";
            this.labelSatisf.Size = new System.Drawing.Size(68, 13);
            this.labelSatisf.TabIndex = 11;
            this.labelSatisf.Text = "Satisfaction :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 252);
            this.Controls.Add(this.labelSatisf);
            this.Controls.Add(this.labelCont);
            this.Controls.Add(this.labelCP);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.textBoxStatis);
            this.Controls.Add(this.textBoxCONT);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxADD);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Vue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxADD;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.TextBox textBoxCONT;
        private System.Windows.Forms.TextBox textBoxStatis;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelCP;
        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.Label labelSatisf;
    }
}