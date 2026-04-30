using öğrenci_not.Model;

namespace öğrenci_not.Service
{
    public class ListStudent
    {
        public static void ListStudents(List<Student> students)
        {
            int n = 1;
            foreach (var student in students)
            {
                Console.WriteLine($"Sıra No      : {n}\n" +
                                  $"Öğrenci ID   : {student.StudentID}\n" +
                                  $"Ogrenci Ad   : {student.StudentFirstName}\n" +
                                  $"Ogrenci Soyad: {student.StudentLastName}\n" +
                                  $"Vize Notu    : {student.MidTermScore}\n" +
                                  $"Final Notu   : {student.FinalScore}\n" +
                                  $"Average      : {CalculateScore.Calculate(student.MidTermScore, student.FinalScore)}");
                Console.WriteLine($"{new string(' ', 40)}");
                n++;
            }
        }
    }
}
