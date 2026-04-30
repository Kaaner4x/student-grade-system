namespace öğrenci_not.Service
{
    public class DeleteStudent
    {
        public static List<Student> DeleteStudentById(List<Student> students)
        {
            ListStudent.ListStudents(students);
            Console.Write("\nSilmek istediğiniz öğrencinin ID'sini giriniz: ");
            if (!int.TryParse(Console.ReadLine(), out int studentId))
            {
                Console.WriteLine("Geçersiz bir ID girdiniz!");
                return students;
            }

            var student = students.FirstOrDefault(s => s.StudentID == studentId);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine($"{student.StudentFirstName} {student.StudentLastName} isimli öğrenci başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Bu ID'ye sahip bir öğrenci bulunamadı.");
            }

            return students;
        }
    }
}
