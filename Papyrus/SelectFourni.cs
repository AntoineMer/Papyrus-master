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
namespace Papyrus
{
    public partial class SelectFourni : Form
    {
        private static string textboxPap2;
        private dllConnec.Connection DBConnection;
        public static string TextboxPap2
        {
            get { return SelectFourni.textboxPap2; }
            set { SelectFourni.textboxPap2 = value; }
        }

        

        public SelectFourni(dllConnec.Connection _DBconnection)
        {
            InitializeComponent();
            DBConnection = _DBconnection;
        }

        private void Papyrus2_Load(object sender, EventArgs e)
        {

        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            TextboxPap2 = textBoxCdeFourni.Text;
            Form1 papyrus21 = new Form1(DBConnection);
            papyrus21.Show();
            
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            SelectFourni.ActiveForm.Close();
        }
    }
}
