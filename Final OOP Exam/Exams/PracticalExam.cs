using Final_OOP_Exam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP_Exam.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            Questions = new McqQuestion[NumberOfQuestions];

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions[i] = new McqQuestion();
                Questions[i].AddQuestion();
            }
        }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Body);
                for (int i = 0; i < question.Answers.Length; i++)
                    Console.WriteLine($"{i + 1}.{question.Answers[i].text}");

                Console.WriteLine("==================================================");

                int userAnswerId;
                do
                {
                    Console.WriteLine("Please Enter Your Answer (1 or 2 or 3): ");

                }
                while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));

                question.UserAnswer.Id = userAnswerId;
                question.UserAnswer.text = question.Answers[userAnswerId - 1].text;

                Console.Clear();
            }

            int grade = 0, totalGrade = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                totalGrade += Questions[i].Mark;
                if (Questions[i].UserAnswer.Id == Questions[i].RightAnswer.Id)
                    grade += Questions[i].Mark;

                Console.WriteLine($"Question {i + 1} : {Questions[i].Body}");
                Console.WriteLine($"Right Answer : {Questions[i].RightAnswer.text}");

                Console.WriteLine($"Your Grade is {grade} from {totalGrade}");
            }
        }
    }
}
