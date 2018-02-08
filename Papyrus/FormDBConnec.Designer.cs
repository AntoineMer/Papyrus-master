namespace Papyrus
{
    partial class FormDBConnec
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxServeur = new System.Windows.Forms.TextBox();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.labelServeur = new System.Windows.Forms.Label();
            this.labelDB = new System.Windows.Forms.Label();
            this.buttonConnec = new System.Windows.Forms.Button();
            this.buttonDeco = new System.Windows.Forms.Button();
            this.buttonLea = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxServeur
            // 
            this.textBoxServeur.Location = new System.Drawing.Point(156, 32);
            this.textBoxServeur.Name = "textBoxServeur";
            this.textBoxServeur.Size = new System.Drawing.Size(100, 20);
            this.textBoxServeur.TabIndex = 0;
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(156, 70);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(100, 20);
            this.textBoxDB.TabIndex = 1;
            // 
            // labelServeur
            // 
            this.labelServeur.AutoSize = true;
            this.labelServeur.Location = new System.Drawing.Point(100, 35);
            this.labelServeur.Name = "labelServeur";
            this.labelServeur.Size = new System.Drawing.Size(50, 13);
            this.labelServeur.TabIndex = 2;
            this.labelServeur.Text = "Serveur :";
            // 
            // labelDB
            // 
            this.labelDB.AutoSize = true;
            this.labelDB.Location = new System.Drawing.Point(54, 70);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(96, 13);
            this.labelDB.TabIndex = 3;
            this.labelDB.Text = "Base de données :";
            // 
            // buttonConnec
            // 
            this.buttonConnec.Location = new System.Drawing.Point(45, 119);
            this.buttonConnec.Name = "buttonConnec";
            this.buttonConnec.Size = new System.Drawing.Size(75, 23);
            this.buttonConnec.TabIndex = 4;
            this.buttonConnec.Text = "Connexion";
            this.buttonConnec.UseVisualStyleBackColor = true;
            this.buttonConnec.Click += new System.EventHandler(this.buttonConnec_Click);
            // 
            // buttonDeco
            // 
            this.buttonDeco.Location = new System.Drawing.Point(156, 119);
            this.buttonDeco.Name = "buttonDeco";
            this.buttonDeco.Size = new System.Drawing.Size(79, 23);
            this.buttonDeco.TabIndex = 5;
            this.buttonDeco.Text = "Déconnexion";
            this.buttonDeco.UseVisualStyleBackColor = true;
            this.buttonDeco.Click += new System.EventHandler(this.buttonDeco_Click);
            // 
            // buttonLea
            // 
            this.buttonLea.Location = new System.Drawing.Point(156, 148);
            this.buttonLea.Name = "buttonLea";
            this.buttonLea.Size = new System.Drawing.Size(79, 23);
            this.buttonLea.TabIndex = 6;
            this.buttonLea.Text = "Quitter";
            this.buttonLea.UseVisualStyleBackColor = true;
            this.buttonLea.Click += new System.EventHandler(this.buttonLea_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 104);
            this.textBox1.TabIndex = 7;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(47, 187);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(148, 13);
            this.labelState.TabIndex = 8;
            this.labelState.Text = "Etat de la connexion : Closed ";
            // 
            // timer1
            // 
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherUnFournisseurToolStripMenuItem,
            this.rechercherUneCommandeToolStripMenuItem,
            this.modifierUnFournisseurToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // rechercherUnFournisseurToolStripMenuItem
            // 
            this.rechercherUnFournisseurToolStripMenuItem.Name = "rechercherUnFournisseurToolStripMenuItem";
            this.rechercherUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rechercherUnFournisseurToolStripMenuItem.Text = "Rechercher un fournisseur";
            this.rechercherUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.rechercherUnFournisseurToolStripMenuItem_Click);
            // 
            // rechercherUneCommandeToolStripMenuItem
            // 
            this.rechercherUneCommandeToolStripMenuItem.Name = "rechercherUneCommandeToolStripMenuItem";
            this.rechercherUneCommandeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rechercherUneCommandeToolStripMenuItem.Text = "Rechercher une commande";
            this.rechercherUneCommandeToolStripMenuItem.Click += new System.EventHandler(this.rechercherUneCommandeToolStripMenuItem_Click);
            // 
            // modifierUnFournisseurToolStripMenuItem
            // 
            this.modifierUnFournisseurToolStripMenuItem.Name = "modifierUnFournisseurToolStripMenuItem";
            this.modifierUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.modifierUnFournisseurToolStripMenuItem.Text = "Modifier un fournisseur";
            this.modifierUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.modifierUnFournisseurToolStripMenuItem_Click);
            // 
            // FormDBConnec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLea);
            this.Controls.Add(this.buttonDeco);
            this.Controls.Add(this.buttonConnec);
            this.Controls.Add(this.labelDB);
            this.Controls.Add(this.labelServeur);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.textBoxServeur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDBConnec";
            this.Text = "Connexion à la base de données";
            this.Load += new System.EventHandler(this.FormDBConnec_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServeur;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.Label labelServeur;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.Button buttonConnec;
        private System.Windows.Forms.Button buttonDeco;
        private System.Windows.Forms.Button buttonLea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnFournisseurToolStripMenuItem;
    }
}

