using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using dllConnec;

namespace Papyrus
{
    public partial class FormDBConnec : Form
    {
        public Connection connec;
        public FormDBConnec()
        {
            InitializeComponent();
        }

        private void buttonConnec_Click(object sender, EventArgs e)
        {
            try
            {
                connec.Connect();
            }
            catch (Exception _e)
            {
                textBox1.Text = _e.Message;
            }
             
          
        }

        private void FormDBConnec_Load(object sender, EventArgs e)
        {
            connec = new Connection(Properties.Settings.Default.DB, Properties.Settings.Default.user_id, Properties.Settings.Default.DataSource, Properties.Settings.Default.Password);
            textBoxServeur.Text = Properties.Settings.Default.DataSource;
            textBoxDB.Text = Properties.Settings.Default.DB;
            connec.DBConnection.StateChange += connectionStateChange; // Connec est null à ce moment là. Il est créé ligne 28 au click du bouton !
        }

       public void connectionStateChange(object sender, EventArgs e)
        {
            labelState.Text = connec.DBConnection.State.ToString();
        }

        private void buttonDeco_Click(object sender, EventArgs e)
        {
            try
            {
                connec.DBConnection.Close();
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }

        private void buttonLea_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rechercherUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFourni papyrus2 = new SelectFourni(connec);
            papyrus2.ShowDialog();
        }

        private void rechercherUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox.FormListBox form = new ListBox.FormListBox(connec);
            form.ShowDialog();
        }

        private void modifierUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadF.UploadFourni ex4 = new UploadF.UploadFourni(connec);
            ex4.ShowDialog();
        }
    }
}
