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
            ds = General.GetData("select TopicID as ID,TopicName as Name from Topics");

            dgvTopics.DataSource = ds;
            dgvTopics.DataMember = "Data_Table";

            dgvTopics.RowHeadersVisible = false;

            dgvTopics.Columns[0].Visible = false;
            //dgvTopics.Columns[0].Width = 50;

            dgvTopics.Columns[1].HeaderText = "Topic Name";
            dgvTopics.Columns[1].Width = 400;

            dgvTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FillSubTopics(string tID)
        {
            DataSet dsub = new DataSet();
            dsub = General.GetData("select SubTopicID as subID, TopicID as topID,SubTopicName as subName from SubTopics where TopicID = " + tID);

            dgvSubTopics.DataSource = dsub;
            dgvSubTopics.DataMember = "Data_Table";

            dgvSubTopics.RowHeadersVisible = false;

            dgvSubTopics.Columns[0].Visible = false;
            dgvSubTopics.Columns[1].Visible = false;

            dgvSubTopics.Columns[2].HeaderText = "SubTopic Name";
            dgvSubTopics.Columns[2].Width = 400;

            dgvSubTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnTopicTextClear_Click(object sender, EventArgs e)
        {
            btnAddUpdateTopic.Text = "Add";
            txtTopic.Clear();
            dgvTopics.ClearSelection();
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
            dgvSubTopics.ClearSelection();
            dgvSubTopics.DataSource = null;

        }

        private void DgvTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTopic.Text = dgvTopics.CurrentRow.Cells[1].Value.ToString();
            General.SelectedTopic = dgvTopics.CurrentRow.Cells[0].Value.ToString();
            btnAddUpdateTopic.Text = "Update";
            FillSubTopics(General.SelectedTopic);
        }

        private void DgvSubTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubTopics.Text = dgvSubTopics.CurrentRow.Cells[2].Value.ToString();
            btnAddUpdateSubTopics.Text = "Update";
        }
    }

}
