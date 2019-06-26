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
            this.btnSubTopicTextClear = new System.Windows.Forms.Button();
            this.btnTopicTextClear = new System.Windows.Forms.Button();
            this.txtSubTopics = new System.Windows.Forms.TextBox();
            this.btnAddUpdateSubTopics = new System.Windows.Forms.Button();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.btnAddUpdateTopic = new System.Windows.Forms.Button();
            this.lblTopics = new System.Windows.Forms.Label();
            this.tabPageQuestions = new System.Windows.Forms.TabPage();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.dgvTopics = new System.Windows.Forms.DataGridView();
            this.dgvSubTopics = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTest.SuspendLayout();
            this.tabPageTopics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubTopics)).BeginInit();
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
            this.tabTest.Size = new System.Drawing.Size(947, 563);
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
            this.tabPageTopics.Size = new System.Drawing.Size(939, 530);
            this.tabPageTopics.TabIndex = 0;
            this.tabPageTopics.Text = "Topics / SubTopics";
            this.tabPageTopics.UseVisualStyleBackColor = true;
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
            this.tabPageQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQuestions.Location = new System.Drawing.Point(4, 29);
            this.tabPageQuestions.Name = "tabPageQuestions";
            this.tabPageQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuestions.Size = new System.Drawing.Size(939, 530);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "SubTopics";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubTopics)).EndInit();
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
    }
}

