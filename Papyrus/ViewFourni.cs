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
    public partial class Form1 : Form
    {
        SqlDataReader dataReader;
        dllConnec.Connection ConnectManager;
        public Form1(dllConnec.Connection _DBConnection)
        {
            InitializeComponent();
            ConnectManager = _DBConnection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> listPara = new List<string>();
                List<string> listValues = new List<string>();
                listPara.Add("@num_four");
                listValues.Add(SelectFourni.TextboxPap2);
                dataReader = ConnectManager.GetDataReader("find_NOM", listPara, listValues);

                while (dataReader.Read())
                {
                    textBoxName.Text = dataReader.GetString(1);
                    textBoxADD.Text = dataReader.GetString(2);
                    textBoxCP.Text = dataReader.GetString(3);
                    textBoxVille.Text = dataReader.GetString(4);
                    textBoxCONT.Text = dataReader.GetString(5);
                    textBoxStatis.Text = dataReader.GetByte(6).ToString();
                }

            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
    
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Close();

            if (SelectFourni.ActiveForm == null)
            {
                SelectFourni papyrus2 = new SelectFourni(ConnectManager);
                papyrus2.Show();
            }
            else
            {
                SelectFourni.ActiveForm.Focus();
            }
        }
    }
}
