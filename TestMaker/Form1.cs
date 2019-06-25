using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillTopics();
        }

        private void FillTopics()
        {
            DataSet ds = new DataSet();
            ds = General.GetData("select TopicID,TopicName from Topics");

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                lstbxTopics.Items.Add(dr["TopicName"] + " : " + dr["TopicID"]);
            }
        }

        private void LstbxTopics_Click(object sender, EventArgs e)
        {
            //int idx = lstbxTopics.SelectedIndex;
            txtTopic.Text = lstbxTopics.SelectedItem.ToString();
            btnAddUpdateTopic.Text = "Update";
        }

        private void BtnTopicTextClear_Click(object sender, EventArgs e)
        {
            btnAddUpdateTopic.Text = "Add";
            txtTopic.Clear();
            lstbxTopics.SelectedIndex = -1;
            lstbxSubTopics.Items.Clear();
        }

        private void BtnAddUpdateTopic_Click(object sender, EventArgs e)
        {
            switch (btnAddUpdateTopic.Text.ToUpper())
            {
                case "ADD":

                    break;

                case "UPDATE":

                    break;
            }

        }

        private void BtnAddUpdateSubTopics_Click(object sender, EventArgs e)
        {
            switch (btnAddUpdateTopic.Text.ToUpper())
            {
                case "ADD":

                    break;

                case "UPDATE":

                    break;
            }
        }

        private void BtnSubTopicTextClear_Click(object sender, EventArgs e)
        {
            btnAddUpdateSubTopics.Text = "Add";
            txtSubTopics.Clear();
            lstbxSubTopics.SelectedIndex = -1;
        }

        private void LstbxSubTopics_Click(object sender, EventArgs e)
        {
            //int idx = lstbxTopics.SelectedIndex;
            txtTopic.Text = lstbxTopics.SelectedItem.ToString();
            btnAddUpdateSubTopics.Text = "Update";
        }
    }

}
