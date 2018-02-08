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
namespace ListBox
{
    public partial class FormListBox : Form
    {
        SqlDataReader dataReader;
        SqlDataReader dataReaderListBox;
        dllConnec.Connection ConnectManager;
        public FormListBox()
        {
            InitializeComponent();
        }

        public FormListBox(dllConnec.Connection _dbConnection) : this()
        {
            ConnectManager = _dbConnection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("TOUS");
            dataReader = ConnectManager.GetDataReader("SELECT [NOMFOU] FROM [FOURNIS]", null, null);
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader.GetString(0));
            }
            dataReader.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "TOUS")
            {
                dataReaderListBox = ConnectManager.GetDataReader("SELECT * FROM ENTCOM", null, null);
                while (dataReaderListBox.Read())
                {

                    listBox1.Items.Add(dataReaderListBox.GetInt32(0));
                    listBox1.Items.Add(dataReaderListBox.GetString(1));
                    listBox1.Items.Add(dataReaderListBox.GetDateTime(2));
                    listBox1.Items.Add(dataReaderListBox.GetInt32(3));
                }
            }
            else
            {
                List<string> nom_para = new List<string>();
                List<string> value = new List<string>();
                nom_para.Add("@fourni_nom");
                value.Add(comboBox1.SelectedItem.ToString());
                dataReaderListBox = ConnectManager.GetDataReader("select_comm", nom_para, value);
                while (dataReaderListBox.Read())
                {
                    listBox1.Items.Add(dataReaderListBox.GetInt32(0));
                    listBox1.Items.Add(dataReaderListBox.GetDateTime(1));
                    listBox1.Items.Add(dataReaderListBox.GetString(2));
                }
            }
            dataReaderListBox.Close();
        }


    }
}

