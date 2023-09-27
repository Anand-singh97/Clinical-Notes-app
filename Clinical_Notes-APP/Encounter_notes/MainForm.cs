//Programmer - AnandPravesh Singh.
//Team Lead - Miles McDonald.
//Description - An app to create, edit, read, delete and store clinical encounter notes.
//Date - 2023-08-06
//Time - 6:29 pm
using System.IO;
using Patient_Notes;

namespace Encounter_notes
{
    public partial class MainForm : Form
    {
        // A list to store all notes.
        public static List<ClinicalNote> patients = new List<ClinicalNote>();

        public MainForm()
        {
            InitializeComponent();

            AwaitingMode();

            SampleDataForFormStart();

            DisplayNewNoteId();
        }

        // Display unique number inside 'note id' text box.
        public void DisplayNewNoteId()
        {
            txtNoteId.Text = (ClinicalNote.idList.Max() + 1).ToString();
        }

        //Method to initialize sample data objects to display patient info at the start of the form. 
        public void SampleDataForFormStart()
        {
            // Data for sample forms.
            string[] problem1 = new string[]
            {
                "Dabetes","Hypertension"
            };
            string notes1 = "Well developed, well nourished, no accute distress\nBP: 140/90, HR: 44";

            string[] problem2 = new string[]
            {
                "Overweight","Hypertension"
            };
            string notes2 = "Skin: clear, good turgor, no rashes\nBP: 80/20, HR: 101";

            //objects to display at start of the main form.
            ClinicalNote sampleNote1 = new ClinicalNote("Homer Simpson", DateTime.Now, problem1, notes1);
            ClinicalNote.idList.Add(sampleNote1.Id);

            ClinicalNote sampleNote2 = new ClinicalNote("Bart Simpson", DateTime.Now, problem2, notes2);
            ClinicalNote.idList.Add(sampleNote2.Id);

            patients.Add(sampleNote1);
            patients.Add(sampleNote2);

            //Write note data in 'Notes.txt'
            sampleNote1.myNotes.WriteAllAgain(patients);

            //Show not id and name in listbox.
            DisplayStoredNotes();
        }

        public void AwaitingMode()
        {
            foreach (Control k in gbxData.Controls)
            {
                if (k is TextBox || k is Button || k is RichTextBox)
                {
                    k.Enabled = false;
                }
            }
            txtDateOfBirth.Enabled = false;
            btnRemoveProblem.Enabled = false;
        }

        public void AddMode()
        {
            foreach (Control k in gbxData.Controls)
            {
                if (k is TextBox || k is Button || k is RichTextBox)
                {
                    k.Enabled = true;
                }
            }

            txtDateOfBirth.Enabled = true;
            btnUpdateNote.Enabled = false;
            btnDeleteNote.Enabled = false;
            txtNoteId.Enabled = false;
        }

        public void EditMode()
        {
            foreach (Control k in gbxData.Controls)
            {
                if (k is TextBox || k is Button || k is RichTextBox)
                {
                    k.Enabled = true;
                }
            }
            btnAddNote.Enabled = false;
            txtDateOfBirth.Enabled = true;
            btnUpdateNote.Enabled = true;
            btnDeleteNote.Enabled = true;
            txtNoteId.Enabled = false;
        }

        //Removes item from problems listBox.
        private void btnRemoveProblem_Click(object sender, EventArgs e)
        {
            lblInfo.Text = string.Empty;

            if (lbxProblems.SelectedItems.Count > 0)
            {
                lbxProblems.Items.RemoveAt(lbxProblems.SelectedIndex);
            }
            else
            {
                lblInfo.Text = "Error, no item is selected";
            }
        }

        //Method to display notes 'ID' and 'Patient Name' inside the listbox.
        public void DisplayStoredNotes()
        {
            lbxNotes.Items.Clear();
            foreach (ClinicalNote note in patients)
            {
                lbxNotes.Items.Add($"{note.PatientName} (Note: {note.Id})");
            }
        }

        // Clear all the textBoxes and listBoxes.
        public void ClearFields(string command)
        {
            txtPatientName.Text = string.Empty;
            rbxNotes.Text = string.Empty;
            txtNewProblem.Text = string.Empty;
            lbxProblems.Items.Clear();
            if (command == "all")
            {
                lbxVitals.Items.Clear();
            }
        }

        private void btnStartNewNote_Click(object sender, EventArgs e)
        {
            ClearFields("all");
            DisplayNewNoteId();
            AddMode();
        }

