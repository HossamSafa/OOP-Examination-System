using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP_Exam.Questions
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer { text = "True" };
            Answers[1] = new Answer { text = "False" };
        }

        public override string Header => "True / False Question";

        public override void AddQuestion()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("Please Enter Question Body: ");
                Body = Console.ReadLine();

            }
            while (string.IsNullOrWhiteSpace(Body));

            int mark;
            do
            {
                Console.WriteLine("Please Enter Question Mark: ");
            }
            while (!(int.TryParse(Console.ReadLine(), out mark) && (mark > 0)));

            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Enter Right Answer (1 for True | 2 for False): ");
            }
            while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId is 1 or 2)));

            Mark = mark;
            RightAnswer.Id = rightAnswerId;
            RightAnswer.text = Answers[rightAnswerId - 1].text;
            Console.Clear();
        }
    }
}
