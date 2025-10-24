using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_OOP_Exam.Questions
{
    internal class McqQuestion : Question
    {
        public McqQuestion()
        {
            Answers = new Answer[3];
        }
        public override string Header => "MCQ Question";

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

            Console.WriteLine("Please Enter 3 Possible Answers: ");
            for (int i = 0; i < Answers.Length; i++)
            {
                Answers[i] = new Answer() { Id = i + 1 };
                do
                {
                    Console.WriteLine($"Enter a choice number {i + 1}");
                    Answers[i].text = Console.ReadLine();
                }
                while (string.IsNullOrWhiteSpace(Answers[i].text));
            }

            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Enter Right Answer Id: ");
            }
            while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId is 1 or 2 or 3)));

            Mark = mark;
            RightAnswer.Id = rightAnswerId;
            RightAnswer.text = Answers[rightAnswerId - 1].text;
            Console.Clear();
        }
    }
}
