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
            this.tabPageQuestions = new System.Windows.Forms.TabPage();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.lblTopics = new System.Windows.Forms.Label();
            this.btnAddUpdateTopic = new System.Windows.Forms.Button();
            this.lstbxTopics = new System.Windows.Forms.ListBox();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtSubTopics = new System.Windows.Forms.TextBox();
            this.lstbxSubTopics = new System.Windows.Forms.ListBox();
            this.btnAddUpdateSubTopics = new System.Windows.Forms.Button();
            this.lblSubTopics = new System.Windows.Forms.Label();
            this.tabTest.SuspendLayout();
            this.tabPageTopics.SuspendLayout();
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
            this.tabTest.Location = new System.Drawing.Point(31, 115);
            this.tabTest.Name = "tabTest";
            this.tabTest.SelectedIndex = 0;
            this.tabTest.Size = new System.Drawing.Size(947, 563);
            this.tabTest.TabIndex = 1;
            // 
            // tabPageTopics
            // 
            this.tabPageTopics.Controls.Add(this.txtSubTopics);
            this.tabPageTopics.Controls.Add(this.lstbxSubTopics);
            this.tabPageTopics.Controls.Add(this.btnAddUpdateSubTopics);
            this.tabPageTopics.Controls.Add(this.lblSubTopics);
            this.tabPageTopics.Controls.Add(this.txtTopic);
            this.tabPageTopics.Controls.Add(this.lstbxTopics);
            this.tabPageTopics.Controls.Add(this.btnAddUpdateTopic);
            this.tabPageTopics.Controls.Add(this.lblTopics);
            this.tabPageTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTopics.Location = new System.Drawing.Point(4, 22);
            this.tabPageTopics.Name = "tabPageTopics";
            this.tabPageTopics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTopics.Size = new System.Drawing.Size(939, 537);
            this.tabPageTopics.TabIndex = 0;
            this.tabPageTopics.Text = "Topics / SubTopics";
            this.tabPageTopics.UseVisualStyleBackColor = true;
            // 
            // tabPageQuestions
            // 
            this.tabPageQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQuestions.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuestions.Name = "tabPageQuestions";
            this.tabPageQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuestions.Size = new System.Drawing.Size(939, 516);
            this.tabPageQuestions.TabIndex = 1;
            this.tabPageQuestions.Text = "Questions";
            this.tabPageQuestions.UseVisualStyleBackColor = true;
            // 
            // tabPageTests
            // 
            this.tabPageTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTests.Location = new System.Drawing.Point(4, 22);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Size = new System.Drawing.Size(939, 537);
            this.tabPageTests.TabIndex = 2;
            this.tabPageTests.Text = "Tests / Quizes";
            this.tabPageTests.UseVisualStyleBackColor = true;
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
            // btnAddUpdateTopic
            // 
            this.btnAddUpdateTopic.Location = new System.Drawing.Point(802, 35);
            this.btnAddUpdateTopic.Name = "btnAddUpdateTopic";
            this.btnAddUpdateTopic.Size = new System.Drawing.Size(113, 23);
            this.btnAddUpdateTopic.TabIndex = 2;
            this.btnAddUpdateTopic.Text = "Add";
            this.btnAddUpdateTopic.UseVisualStyleBackColor = true;
            // 
            // lstbxTopics
            // 
            this.lstbxTopics.FormattingEnabled = true;
            this.lstbxTopics.ItemHeight = 16;
            this.lstbxTopics.Location = new System.Drawing.Point(26, 35);
            this.lstbxTopics.Name = "lstbxTopics";
            this.lstbxTopics.Size = new System.Drawing.Size(373, 212);
            this.lstbxTopics.TabIndex = 3;
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(414, 35);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(373, 22);
            this.txtTopic.TabIndex = 4;
            // 
            // txtSubTopics
            // 
            this.txtSubTopics.Location = new System.Drawing.Point(414, 287);
            this.txtSubTopics.Name = "txtSubTopics";
            this.txtSubTopics.Size = new System.Drawing.Size(373, 22);
            this.txtSubTopics.TabIndex = 8;
            // 
            // lstbxSubTopics
            // 
            this.lstbxSubTopics.FormattingEnabled = true;
            this.lstbxSubTopics.ItemHeight = 16;
            this.lstbxSubTopics.Location = new System.Drawing.Point(26, 287);
            this.lstbxSubTopics.Name = "lstbxSubTopics";
            this.lstbxSubTopics.Size = new System.Drawing.Size(373, 212);
            this.lstbxSubTopics.TabIndex = 7;
            // 
            // btnAddUpdateSubTopics
            // 
            this.btnAddUpdateSubTopics.Location = new System.Drawing.Point(802, 287);
            this.btnAddUpdateSubTopics.Name = "btnAddUpdateSubTopics";
            this.btnAddUpdateSubTopics.Size = new System.Drawing.Size(113, 23);
            this.btnAddUpdateSubTopics.TabIndex = 6;
            this.btnAddUpdateSubTopics.Text = "Add";
            this.btnAddUpdateSubTopics.UseVisualStyleBackColor = true;
            // 
            // lblSubTopics
            // 
            this.lblSubTopics.AutoSize = true;
            this.lblSubTopics.Location = new System.Drawing.Point(23, 268);
            this.lblSubTopics.Name = "lblSubTopics";
            this.lblSubTopics.Size = new System.Drawing.Size(74, 16);
            this.lblSubTopics.TabIndex = 5;
            this.lblSubTopics.Text = "SubTopics";
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
            this.tabTest.ResumeLayout(false);
            this.tabPageTopics.ResumeLayout(false);
            this.tabPageTopics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabTest;
        private System.Windows.Forms.TabPage tabPageTopics;
        private System.Windows.Forms.TextBox txtSubTopics;
        private System.Windows.Forms.ListBox lstbxSubTopics;
        private System.Windows.Forms.Button btnAddUpdateSubTopics;
        private System.Windows.Forms.Label lblSubTopics;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.ListBox lstbxTopics;
        private System.Windows.Forms.Button btnAddUpdateTopic;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.TabPage tabPageQuestions;
        private System.Windows.Forms.TabPage tabPageTests;
    }
}

