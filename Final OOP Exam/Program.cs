using System.Diagnostics;

namespace Final_OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "C#");
            subject.CreateExam();

            char Char;
            do
            {
                Console.WriteLine("Do you want to start exam (Y | N)");

            }
            while (!(char.TryParse(Console.ReadLine(), out Char) && (Char.ToString().ToLower() == "y" || Char.ToString().ToLower() == "n")));

            if (Char == 'y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.SubjectExam.ShowExam();
                sw.Stop();
                Console.WriteLine($"Time = {sw.Elapsed}");
            }
        }
    }
}
