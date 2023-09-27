namespace Encounter_notes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbxNotes = new ListBox();
            btnStartNewNote = new Button();
            gbxData = new GroupBox();
            lbxVitals = new ListBox();
            lbxProblems = new ListBox();
            rbxNotes = new RichTextBox();
            btnRemoveProblem = new Button();
            btnDeleteNote = new Button();
            btnUpdateNote = new Button();
            btnAddNote = new Button();
            btnAddProblem = new Button();
            txtDateOfBirth = new DateTimePicker();
            txtNewProblem = new TextBox();
            txtPatientName = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNoteId = new TextBox();
            label1 = new Label();
            lblInfo = new Label();
            gbxData.SuspendLayout();
            SuspendLayout();
            // 
            // lbxNotes
            // 
            lbxNotes.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbxNotes.FormattingEnabled = true;
            lbxNotes.ItemHeight = 31;
            lbxNotes.Location = new Point(25, 61);
            lbxNotes.Name = "lbxNotes";
            lbxNotes.Size = new Size(332, 748);
            lbxNotes.TabIndex = 0;
            lbxNotes.MouseClick += lbxNotes_MouseClick;
            // 
            // btnStartNewNote
            // 
            btnStartNewNote.BackColor = Color.RosyBrown;
            btnStartNewNote.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnStartNewNote.Location = new Point(107, 2);
            btnStartNewNote.Name = "btnStartNewNote";
            btnStartNewNote.Size = new Size(169, 55);
            btnStartNewNote.TabIndex = 1;
            btnStartNewNote.Text = "Start new note";
            btnStartNewNote.UseVisualStyleBackColor = false;
            btnStartNewNote.Click += btnStartNewNote_Click;
            // 
            // gbxData
            // 
            gbxData.BackColor = Color.MistyRose;
            gbxData.Controls.Add(lbxVitals);
            gbxData.Controls.Add(lbxProblems);
            gbxData.Controls.Add(rbxNotes);
            gbxData.Controls.Add(btnRemoveProblem);
            gbxData.Controls.Add(btnDeleteNote);
            gbxData.Controls.Add(btnUpdateNote);
            gbxData.Controls.Add(btnAddNote);
            gbxData.Controls.Add(btnAddProblem);
            gbxData.Controls.Add(txtDateOfBirth);
            gbxData.Controls.Add(txtNewProblem);
            gbxData.Controls.Add(txtPatientName);
            gbxData.Controls.Add(label5);
            gbxData.Controls.Add(label7);
            gbxData.Controls.Add(label6);
            gbxData.Controls.Add(label4);
            gbxData.Controls.Add(label3);
            gbxData.Controls.Add(label2);
            gbxData.Controls.Add(txtNoteId);
            gbxData.Controls.Add(label1);
            gbxData.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbxData.Location = new Point(402, 13);
            gbxData.Name = "gbxData";
            gbxData.Size = new Size(1162, 796);
            gbxData.TabIndex = 2;
            gbxData.TabStop = false;
            gbxData.Text = "Add/Edit/Delete Encounter Note:";
            // 
            // lbxVitals
            // 
            lbxVitals.FormattingEnabled = true;
            lbxVitals.ItemHeight = 31;
            lbxVitals.Location = new Point(803, 72);
            lbxVitals.Name = "lbxVitals";
            lbxVitals.Size = new Size(346, 252);
            lbxVitals.TabIndex = 5;
            // 
            // lbxProblems
            // 
            lbxProblems.FormattingEnabled = true;
            lbxProblems.ItemHeight = 31;
            lbxProblems.Location = new Point(565, 72);
            lbxProblems.Name = "lbxProblems";
            lbxProblems.Size = new Size(222, 252);
            lbxProblems.TabIndex = 5;
            // 
            // rbxNotes
            // 
            rbxNotes.Location = new Point(21, 440);
            rbxNotes.Name = "rbxNotes";
            rbxNotes.Size = new Size(1027, 282);
            rbxNotes.TabIndex = 4;
            rbxNotes.Text = "";
            // 
            // btnRemoveProblem
            // 
            btnRemoveProblem.BackColor = Color.RosyBrown;
            btnRemoveProblem.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRemoveProblem.Location = new Point(592, 337);
            btnRemoveProblem.Name = "btnRemoveProblem";
            btnRemoveProblem.Size = new Size(169, 48);
            btnRemoveProblem.TabIndex = 3;
            btnRemoveProblem.Text = "Remove Problem";
            btnRemoveProblem.UseVisualStyleBackColor = false;
            btnRemoveProblem.Click += btnRemoveProblem_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.BackColor = Color.RosyBrown;
            btnDeleteNote.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDeleteNote.Location = new Point(413, 732);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(169, 55);
            btnDeleteNote.TabIndex = 3;
            btnDeleteNote.Text = "Delete Note";
            btnDeleteNote.UseVisualStyleBackColor = false;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // btnUpdateNote
            // 
            btnUpdateNote.BackColor = Color.RosyBrown;
            btnUpdateNote.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdateNote.Location = new Point(217, 732);
            btnUpdateNote.Name = "btnUpdateNote";
            btnUpdateNote.Size = new Size(169, 55);
            btnUpdateNote.TabIndex = 3;
            btnUpdateNote.Text = "Update Note";
            btnUpdateNote.UseVisualStyleBackColor = false;
            btnUpdateNote.Click += btnUpdateNote_Click;
            // 
            // btnAddNote
            // 
            btnAddNote.BackColor = Color.RosyBrown;
            btnAddNote.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddNote.Location = new Point(21, 732);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(169, 55);
            btnAddNote.TabIndex = 3;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = false;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // btnAddProblem
            // 
            btnAddProblem.BackColor = Color.RosyBrown;
            btnAddProblem.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddProblem.Location = new Point(461, 286);
            btnAddProblem.Name = "btnAddProblem";
            btnAddProblem.Size = new Size(94, 50);
            btnAddProblem.TabIndex = 3;
            btnAddProblem.Text = "Add";
            btnAddProblem.UseVisualStyleBackColor = false;
            btnAddProblem.Click += btnAddProblem_Click;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(185, 222);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(250, 38);
            txtDateOfBirth.TabIndex = 2;
            // 
            // txtNewProblem
            // 
            txtNewProblem.Location = new Point(185, 292);
            txtNewProblem.Name = "txtNewProblem";
            txtNewProblem.Size = new Size(262, 38);
            txtNewProblem.TabIndex = 1;
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(185, 145);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(262, 38);
            txtPatientName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 400);
            label5.Name = "label5";
            label5.Size = new Size(82, 31);
            label5.TabIndex = 0;
            label5.Text = "Notes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(803, 34);
            label7.Name = "label7";
            label7.Size = new Size(77, 31);
            label7.TabIndex = 0;
            label7.Text = "Vitals:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 34);
            label6.Name = "label6";
            label6.Size = new Size(118, 31);
            label6.TabIndex = 0;
            label6.Text = "Problems:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 296);
            label4.Name = "label4";
            label4.Size = new Size(161, 31);
            label4.TabIndex = 0;
            label4.Text = "New Problem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 226);
            label3.Name = "label3";
            label3.Size = new Size(157, 31);
            label3.TabIndex = 0;
            label3.Text = "Date Of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 149);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 0;
            label2.Text = "Patient Name:";
            // 
            // txtNoteId
            // 
            txtNoteId.Enabled = false;
            txtNoteId.Location = new Point(185, 72);
            txtNoteId.Name = "txtNoteId";
            txtNoteId.Size = new Size(125, 38);
            txtNoteId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 76);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "Note ID:";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.DarkRed;
            lblInfo.Location = new Point(25, 815);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(29, 31);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1594, 908);
            Controls.Add(lblInfo);
            Controls.Add(gbxData);
            Controls.Add(btnStartNewNote);
            Controls.Add(lbxNotes);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Encounter Notes";
            gbxData.ResumeLayout(false);
            gbxData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxNotes;
        private Button btnStartNewNote;
        private GroupBox gbxData;
        private TextBox txtNoteId;
        private Label label1;
        private TextBox txtPatientName;
        private Label label2;
        private Label label3;
        private DateTimePicker txtDateOfBirth;
        private TextBox txtNewProblem;
        private Label label4;
        private Button btnAddProblem;
        private RichTextBox rbxNotes;
        private Label label5;
        private ListBox lbxProblems;
        private ListBox lbxVitals;
        private Label label6;
        private Label label7;
        private Button btnRemoveProblem;
        private Button btnDeleteNote;
        private Button btnUpdateNote;
        private Button btnAddNote;
        private Label lblInfo;
    }
}