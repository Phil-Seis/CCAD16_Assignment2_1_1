namespace CCAD16_Assignment2_1_1
{
    //Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char )
    //and public properties for each data member. Instantiate the class and assign data to properties. Display the data back on console.
    //Property needs a private backing field followed by creating the properties
    //Instantiate the class, assign to a variable, assign data to property with dot notation
    class Student
    {
        //create private backing fields
        private int _studentId;
        private string _studentFName;
        private string _studentLName;
        private char _studentGrade;

        //public properties to access info
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }
        }

        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }

        public char StudentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }
    }
    internal class Program
    {    
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 1;
            student.StudentFName = "Chris";
            student.StudentLName = "Collins";
            student.StudentGrade = 'A';

            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Student First Name: {student.StudentFName}");
            Console.WriteLine($"Student Last Name: {student.StudentLName}");
            Console.WriteLine($"Student Grade: {student.StudentGrade}");
        }
    }
}
