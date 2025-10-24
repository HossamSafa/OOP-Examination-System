using Final_OOP_Exam.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP_Exam
{
    internal class Subject
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Exam SubjectExam { get; set; }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam()
        {
            int examtype, examTime, numberOfQuestions;

            do
            {
                Console.WriteLine("Select Exam Type: (1 for practical | 2 for Final)");
            } while (!(int.TryParse(Console.ReadLine(), out examtype) && (examtype is 1 or 2)));

            do
            {
                Console.WriteLine("Enter Exam Time (in minutes): ");
            } while (!(int.TryParse(Console.ReadLine(), out examTime) && (examTime >= 30 && examTime <= 180)));

            do
            {
                Console.WriteLine("Enter Number of Questions: ");
            } while (!(int.TryParse(Console.ReadLine(), out numberOfQuestions)));

            if (examtype == 1)
                SubjectExam = new PracticalExam(examTime, numberOfQuestions);
            else
                SubjectExam = new FinalExam(examTime, numberOfQuestions);

            SubjectExam.CreateListOfQuestions();
        }



    }
}
