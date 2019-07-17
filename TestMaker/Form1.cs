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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Windows.Controls;

namespace TestMaker
{
    /// <summary>
    /// Class Form1.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Form1 : Form
    {
        string randomFilename;
        private Font printFont;
        private StreamReader streamToPrint;


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
            FillProfiles();
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

        public void FillProTopics()
        {
            DataSet dsProTopics = new DataSet();
            dsProTopics = General.GetData("Select TopicID as ID,TopicName as Name from Topics Order By Name");

            List<string> _itms = new List<string>();

            _itms.Clear();

            foreach(DataRow dr in dsProTopics.Tables[0].Rows)
            {
                _itms.Add(dr["ID"].ToString() + " | " + dr["Name"].ToString());
            }

            lstProTopics.DataSource = _itms;
        }

        public void FillProSubTopics(string sTID)
        {
            DataSet dsProSubTopics = new DataSet();
            dsProSubTopics = General.GetData("Select SubTopicID, SubTopicName from SubTopics Where TopicID = " + sTID + " Order By SubTopicName");

            List<string> _itms = new List<string>();

            _itms.Clear();

            foreach (DataRow dr in dsProSubTopics.Tables[0].Rows)
            {
                _itms.Add(dr["SubTopicID"].ToString() + " | " + dr["SubTopicName"].ToString());
            }

            lstProSubTopics.DataSource = _itms;
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
                    DataSet dsub2 = new DataSet();
                    dsub2 = General.GetData("select SubTopicID as subID, TopicID as topID,SubTopicName as subName from SubTopics where TopicID = " + tID);
                    dgv_Quest_SubTopics.DataSource = dsub2;
                    dgv_Quest_SubTopics.DataMember = "Data_Table";
                    dgv_Quest_SubTopics.RowHeadersVisible = false;
                    dgv_Quest_SubTopics.Columns[0].Visible = false;
                    dgv_Quest_SubTopics.Columns[1].Visible = false;
                    dgv_Quest_SubTopics.Columns[2].HeaderText = "SubTopic Name";
                    dgv_Quest_SubTopics.Columns[2].Width = 400;
                    dgv_Quest_SubTopics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    break;
            }
        }

