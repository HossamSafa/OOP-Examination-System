using Final_OOP_Exam.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP_Exam.Exams
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            Questions = new Question[NumberOfQuestions];

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int questionType;
                do
                {
                    Console.WriteLine($"Please Enter Question Type For Question {i + 1} (1 for MCQ | 2 for True / False): ");
                } while (!(int.TryParse(Console.ReadLine(), out questionType) && (questionType is 1 or 2)));

                if (questionType == 1)
                {
                    Questions[i] = new McqQuestion();
                    Questions[i].AddQuestion();
                }
                else
                {
                    Questions[i] = new TrueFalseQuestion();
                    Questions[i].AddQuestion();
                }
            }
        }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question.Body);
                for (int i = 0; i < question.Answers.Length; i++)
                    Console.WriteLine(question.Answers[i].text);

                int userAnswerId;
                if (question.GetType() == typeof(McqQuestion))
                {
                    do
                    {
                        Console.WriteLine("Please Enter Your Answer (1 or 2 or 3): ");
                    } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2 or 3)));
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please Enter Your Answer (1 for True | 2 for False): ");
                    } while (!(int.TryParse(Console.ReadLine(), out userAnswerId) && (userAnswerId is 1 or 2)));
                }

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
                Console.WriteLine($"your Answer => : {Questions[i].UserAnswer.text}");
                Console.WriteLine($"Right Answer =>  : {Questions[i].RightAnswer.text}");

            }
            Console.WriteLine($"Your Grade is {grade} from {totalGrade}");
        }
    }
}
