using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Notes
{
    public class Read_WriteNotes : ClinicalNote
    {
        public Read_WriteNotes()
        {
            
        }

        //Method to append info inside 'Notes.txt'.
        public void Write() 
        {
            string problem = string.Join(";", _problem);
            string vitalsList = string.Join(";", _vitalsList);
            string[] lines = File.ReadAllLines(@".\Notes.txt");
            using (StreamWriter file = new StreamWriter(@"..\..\..\Notes.txt", true))
            {
                file.WriteLine($"{_patientName} | (Note: {_id}) | {DateOfBirth.ToString("d")} | {problem} | {vitalsList}");
            }
        }

        //Method to write info inside 'Notes.txt' from very start.
        public void WriteAllAgain(List<ClinicalNote> listPatients)
        {
            File.WriteAllText(@"..\..\..\Notes.txt", string.Empty);

            foreach (ClinicalNote patient in listPatients)
            {
                patient.myNotes.Write();
            }
        }

    }
}