        /// <summary>Fills the questions.</summary>
        private void FillQuestions()
        {
            dgv_Questions.DataSource = null;
            DataSet dsQST = new DataSet();
            dsQST = General.GetData("Select Quest_Topic, Quest_SubTopic, Quest_ID From Questions Order By Quest_Topic, Quest_SubTopic, Quest_ID");
            dgv_Questions.DataSource = dsQST;
            dgv_Questions.DataMember = "Data_Table";
            dgv_Questions.RowHeadersVisible = false;
            dgv_Questions.Columns[0].HeaderText = "Topic ID";
            dgv_Questions.Columns[1].HeaderText = "SubTopic ID";
            dgv_Questions.Columns[2].HeaderText = "Question ID";
            dgv_Questions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                    break;
                case 1:
                    FillQuestions();
                    FillTopics(2); // fill the topics
                    break;
                case 2:
                    FillProTopics();
                    break;

            }
        }


        // ------------------------------------------------------------------------------
        // Questions
        // ------------------------------------------------------------------------------

        /// <summary>Handles the CellContentClick event of the Dgv_Quest_Topics control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void Dgv_Quest_Topics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            General.QTS_SelectedTopic = dgv_Quest_Topics.CurrentRow.Cells[0].Value.ToString();
            FillSubTopics(2, General.QTS_SelectedTopic);
        }

        /// <summary>Clears the question.</summary>
        private void ClearQuestion()
        {
            dgv_Questions.DataSource = null;
            dgv_Quest_Topics.ClearSelection();
            dgv_Quest_SubTopics.ClearSelection();

            cbo_Quest_Type.SelectedIndex = -1;

            rbtn_Quest_Diff_1.Checked = false;
            rbtn_Quest_Diff_2.Checked = false;
            rbtn_Quest_Diff_3.Checked = false;
            rbtn_Quest_Diff_4.Checked = false;
            rbtn_Quest_Diff_5.Checked = false;

            txt_Quest_Stem.Text = "";

            txt_Quest_Distractor_1.Text = "";
            txt_Quest_Distractor_2.Text = "";
            txt_Quest_Distractor_3.Text = "";
            txt_Quest_Distractor_4.Text = "";
            txt_Quest_Distractor_5.Text = "";

            rbtn_Quest_Answer_1.Checked = false;
            rbtn_Quest_Answer_2.Checked = false;
            rbtn_Quest_Answer_3.Checked = false;
            rbtn_Quest_Answer_4.Checked = false;
            rbtn_Quest_Answer_5.Checked = false;

            FillQuestions();
            dgv_Questions.ClearSelection();
            btn_Quest_AddUpdate.Text = "Add";
        }

        private void Btn_Quest_Clear_Click(object sender, EventArgs e)
        {
            ClearQuestion();
        }

        /// <summary>Handles the Click event of the Btn_Quest_AddUpdate control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btn_Quest_AddUpdate_Click(object sender, EventArgs e)
        {
            if(btn_Quest_AddUpdate.Text == "Add")
            {
                bool bRsltA = false;

                int iQstDiff = 1;
                if (rbtn_Quest_Diff_1.Checked) { iQstDiff = 1; }
                if (rbtn_Quest_Diff_2.Checked) { iQstDiff = 2; }
                if (rbtn_Quest_Diff_3.Checked) { iQstDiff = 3; }
                if (rbtn_Quest_Diff_4.Checked) { iQstDiff = 4; }
                if (rbtn_Quest_Diff_5.Checked) { iQstDiff = 5; }

                int iQstAns = 1;
                if (rbtn_Quest_Answer_1.Checked) { iQstAns = 1; }
                if (rbtn_Quest_Answer_2.Checked) { iQstAns = 2; }
                if (rbtn_Quest_Answer_3.Checked) { iQstAns = 3; }
                if (rbtn_Quest_Answer_4.Checked) { iQstAns = 4; }
                if (rbtn_Quest_Answer_5.Checked) { iQstAns = 5; }

                string sQstAdd = "insert into dbo.Questions values (" +
                    dgv_Quest_Topics.CurrentRow.Cells[0].Value.ToString() + ", " +
                    dgv_Quest_SubTopics.CurrentRow.Cells[0].Value.ToString() + ", " +
                    (cbo_Quest_Type.SelectedIndex).ToString() + ", " +
                    iQstDiff.ToString() + ", " +
                    "'" + txt_Quest_Stem.Text + "', " +
                    "'" + txt_Quest_Distractor_1.Text + "', " +
                    "'" + txt_Quest_Distractor_2.Text + "', " +
                    "'" + txt_Quest_Distractor_3.Text + "', " +
                    "'" + txt_Quest_Distractor_4.Text + "', " +
                    "'" + txt_Quest_Distractor_5.Text + "', " +
                    iQstAns.ToString() + ")";

                bRsltA = General.AddUpdate(sQstAdd);
                if (bRsltA == false)
                {
                    MessageBox.Show("There was a problem Adding the new Question!", "Problem Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgv_Questions.ClearSelection();
                    btn_Quest_AddUpdate.Text = "Add";
                    dgv_Questions.DataSource = null;
                    FillQuestions();
                    ClearQuestion();
                    MessageBox.Show("Question Added!", "Question Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                bool bRsltA = false;

                int iQstDiff = 1;
                if (rbtn_Quest_Diff_1.Checked) { iQstDiff = 1; }
                if (rbtn_Quest_Diff_2.Checked) { iQstDiff = 2; }
                if (rbtn_Quest_Diff_3.Checked) { iQstDiff = 3; }
                if (rbtn_Quest_Diff_4.Checked) { iQstDiff = 4; }
                if (rbtn_Quest_Diff_5.Checked) { iQstDiff = 5; }

                int iQstAns = 1;
                if (rbtn_Quest_Answer_1.Checked) { iQstAns = 1; }
                if (rbtn_Quest_Answer_2.Checked) { iQstAns = 2; }
                if (rbtn_Quest_Answer_3.Checked) { iQstAns = 3; }
                if (rbtn_Quest_Answer_4.Checked) { iQstAns = 4; }
                if (rbtn_Quest_Answer_5.Checked) { iQstAns = 5; }

                string sQstUpd = "Update dbo.Questions Set" +
                                " Quest_Type = " + (cbo_Quest_Type.SelectedIndex).ToString() + "," +
                                " Quest_Difficulty = " + iQstDiff.ToString() + "," +
                                " Quest_Stem = '" + txt_Quest_Stem.Text + "'," +
                                " Quest_Distractor_A = '" + txt_Quest_Distractor_1.Text + "'," +
                                " Quest_Distractor_B = '" + txt_Quest_Distractor_2.Text + "'," +
                                " Quest_Distractor_C = '" + txt_Quest_Distractor_3.Text + "'," +
                                " Quest_Distractor_D = '" + txt_Quest_Distractor_4.Text + "'," +
                                " Quest_Distractor_E = '" + txt_Quest_Distractor_5.Text + "'," +
                                " Quest_Answer = " + iQstAns.ToString() + " Where Quest_ID = " + dgv_Questions.CurrentRow.Cells[2].Value.ToString();

                bRsltA = General.AddUpdate(sQstUpd);
                if (bRsltA == false)
                {
                    MessageBox.Show("There was a problem Updating the Question!", "Problem Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgv_Questions.ClearSelection();
                    btn_Quest_AddUpdate.Text = "Add";
                    dgv_Questions.DataSource = null;
                    FillQuestions();
                    ClearQuestion();
                    MessageBox.Show("Question Updated!", "Question Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }

        /// <summary>Handles the Click event of the Dgv_Questions control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Dgv_Questions_Click(object sender, EventArgs e)
        {
            General.QTS_SelectedQuestion = dgv_Questions.CurrentRow.Cells[2].Value.ToString();

            string QuestSQL = "SELECT [Quest_ID] " +
                              ",[Quest_Topic] " +
                              ",[Quest_SubTopic] " +
                              ",[Quest_Type] " +
                              ",[Quest_Difficulty] " +
                              ",[Quest_Stem] " +
                              ",[Quest_Distractor_A] " +
                              ",[Quest_Distractor_B] " +
                              ",[Quest_Distractor_C] " +
                              ",[Quest_Distractor_D] " +
                              ",[Quest_Distractor_E] " +
                              ",[Quest_Answer] " +
                              "  FROM [TestDB].[dbo].[Questions] " +
                              "  WHERE [Quest_ID] = " + General.QTS_SelectedQuestion;

            DataSet GetQuestDS = new DataSet();
            GetQuestDS = General.GetData(QuestSQL);

            int QID = Convert.ToInt32(GetQuestDS.Tables[0].Rows[0]["Quest_ID"].ToString());
            int QTopic = Convert.ToInt32(GetQuestDS.Tables[0].Rows[0]["Quest_Topic"].ToString());
            int QSubTopic = Convert.ToInt32(GetQuestDS.Tables[0].Rows[0]["Quest_SubTopic"].ToString());
            int QType = Convert.ToInt32(GetQuestDS.Tables[0].Rows[0]["Quest_Type"].ToString());
            int QDifficulty = Convert.ToInt32(GetQuestDS.Tables[0].Rows[0]["Quest_Difficulty"].ToString());
            string QStem = GetQuestDS.Tables[0].Rows[0]["Quest_Stem"].ToString();
            string QDistractorA = GetQuestDS.Tables[0].Rows[0]["Quest_Distractor_A"].ToString();
            string QDistractorB = GetQuestDS.Tables[0].Rows[0]["Quest_Distractor_B"].ToString();
            string QDistractorC = GetQuestDS.Tables[0].Rows[0]["Quest_Distractor_C"].ToString();
            string QDistractorD = GetQuestDS.Tables[0].Rows[0]["Quest_Distractor_D"].ToString();
            string QDistractorE = GetQuestDS.Tables[0].Rows[0]["Quest_Distractor_E"].ToString();
            int QAnswer = Convert.ToInt32(GetQuestDS.Tables[0].Rows[0]["Quest_Answer"].ToString());



            cbo_Quest_Type.SelectedIndex = QType;

            switch (QDifficulty)
            {
                case 1:
                    rbtn_Quest_Diff_1.Checked = true;
                    break;
                case 2:
                    rbtn_Quest_Diff_2.Checked = true;
                    break;
                case 3:
                    rbtn_Quest_Diff_3.Checked = true;
                    break;
                case 4:
                    rbtn_Quest_Diff_4.Checked = true;
                    break;
                case 5:
                    rbtn_Quest_Diff_5.Checked = true;
                    break;
            }

            txt_Quest_Stem.Text = QStem;

            txt_Quest_Distractor_1.Text = QDistractorA;
            txt_Quest_Distractor_2.Text = QDistractorB;
            txt_Quest_Distractor_3.Text = QDistractorC;
            txt_Quest_Distractor_4.Text = QDistractorD;
            txt_Quest_Distractor_5.Text = QDistractorE;

            switch (QAnswer)
            {
                case 1:
                    rbtn_Quest_Answer_1.Checked = true;
                    break;
                case 2:
                    rbtn_Quest_Answer_2.Checked = true;
                    break;
                case 3:
                    rbtn_Quest_Answer_3.Checked = true;
                    break;
                case 4:
                    rbtn_Quest_Answer_4.Checked = true;
                    break;
                case 5:
                    rbtn_Quest_Answer_5.Checked = true;
                    break;
            }

            btn_Quest_AddUpdate.Text = "Update";
        }


        private void FillProfiles()
        {
            dgv_Profiles.DataSource = null;
            DataSet dsProfileNames = new DataSet();
            dsProfileNames = General.GetData("Select ID, Name From dbo.ProfileNames Order By Name");

            dgv_Profiles.DataSource = dsProfileNames;
            dgv_Profiles.DataMember = "Data_Table";

            dgv_Profiles.RowHeadersVisible = false;
            dgv_Profiles.Columns[0].HeaderText = "ID";
            dgv_Profiles.Columns[1].HeaderText = "Name";
            dgv_Profiles.Columns[0].Width = 100;
            dgv_Profiles.Columns[1].Width = dgv_Profiles.Width - 120;
            dgv_Profiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            randomFilename = "C:\\temp\\" + Guid.NewGuid().ToString() + ".txt";

            string path = randomFilename;

            using (StreamWriter sr = File.AppendText(path))
            {
                string[] words = { "anemone", "wagstaff", "man", "the", "for", "and", "a", "with", "bird", "fox", "bulldog", "pug", "mutt", "kitten", "an","snake","woman","Judy","Rob","Mike" };

                for (int nq = 0; nq < 20; nq++)
                {
                    sr.WriteLine("     Topic: 1001 / SubTopic: 1002");

                    RandomText text = new RandomText(words);
                    text.AddContentParagraphs(1, 2, 4, 8, 12);
                    string content = text.Content;

                    string[] wrds = content.Split(' ');




                    string ssline = "";
                    int linecount = 0;
                    for (int w = 0; w < wrds.Count(); w++)
                    {
                        ssline = (ssline + wrds[w]) + " ";
                        if (ssline.Length > 65)
                        {
                            linecount++;
                            ssline = "";
                        }
                    }
                    if (ssline.Length > 0)
                    {
                        linecount++;
                    }
                    if((linecount + 1) > 55)
                    {
                        sr.WriteLine("\f");
                    }


                    string sline = "";

                    bool bfrst = true;

                    for (int w = 0; w < wrds.Count(); w++)
                    {
                        sline = (sline + wrds[w]) + " ";
                        if(sline.Length > 65)
                        {
                            string qhdr = "     ";
                            if (bfrst)
                            {
                                qhdr = General.Left((nq + 1).ToString() + ")     ",5);
                                bfrst = false;
                            }
                            sr.WriteLine(qhdr + sline);
                            sline = "";
                        }
                    }

                    if(sline.Length > 0)
                    {
                        sr.WriteLine("     " + sline);
                    }
                    
                }

                sr.Close();

                PrintGeneratedExam(randomFilename);

                File.Delete(randomFilename);

            }
        }


        private void PrintGeneratedExam(string sPrintFilename)
        {
            try
            {
                streamToPrint = new StreamReader
                   (sPrintFilename);
                try
                {
                    printFont = new Font("Courier New", 10);
                    PrintDocument pd = new PrintDocument();
                    if (numtxtbx_NumCopies.Value < 1) { numtxtbx_NumCopies.Value = 1; }
                    pd.PrinterSettings.Copies = Convert.ToInt16(numtxtbx_NumCopies.Value);
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred Printing:  " + ex.Message);
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void BtnProfileNameAddUpd_Click(object sender, EventArgs e)
        {
            string sBtnText = btnProfileNameAddUpd.Text;
            switch (sBtnText.ToUpper())
            {
                case "ADD":
                    string sqlProAdd = "Insert Into dbo.ProfileNames (Name) Values (' " + txtProfileName.Text + " ')";
                    General.AddUpdate(sqlProAdd);
                    FillProfiles();
                    txtProfileName.Text = "";
                    break;
                case "UPDATE":
                    string sqlProUpd = "Update dbo.ProfileNames Set Name = '" + txtProfileName.Text + "' Where ID = " + "--------------------";
                    General.AddUpdate(sqlProUpd);
                    FillProfiles();
                    txtProfileName.Text = "";
                    break;
            }
        }

        private void Dgv_Profiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProfileName.Text = dgv_Profiles.CurrentRow.Cells[1].Value.ToString();
            General.PRO_SelectedName = dgv_Profiles.CurrentRow.Cells[0].Value.ToString();
            btnProfileNameAddUpd.Text = "Update";
        }

        private void BtnProfileNameClear_Click(object sender, EventArgs e)
        {
            FillProfiles();
            txtProfileName.Text = "";
            btnProfileNameAddUpd.Text = "Add";
        }

        private void BtnProfileNameDelete_Click(object sender, EventArgs e)
        {
            General.AddUpdate("Delete From [dbo].[ProfileNames] Where ID = " + dgv_Profiles.CurrentRow.Cells[0].Value.ToString());
            FillProfiles();
        }

        private void LstProTopics_Click(object sender, EventArgs e)
        {
            string selItm = lstProTopics.SelectedItem.ToString().Split('|')[0].Trim();

            FillProSubTopics(selItm);

            MessageBox.Show(selItm);
        }

        private void BtnProfileItemClear_Click(object sender, EventArgs e)
        {

        }
    }


}
