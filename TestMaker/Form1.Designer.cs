namespace TestMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabTest = new System.Windows.Forms.TabControl();
            this.tabPageTopics = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSubTopics = new System.Windows.Forms.DataGridView();
            this.dgvTopics = new System.Windows.Forms.DataGridView();
            this.btnSubTopicTextClear = new System.Windows.Forms.Button();
            this.btnTopicTextClear = new System.Windows.Forms.Button();
            this.txtSubTopics = new System.Windows.Forms.TextBox();
            this.btnAddUpdateSubTopics = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.btnAddUpdateTopic = new System.Windows.Forms.Button();
            this.lblTopics = new System.Windows.Forms.Label();
            this.tabPageQuestions = new System.Windows.Forms.TabPage();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.dgv_Questions = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Quest_Create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Quest_Type = new System.Windows.Forms.ComboBox();
            this.rbtn_Quest_Diff_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_Quest_Diff_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Quest_Diff_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_Quest_Diff_4 = new System.Windows.Forms.RadioButton();
            this.rbtn_Quest_Diff_5 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Quest_Stem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Quest_Distractor_1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Quest_Distractor_2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Quest_Distractor_3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Quest_Distractor_4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Quest_Distractor_5 = new System.Windows.Forms.TextBox();
            this.btn_Quest_AddUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_Quest_Topics = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Quest_SubTopics = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.tabTest.SuspendLayout();
            this.tabPageTopics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).BeginInit();
            this.tabPageQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quest_Topics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quest_SubTopics)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Maker";
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.tabPageTopics);
            this.tabTest.Controls.Add(this.tabPageQuestions);
            this.tabTest.Controls.Add(this.tabPageTests);
            this.tabTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTest.Location = new System.Drawing.Point(31, 115);
            this.tabTest.Name = "tabTest";
            this.tabTest.SelectedIndex = 0;
            this.tabTest.Size = new System.Drawing.Size(947, 589);
            this.tabTest.TabIndex = 1;
            // 
            // tabPageTopics
            // 
            this.tabPageTopics.Controls.Add(this.label2);
            this.tabPageTopics.Controls.Add(this.dgvSubTopics);
            this.tabPageTopics.Controls.Add(this.dgvTopics);
            this.tabPageTopics.Controls.Add(this.btnSubTopicTextClear);
            this.tabPageTopics.Controls.Add(this.btnTopicTextClear);
            this.tabPageTopics.Controls.Add(this.txtSubTopics);
            this.tabPageTopics.Controls.Add(this.btnAddUpdateSubTopics);
            this.tabPageTopics.Controls.Add(this.txtTopic);
            this.tabPageTopics.Controls.Add(this.btnAddUpdateTopic);
            this.tabPageTopics.Controls.Add(this.lblTopics);
            this.tabPageTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTopics.Location = new System.Drawing.Point(4, 29);
            this.tabPageTopics.Name = "tabPageTopics";
            this.tabPageTopics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTopics.Size = new System.Drawing.Size(939, 556);
            this.tabPageTopics.TabIndex = 0;
            this.tabPageTopics.Text = "Topics / SubTopics";
            this.tabPageTopics.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SubTopics";
            // 
            // dgvSubTopics
            // 
            this.dgvSubTopics.AllowUserToAddRows = false;
            this.dgvSubTopics.AllowUserToDeleteRows = false;
            this.dgvSubTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubTopics.Location = new System.Drawing.Point(489, 35);
            this.dgvSubTopics.Name = "dgvSubTopics";
            this.dgvSubTopics.ReadOnly = true;
            this.dgvSubTopics.Size = new System.Drawing.Size(426, 383);
            this.dgvSubTopics.TabIndex = 12;
            this.dgvSubTopics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubTopics_CellContentClick);
            // 
            // dgvTopics
            // 
            this.dgvTopics.AllowUserToAddRows = false;
            this.dgvTopics.AllowUserToDeleteRows = false;
            this.dgvTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopics.Location = new System.Drawing.Point(26, 35);
            this.dgvTopics.Name = "dgvTopics";
            this.dgvTopics.ReadOnly = true;
            this.dgvTopics.Size = new System.Drawing.Size(426, 383);
            this.dgvTopics.TabIndex = 11;
            this.dgvTopics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTopics_CellContentClick);
            // 
            // btnSubTopicTextClear
            // 
            this.btnSubTopicTextClear.Location = new System.Drawing.Point(802, 488);
            this.btnSubTopicTextClear.Name = "btnSubTopicTextClear";
            this.btnSubTopicTextClear.Size = new System.Drawing.Size(113, 23);
            this.btnSubTopicTextClear.TabIndex = 10;
            this.btnSubTopicTextClear.Text = "Clear";
            this.btnSubTopicTextClear.UseVisualStyleBackColor = true;
            this.btnSubTopicTextClear.Click += new System.EventHandler(this.BtnSubTopicTextClear_Click);
            // 
            // btnTopicTextClear
            // 
            this.btnTopicTextClear.Location = new System.Drawing.Point(339, 488);
            this.btnTopicTextClear.Name = "btnTopicTextClear";
            this.btnTopicTextClear.Size = new System.Drawing.Size(113, 23);
            this.btnTopicTextClear.TabIndex = 9;
            this.btnTopicTextClear.Text = "Clear";
            this.btnTopicTextClear.UseVisualStyleBackColor = true;
            this.btnTopicTextClear.Click += new System.EventHandler(this.BtnTopicTextClear_Click);
            // 
            // txtSubTopics
            // 
            this.txtSubTopics.Location = new System.Drawing.Point(489, 431);
            this.txtSubTopics.Name = "txtSubTopics";
            this.txtSubTopics.Size = new System.Drawing.Size(426, 22);
            this.txtSubTopics.TabIndex = 8;
            // 
            // btnAddUpdateSubTopics
            // 
            this.btnAddUpdateSubTopics.Location = new System.Drawing.Point(802, 459);
            this.btnAddUpdateSubTopics.Name = "btnAddUpdateSubTopics";
            this.btnAddUpdateSubTopics.Size = new System.Drawing.Size(113, 23);
            this.btnAddUpdateSubTopics.TabIndex = 6;
            this.btnAddUpdateSubTopics.Text = "Add";
            this.btnAddUpdateSubTopics.UseVisualStyleBackColor = true;
            this.btnAddUpdateSubTopics.Click += new System.EventHandler(this.BtnAddUpdateSubTopics_Click);
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(26, 431);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(426, 22);
            this.txtTopic.TabIndex = 4;
            // 
            // btnAddUpdateTopic
            // 
            this.btnAddUpdateTopic.Location = new System.Drawing.Point(339, 459);
            this.btnAddUpdateTopic.Name = "btnAddUpdateTopic";
            this.btnAddUpdateTopic.Size = new System.Drawing.Size(113, 23);
            this.btnAddUpdateTopic.TabIndex = 2;
            this.btnAddUpdateTopic.Text = "Add";
            this.btnAddUpdateTopic.UseVisualStyleBackColor = true;
            this.btnAddUpdateTopic.Click += new System.EventHandler(this.BtnAddUpdateTopic_Click);
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Location = new System.Drawing.Point(23, 16);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(50, 16);
            this.lblTopics.TabIndex = 1;
            this.lblTopics.Text = "Topics";
            // 
            // tabPageQuestions
            // 
            this.tabPageQuestions.Controls.Add(this.groupBox1);
            this.tabPageQuestions.Controls.Add(this.label3);
            this.tabPageQuestions.Controls.Add(this.dgv_Quest_SubTopics);
            this.tabPageQuestions.Controls.Add(this.label14);
            this.tabPageQuestions.Controls.Add(this.dgv_Quest_Topics);
            this.tabPageQuestions.Controls.Add(this.btn_Quest_AddUpdate);
            this.tabPageQuestions.Controls.Add(this.label13);
            this.tabPageQuestions.Controls.Add(this.txt_Quest_Distractor_5);
            this.tabPageQuestions.Controls.Add(this.label12);
            this.tabPageQuestions.Controls.Add(this.txt_Quest_Distractor_4);
            this.tabPageQuestions.Controls.Add(this.label11);
            this.tabPageQuestions.Controls.Add(this.txt_Quest_Distractor_3);
            this.tabPageQuestions.Controls.Add(this.label10);
            this.tabPageQuestions.Controls.Add(this.txt_Quest_Distractor_2);
            this.tabPageQuestions.Controls.Add(this.label9);
            this.tabPageQuestions.Controls.Add(this.txt_Quest_Distractor_1);
            this.tabPageQuestions.Controls.Add(this.label8);
            this.tabPageQuestions.Controls.Add(this.txt_Quest_Stem);
            this.tabPageQuestions.Controls.Add(this.label7);
            this.tabPageQuestions.Controls.Add(this.rbtn_Quest_Diff_5);
            this.tabPageQuestions.Controls.Add(this.rbtn_Quest_Diff_4);
            this.tabPageQuestions.Controls.Add(this.rbtn_Quest_Diff_3);
            this.tabPageQuestions.Controls.Add(this.rbtn_Quest_Diff_2);
            this.tabPageQuestions.Controls.Add(this.rbtn_Quest_Diff_1);
            this.tabPageQuestions.Controls.Add(this.cbo_Quest_Type);
            this.tabPageQuestions.Controls.Add(this.label6);
            this.tabPageQuestions.Controls.Add(this.btn_Quest_Create);
            this.tabPageQuestions.Controls.Add(this.label5);
            this.tabPageQuestions.Controls.Add(this.dgv_Questions);
            this.tabPageQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQuestions.Location = new System.Drawing.Point(4, 29);
            this.tabPageQuestions.Name = "tabPageQuestions";
            this.tabPageQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuestions.Size = new System.Drawing.Size(939, 556);
            this.tabPageQuestions.TabIndex = 1;
            this.tabPageQuestions.Text = "Questions";
            this.tabPageQuestions.UseVisualStyleBackColor = true;
            // 
            // tabPageTests
            // 
            this.tabPageTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTests.Location = new System.Drawing.Point(4, 29);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Size = new System.Drawing.Size(939, 530);
            this.tabPageTests.TabIndex = 2;
            this.tabPageTests.Text = "Tests / Quizes";
            this.tabPageTests.UseVisualStyleBackColor = true;
            // 
            // dgv_Questions
            // 
            this.dgv_Questions.AllowUserToAddRows = false;
            this.dgv_Questions.AllowUserToDeleteRows = false;
            this.dgv_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Questions.Location = new System.Drawing.Point(18, 39);
            this.dgv_Questions.Name = "dgv_Questions";
            this.dgv_Questions.ReadOnly = true;
            this.dgv_Questions.Size = new System.Drawing.Size(312, 103);
            this.dgv_Questions.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select a Question for Update";
            // 
            // btn_Quest_Create
            // 
            this.btn_Quest_Create.Location = new System.Drawing.Point(18, 148);
            this.btn_Quest_Create.Name = "btn_Quest_Create";
            this.btn_Quest_Create.Size = new System.Drawing.Size(312, 23);
            this.btn_Quest_Create.TabIndex = 6;
            this.btn_Quest_Create.Text = "Create a New Question";
            this.btn_Quest_Create.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Question Type";
            // 
            // cbo_Quest_Type
            // 
            this.cbo_Quest_Type.FormattingEnabled = true;
            this.cbo_Quest_Type.Location = new System.Drawing.Point(117, 459);
            this.cbo_Quest_Type.Name = "cbo_Quest_Type";
            this.cbo_Quest_Type.Size = new System.Drawing.Size(213, 24);
            this.cbo_Quest_Type.TabIndex = 8;
            // 
            // rbtn_Quest_Diff_1
            // 
            this.rbtn_Quest_Diff_1.AutoSize = true;
            this.rbtn_Quest_Diff_1.Location = new System.Drawing.Point(141, 501);
            this.rbtn_Quest_Diff_1.Name = "rbtn_Quest_Diff_1";
            this.rbtn_Quest_Diff_1.Size = new System.Drawing.Size(33, 20);
            this.rbtn_Quest_Diff_1.TabIndex = 9;
            this.rbtn_Quest_Diff_1.TabStop = true;
            this.rbtn_Quest_Diff_1.Text = "1";
            this.rbtn_Quest_Diff_1.UseVisualStyleBackColor = true;
            // 
            // rbtn_Quest_Diff_2
            // 
            this.rbtn_Quest_Diff_2.AutoSize = true;
            this.rbtn_Quest_Diff_2.Location = new System.Drawing.Point(180, 501);
            this.rbtn_Quest_Diff_2.Name = "rbtn_Quest_Diff_2";
            this.rbtn_Quest_Diff_2.Size = new System.Drawing.Size(33, 20);
            this.rbtn_Quest_Diff_2.TabIndex = 10;
            this.rbtn_Quest_Diff_2.TabStop = true;
            this.rbtn_Quest_Diff_2.Text = "2";
            this.rbtn_Quest_Diff_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Quest_Diff_3
            // 
            this.rbtn_Quest_Diff_3.AutoSize = true;
            this.rbtn_Quest_Diff_3.Location = new System.Drawing.Point(219, 501);
            this.rbtn_Quest_Diff_3.Name = "rbtn_Quest_Diff_3";
            this.rbtn_Quest_Diff_3.Size = new System.Drawing.Size(33, 20);
            this.rbtn_Quest_Diff_3.TabIndex = 11;
            this.rbtn_Quest_Diff_3.TabStop = true;
            this.rbtn_Quest_Diff_3.Text = "3";
            this.rbtn_Quest_Diff_3.UseVisualStyleBackColor = true;
            // 
            // rbtn_Quest_Diff_4
            // 
            this.rbtn_Quest_Diff_4.AutoSize = true;
            this.rbtn_Quest_Diff_4.Location = new System.Drawing.Point(258, 501);
            this.rbtn_Quest_Diff_4.Name = "rbtn_Quest_Diff_4";
            this.rbtn_Quest_Diff_4.Size = new System.Drawing.Size(33, 20);
            this.rbtn_Quest_Diff_4.TabIndex = 12;
            this.rbtn_Quest_Diff_4.TabStop = true;
            this.rbtn_Quest_Diff_4.Text = "4";
            this.rbtn_Quest_Diff_4.UseVisualStyleBackColor = true;
            // 
            // rbtn_Quest_Diff_5
            // 
            this.rbtn_Quest_Diff_5.AutoSize = true;
            this.rbtn_Quest_Diff_5.Location = new System.Drawing.Point(297, 501);
            this.rbtn_Quest_Diff_5.Name = "rbtn_Quest_Diff_5";
            this.rbtn_Quest_Diff_5.Size = new System.Drawing.Size(33, 20);
            this.rbtn_Quest_Diff_5.TabIndex = 13;
            this.rbtn_Quest_Diff_5.TabStop = true;
            this.rbtn_Quest_Diff_5.Text = "5";
            this.rbtn_Quest_Diff_5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Question Difficulty";
            // 
            // txt_Quest_Stem
            // 
            this.txt_Quest_Stem.Location = new System.Drawing.Point(365, 39);
            this.txt_Quest_Stem.Multiline = true;
            this.txt_Quest_Stem.Name = "txt_Quest_Stem";
            this.txt_Quest_Stem.Size = new System.Drawing.Size(452, 80);
            this.txt_Quest_Stem.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Question Stem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Distractor 1";
            // 
            // txt_Quest_Distractor_1
            // 
            this.txt_Quest_Distractor_1.Location = new System.Drawing.Point(365, 145);
            this.txt_Quest_Distractor_1.Multiline = true;
            this.txt_Quest_Distractor_1.Name = "txt_Quest_Distractor_1";
            this.txt_Quest_Distractor_1.Size = new System.Drawing.Size(452, 50);
            this.txt_Quest_Distractor_1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(362, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Distractor 2";
            // 
            // txt_Quest_Distractor_2
            // 
            this.txt_Quest_Distractor_2.Location = new System.Drawing.Point(365, 221);
            this.txt_Quest_Distractor_2.Multiline = true;
            this.txt_Quest_Distractor_2.Name = "txt_Quest_Distractor_2";
            this.txt_Quest_Distractor_2.Size = new System.Drawing.Size(452, 50);
            this.txt_Quest_Distractor_2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Distractor 3";
            // 
            // txt_Quest_Distractor_3
            // 
            this.txt_Quest_Distractor_3.Location = new System.Drawing.Point(365, 295);
            this.txt_Quest_Distractor_3.Multiline = true;
            this.txt_Quest_Distractor_3.Name = "txt_Quest_Distractor_3";
            this.txt_Quest_Distractor_3.Size = new System.Drawing.Size(452, 50);
            this.txt_Quest_Distractor_3.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Distractor 4";
            // 
            // txt_Quest_Distractor_4
            // 
            this.txt_Quest_Distractor_4.Location = new System.Drawing.Point(365, 370);
            this.txt_Quest_Distractor_4.Multiline = true;
            this.txt_Quest_Distractor_4.Name = "txt_Quest_Distractor_4";
            this.txt_Quest_Distractor_4.Size = new System.Drawing.Size(452, 50);
            this.txt_Quest_Distractor_4.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(362, 425);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Distractor 5";
            // 
            // txt_Quest_Distractor_5
            // 
            this.txt_Quest_Distractor_5.Location = new System.Drawing.Point(365, 444);
            this.txt_Quest_Distractor_5.Multiline = true;
            this.txt_Quest_Distractor_5.Name = "txt_Quest_Distractor_5";
            this.txt_Quest_Distractor_5.Size = new System.Drawing.Size(452, 50);
            this.txt_Quest_Distractor_5.TabIndex = 25;
            // 
            // btn_Quest_AddUpdate
            // 
            this.btn_Quest_AddUpdate.Location = new System.Drawing.Point(847, 514);
            this.btn_Quest_AddUpdate.Name = "btn_Quest_AddUpdate";
            this.btn_Quest_AddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_Quest_AddUpdate.TabIndex = 27;
            this.btn_Quest_AddUpdate.Text = "Add";
            this.btn_Quest_AddUpdate.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Select a Topic for the Question";
            // 
            // dgv_Quest_Topics
            // 
            this.dgv_Quest_Topics.AllowUserToAddRows = false;
            this.dgv_Quest_Topics.AllowUserToDeleteRows = false;
            this.dgv_Quest_Topics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quest_Topics.Location = new System.Drawing.Point(18, 202);
            this.dgv_Quest_Topics.Name = "dgv_Quest_Topics";
            this.dgv_Quest_Topics.ReadOnly = true;
            this.dgv_Quest_Topics.Size = new System.Drawing.Size(312, 103);
            this.dgv_Quest_Topics.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Select a a SubTopic for the Question";
            // 
            // dgv_Quest_SubTopics
            // 
            this.dgv_Quest_SubTopics.AllowUserToAddRows = false;
            this.dgv_Quest_SubTopics.AllowUserToDeleteRows = false;
            this.dgv_Quest_SubTopics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quest_SubTopics.Location = new System.Drawing.Point(18, 338);
            this.dgv_Quest_SubTopics.Name = "dgv_Quest_SubTopics";
            this.dgv_Quest_SubTopics.ReadOnly = true;
            this.dgv_Quest_SubTopics.Size = new System.Drawing.Size(312, 103);
            this.dgv_Quest_SubTopics.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(841, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 368);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answer";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 117);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(28, 193);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 36;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(28, 263);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 37;
            this.radioButton5.TabStop = true;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(28, 338);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(14, 13);
            this.radioButton6.TabIndex = 38;
            this.radioButton6.TabStop = true;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabTest);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabTest.ResumeLayout(false);
            this.tabPageTopics.ResumeLayout(false);
            this.tabPageTopics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).EndInit();
            this.tabPageQuestions.ResumeLayout(false);
            this.tabPageQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quest_Topics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quest_SubTopics)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabTest;
        private System.Windows.Forms.TabPage tabPageTopics;
        private System.Windows.Forms.TextBox txtSubTopics;
        private System.Windows.Forms.Button btnAddUpdateSubTopics;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Button btnAddUpdateTopic;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.TabPage tabPageQuestions;
        private System.Windows.Forms.TabPage tabPageTests;
        private System.Windows.Forms.Button btnTopicTextClear;
        private System.Windows.Forms.Button btnSubTopicTextClear;
        private System.Windows.Forms.DataGridView dgvTopics;
        private System.Windows.Forms.DataGridView dgvSubTopics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Quest_AddUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Quest_Distractor_5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Quest_Distractor_4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Quest_Distractor_3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Quest_Distractor_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Quest_Distractor_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Quest_Stem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtn_Quest_Diff_5;
        private System.Windows.Forms.RadioButton rbtn_Quest_Diff_4;
        private System.Windows.Forms.RadioButton rbtn_Quest_Diff_3;
        private System.Windows.Forms.RadioButton rbtn_Quest_Diff_2;
        private System.Windows.Forms.RadioButton rbtn_Quest_Diff_1;
        private System.Windows.Forms.ComboBox cbo_Quest_Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Quest_Create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Questions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Quest_SubTopics;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_Quest_Topics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

