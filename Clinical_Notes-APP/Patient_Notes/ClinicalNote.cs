namespace Patient_Notes
{
    public class ClinicalNote
    {
        //Stores all Unique ID's.
        public static List<int> idList = new List<int>();

        protected int _id;
        protected string _patientName;
        protected DateTime _dateOfBirth;
        protected string _notes;

        public List<string> _problem = new List<string>();
        public List<string> _vitalsList = new List<string>();
        public string errors = "";

        //Object to work with BP, HR, T and RR.
        public List<Vitals> newVitals;

        //Object to work with Reading and writing of info in 'Notes.txt'.
        public Read_WriteNotes myNotes;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string PatientName
        {
            get
            {
                return _patientName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    errors += "Patient name can't be empty.\n";
                }
                else
                {
                    _patientName = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    errors += "'Date of birth' can't be in the future.\n";
                }
                else
                {
                    _dateOfBirth = value;
                }
            }
        }

        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    errors += "'Notes' Text box can't be empty.\n";
                }
                else
                {
                    _notes = value;
                }
            }
        }

        //Default constructor.
        public ClinicalNote()
        {

        }


        //Non Default Constructor.
        public ClinicalNote(string patientName, DateTime dateOfBirth, string[] problems, string notes)
        {
            _id = GetId();
            PatientName = patientName;
            DateOfBirth = dateOfBirth;
            Notes = notes;

            foreach (string k in problems)
            {
                _problem.Add(k);
            }

            //Polymorphism used to work with variety classes.
            newVitals = new List<Vitals>()
            {
                new BP(notes),
                new HR(notes),
                new RR(notes),
                new T(notes)
            };

            //Method call to store modified data in '_vitalslist'.
            GetModifiedVitalsData();

            // Transfer data using inheritance.
            myNotes = new Read_WriteNotes()
            {   
                _id = _id,
                _patientName = patientName,
                _dateOfBirth = dateOfBirth,
                _problem = new List<string>(problems),
                _vitalsList = _vitalsList
            };
        }

        public int GetId()
        {
            if (idList.Count == 0)
            {
                return 1;
            }
            return (idList.Count + 1);
        }

        public void GetModifiedVitalsData()
        {
            foreach (Vitals obj in newVitals)
            {
                foreach (string s in obj.ShowDetails())
                {
                    _vitalsList.Add(s);
                }
            }
        }

    }
}