// ***********************************************************************
// Assembly         : TestMaker
// Author           : m_c_w
// Created          : 06-23-2019
//
// Last Modified By : m_c_w
// Last Modified On : 06-27-2019
// ***********************************************************************
// <copyright file="Form1.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class Form1.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            FillTopics(1);
        }

        /// <summary>
        /// Fills the topics.
        /// </summary>
        /// <param name="iGrid">The i grid.</param>
        private void FillTopics(int iGrid)
        {
            DataSet ds = new DataSet();
            ds = General.GetData("select TopicID as ID,TopicName as Name from Topics");

            switch(iGrid)
            {
                case 1:
                    dgvTopics.DataSource = ds;
                    dgvTopics.DataMember = "Data_Table";
                    dgvTopics.RowHeadersVisible = false;
                    dgvTopics.Columns[0].Visible = false;
                    dgvTopics.Columns[1].HeaderText = "Topic Name";
                    dgvTopics.Columns[1].Width = 400;
                    dgvTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case 2:
                    dgv_Quest_Topics.DataSource = ds;
                    dgv_Quest_Topics.DataMember = "Data_Table";
                    dgv_Quest_Topics.RowHeadersVisible = false;
                    dgv_Quest_Topics.Columns[0].Visible = false;
                    dgv_Quest_Topics.Columns[1].HeaderText = "Topic Name";
                    dgv_Quest_Topics.Columns[1].Width = 400;
                    dgv_Quest_Topics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
            }
        }

        /// <summary>
        /// Fills the sub topics.
        /// </summary>
        /// <param name="iGrid">The i grid.</param>
        /// <param name="tID">The t identifier.</param>
        private void FillSubTopics(int iGrid, string tID)
        {
            switch (iGrid)
            {
                case 1:
                    DataSet dsub1 = new DataSet();
                    dsub1 = General.GetData("select SubTopicID as subID, TopicID as topID,SubTopicName as subName from SubTopics where TopicID = " + tID);
                    dgvSubTopics.DataSource = dsub1;
                    dgvSubTopics.DataMember = "Data_Table";
                    dgvSubTopics.RowHeadersVisible = false;
                    dgvSubTopics.Columns[0].Visible = false;
                    dgvSubTopics.Columns[1].Visible = false;
                    dgvSubTopics.Columns[2].HeaderText = "SubTopic Name";
                    dgvSubTopics.Columns[2].Width = 400;
                    dgvSubTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
                case 2:
                    //DataSet dsub2 = new DataSet();
                    //dsub2 = General.GetData("select SubTopicID as subID, TopicID as topID,SubTopicName as subName from SubTopics where TopicID = " + tID);
                    //dgv_Quest_SubTopics.DataSource = dsub2;
                    //dgv_Quest_SubTopics.DataMember = "Data_Table";
                    //dgv_Quest_SubTopics.RowHeadersVisible = false;
                    //dgv_Quest_SubTopics.Columns[0].Visible = false;
                    //dgv_Quest_SubTopics.Columns[1].Visible = false;
                    //dgv_Quest_SubTopics.Columns[2].HeaderText = "SubTopic Name";
                    //dgv_Quest_SubTopics.Columns[2].Width = 400;
                    //dgv_Quest_SubTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnTopicTextClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnTopicTextClear_Click(object sender, EventArgs e)
        {
            btnAddUpdateTopic.Text = "Add";
            txtTopic.Clear();
            dgvTopics.ClearSelection();
        }

        /// <summary>
        /// Handles the Click event of the BtnAddUpdateTopic control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAddUpdateTopic_Click(object sender, EventArgs e)
        {
            bool result = false;
            switch (btnAddUpdateTopic.Text.ToUpper())
            {
                case "ADD":
                    string addTopic = "Insert into dbo.Topics Values ('" + txtTopic.Text + "')";
                    result = General.AddUpdate(addTopic);
                    if (result == false)
                    {
                        MessageBox.Show("There was a problem Adding the new Topic!", "Problem Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvTopics.ClearSelection();
                        txtTopic.Text = "";
                        dgvTopics.DataSource = null;
                        FillTopics(1);
                        MessageBox.Show("Topic Added!", "Topic Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "UPDATE":
                    string topID = dgvTopics.CurrentRow.Cells[0].Value.ToString();
                    string updTopic = "Update dbo.Topics Set TopicName = '" + txtTopic.Text + "' Where TopicID = " + topID;
                    result = General.AddUpdate(updTopic);
                    if (result == false)
                    {
                        MessageBox.Show("There was a problem Updating the Topic!", "Problem Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvTopics.ClearSelection();
                        txtTopic.Text = "";
                        btnAddUpdateTopic.Text = "Add";
                        dgvTopics.DataSource = null;
                        FillTopics(1);
                        MessageBox.Show("Topic Updated!", "Topic Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
            }

        }

        /// <summary>
        /// Handles the Click event of the BtnAddUpdateSubTopics control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnAddUpdateSubTopics_Click(object sender, EventArgs e)
        {
            bool result = false;
            switch (btnAddUpdateSubTopics.Text.ToUpper())
            {
                case "ADD":
                    string sqlTopic = "Insert into dbo.SubTopics Values (" + dgvTopics.CurrentRow.Cells[0].Value.ToString() + ", '" + txtSubTopics.Text + "')";
                    result = General.AddUpdate(sqlTopic);
                    if (result == false)
                    {
                        MessageBox.Show("There was a problem Adding the new SubTopic!", "Problem Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvSubTopics.ClearSelection();
                        txtSubTopics.Text = "";
                        btnAddUpdateSubTopics.Text = "Add";
                        dgvSubTopics.DataSource = null;
                        FillSubTopics(1, dgvTopics.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("SubTopic Added!", "SubTopic Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case "UPDATE":
                    General.TS_SelectedSubTopic = dgvSubTopics.CurrentRow.Cells[0].Value.ToString();
                    string updTopic = "Update dbo.SubTopics Set SubTopicName = '" + txtSubTopics.Text + "' Where SubTopicID = " + General.TS_SelectedSubTopic;
                    result = General.AddUpdate(updTopic);
                    if (result == false)
                    {
                        MessageBox.Show("There was a problem Updating the SubTopic!", "Problem Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvSubTopics.ClearSelection();
                        txtSubTopics.Text = "";
                        btnAddUpdateSubTopics.Text = "Add";
                        dgvSubTopics.DataSource = null;
                        FillSubTopics(2, dgvTopics.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("SubTopic Updated!", "SubTopic Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnSubTopicTextClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSubTopicTextClear_Click(object sender, EventArgs e)
        {
            btnAddUpdateSubTopics.Text = "Add";
            txtSubTopics.Clear();
            dgvSubTopics.ClearSelection();
            dgvSubTopics.DataSource = null;

        }

        /// <summary>
        /// Handles the CellContentClick event of the DgvTopics control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void DgvTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTopic.Text = dgvTopics.CurrentRow.Cells[1].Value.ToString();
            General.TS_SelectedTopic = dgvTopics.CurrentRow.Cells[0].Value.ToString();
            btnAddUpdateTopic.Text = "Update";
            FillSubTopics(1, General.TS_SelectedTopic);
        }

        /// <summary>
        /// Handles the CellContentClick event of the DgvSubTopics control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void DgvSubTopics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubTopics.Text = dgvSubTopics.CurrentRow.Cells[2].Value.ToString();
            btnAddUpdateSubTopics.Text = "Update";
        }

        /// <summary>Handles the Click event of the TabTest control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabTest_Click(object sender, EventArgs e)
        {
            switch (tabTest.SelectedIndex)
            {
                case 0:
                case 2:
                    break;
                case 1:
                    FillTopics(2); // fill the topics
                    break;
            }
        }
    }

}