        //An event handler to display problems inside the 'Problems listbox'.
        private void btnAddProblem_Click(object sender, EventArgs e)
        {
            //Display problems inside the 'Problems listbox'.
            if (!string.IsNullOrEmpty(txtNewProblem.Text))
            {
                lbxProblems.Items.Add(txtNewProblem.Text);
            }
            else
            {
                lblInfo.Text = "Error, 'New Problem' text box is empty.";
            }

            txtNewProblem.Text = string.Empty;
        }

        //Display modified notes info inside vitalsListBox.
        public void DisplayVitalsInfo(List<string> vitals)
        {
            foreach (string k in vitals)
            {
                lbxVitals.Items.Add(k);
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {

            string patientName = txtPatientName.Text;
            DateTime dateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            string notes = rbxNotes.Text;

            //An array to store problems added by the user.
            string[] problem = new string[lbxProblems.Items.Count];

            for (int i = 0; i < problem.Length; i++)
            {
                problem[i] = lbxProblems.Items[i].ToString();
            }

            //New notes Object created.
            ClinicalNote newNote = new ClinicalNote(patientName, dateOfBirth, problem, notes);

            if (string.IsNullOrEmpty(newNote.errors))
            {
                lbxVitals.Items.Clear();

                ClinicalNote.idList.Add(newNote.Id);

                //Object added to patients List.
                patients.Add(newNote);

                DisplayVitalsInfo(newNote._vitalsList);

                //Append new note info in 'Notes.txt'.
                newNote.myNotes.Write();

                //Display ID and name in listBox.
                DisplayStoredNotes();

                ClearFields("some");

                //Display next unique ID.
                DisplayNewNoteId();

                lblInfo.Text = "New record added successfully.";

            }
            else
            {
                lblInfo.Text = newNote.errors;
            }
        }

        private void lbxNotes_MouseClick(object sender, MouseEventArgs e)
        {
            ClearFields("all");
            EditMode();

            // Extract index of selected note from patients list. (Using parallel arrays).
            int selectedObjectIndex = lbxNotes.SelectedIndex;
            ClinicalNote selectedNote = patients[selectedObjectIndex];

            //Show recorded data inside listBoxes and textBoxes.
            txtNoteId.Text = selectedNote.Id.ToString();
            txtPatientName.Text = selectedNote.PatientName.ToString();
            txtDateOfBirth.Text = selectedNote.DateOfBirth.ToString();

            for (int i = 0; i < selectedNote._problem.Count; i++)
            {
                lbxProblems.Items.Add(selectedNote._problem[i]);
            }

            lbxVitals.Items.Clear();

            for (int i = 0; i < selectedNote._vitalsList.Count; i++)
            {
                lbxVitals.Items.Add(selectedNote._vitalsList[i]);
            }

            rbxNotes.Text = selectedNote.Notes;
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            int selectedObjectIndex = lbxNotes.SelectedIndex;

            string patientName = txtPatientName.Text;
            DateTime dateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            string notes = rbxNotes.Text;

            //An array to store problems added by the user.
            string[] problem = new string[lbxProblems.Items.Count];
            for (int i = 0; i < problem.Length; i++)
            {
                problem[i] = lbxProblems.Items[i].ToString();
            }

            patients[selectedObjectIndex] = new ClinicalNote(patientName, dateOfBirth, problem, notes);
            patients[selectedObjectIndex].Id = (selectedObjectIndex + 1);

            if (string.IsNullOrEmpty(patients[selectedObjectIndex].errors))
            {
                patients[selectedObjectIndex].myNotes.WriteAllAgain(patients);
                DisplayStoredNotes();
                DisplayNewNoteId();

                ClearFields("all");
                lblInfo.Text = "Record updated Successfully.";
                AwaitingMode();
            }
            else
            {
                lblInfo.Text = patients[selectedObjectIndex].errors;
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            int selectedObjectIndex = lbxNotes.SelectedIndex;

            patients.RemoveAt(selectedObjectIndex);

            ClearFields("all");

            DisplayStoredNotes();

            if (patients.Count != 0)
            {
                patients[0].myNotes.WriteAllAgain(patients);
            }
            else
            {
                File.WriteAllText(@"..\..\..\Notes.txt", string.Empty);            
            }

            AwaitingMode();
            DisplayNewNoteId();

            lblInfo.Text = "Record deleted Successfully";
        }
    }
}