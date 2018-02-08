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

namespace UploadF
{
    public partial class UploadFourni : Form
    {
        SqlDataReader dataReader;
        dllConnec.Connection ConnectManager;
        public UploadFourni()
        {
            InitializeComponent();
        }
        public UploadFourni(dllConnec.Connection _dbConnection) : this()
        {
            ConnectManager = _dbConnection;
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listPara = new List<string>();
                List<string> listValues = new List<string>();
                listPara.Add("@num_four");
                listValues.Add(textBoxNumF.Text);
                dataReader = ConnectManager.GetDataReader("find_NOM", listPara, listValues);

                while (dataReader.Read())
                {
                    textBoxName.Text = dataReader.GetString(1);
                    textBoxStrt.Text = dataReader.GetString(2);
                    textBoxCP.Text = dataReader.GetString(3);
                    textBoxCity.Text = dataReader.GetString(4);
                    textBoxCon.Text = dataReader.GetString(5);
                    textBoxSatis.Text = dataReader.GetByte(6).ToString();
                }
                dataReader.Close();
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }

        private void buttonEmpty_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxStrt.Text = string.Empty;
            textBoxCP.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxCon.Text = string.Empty;
            textBoxSatis.Text = string.Empty;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> listPara = new List<string>();
                List<string> listValues = new List<string>();
                listPara.Add("@num");
                listPara.Add("@name");
                listPara.Add("@street");
                listPara.Add("@CP");
                listPara.Add("@city");
                listPara.Add("@cont");
                listPara.Add("@satis");
                listValues.Add(textBoxSaisieNum.Text);
                listValues.Add(textBoxName.Text);
                listValues.Add(textBoxStrt.Text);
                listValues.Add(textBoxCP.Text);
                listValues.Add(textBoxCity.Text);
                listValues.Add(textBoxCon.Text);
                listValues.Add(textBoxSatis.Text);
                dataReader = ConnectManager.GetDataReader("add_fourni", listPara, listValues);
                dataReader.Close();
                MessageBox.Show("Fournisseur ajouté");
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<string> listParam = new List<string>();
            List<string> listValues2 = new List<string>();
            bool canDelete = false;
            listParam.Add("@num");
            listValues2.Add(textBoxSaisieNum.Text);
            dataReader = ConnectManager.GetDataReader("canDelete", listParam, listValues2);
            while (dataReader.Read())
            {
                if (dataReader.GetString(0) != string.Empty)
                {
                    canDelete = false;
                    dataReader.Close();
                    break;
                }
                else
                {
                    canDelete = true;
                }
            }
            dataReader.Close();
            if (canDelete)
            {
                try
                {
                    List<string> listPara = new List<string>();
                    List<string> listValues = new List<string>();
                    listPara.Add("@num");
                    listValues.Add(textBoxSaisieNum.Text);

                    dataReader.Dispose();
                    dataReader.Close();
                    dataReader = ConnectManager.GetDataReader("del_fourni", listPara, listValues);
                    dataReader.Close();
                    MessageBox.Show("Fournisseur supprimé");


                }

                catch (Exception _e)
                {
                    MessageBox.Show(_e.Message);
                }
            }
            else
            {
                MessageBox.Show("Ce fournisseur a une commande en cours");
            }
            }
    }
}
