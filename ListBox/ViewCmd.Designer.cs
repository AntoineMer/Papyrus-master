namespace ListBox
{
    partial class FormListBox
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
            this.papyrusDataSet = new ListBox.PapyrusDataSet();
            this.fOURNISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOURNISTableAdapter = new ListBox.PapyrusDataSetTableAdapters.FOURNISTableAdapter();
            this.labelFourniChoice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.papyrusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOURNISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // papyrusDataSet
            // 
            this.papyrusDataSet.DataSetName = "PapyrusDataSet";
            this.papyrusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOURNISBindingSource
            // 
            this.fOURNISBindingSource.DataMember = "FOURNIS";
            this.fOURNISBindingSource.DataSource = this.papyrusDataSet;
            // 
            // fOURNISTableAdapter
            // 
            this.fOURNISTableAdapter.ClearBeforeFill = true;
            // 
            // labelFourniChoice
            // 
            this.labelFourniChoice.AutoSize = true;
            this.labelFourniChoice.Location = new System.Drawing.Point(12, 33);
            this.labelFourniChoice.Name = "labelFourniChoice";
            this.labelFourniChoice.Size = new System.Drawing.Size(113, 13);
            this.labelFourniChoice.TabIndex = 1;
            this.labelFourniChoice.Text = "Choisir un fournisseur :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 95);
            this.listBox1.TabIndex = 3;
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelFourniChoice);
            this.Name = "FormListBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.papyrusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOURNISBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PapyrusDataSet papyrusDataSet;
        private System.Windows.Forms.BindingSource fOURNISBindingSource;
        private PapyrusDataSetTableAdapters.FOURNISTableAdapter fOURNISTableAdapter;
        private System.Windows.Forms.Label labelFourniChoice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

