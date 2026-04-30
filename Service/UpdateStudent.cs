namespace öğrenci_not.Service
{
    public class UpdateStudent
    {
        public static List<Student> UpdateStudentById(List<Student> students)
        {
            ListStudent.ListStudents(students);
            Console.Write("Güncellemek istediğiniz öğrencinin ID'sini giriniz: ");
            if (!int.TryParse(Console.ReadLine(), out int studentId))
            {
                Console.WriteLine("Geçersiz bir ID girdiniz!");
                return students;
            }

            var student = students.FirstOrDefault(s => s.StudentID == studentId);
            if (student == null)
            {
                Console.WriteLine("Bu ID'ye sahip bir öğrenci bulunamadı.");
                return students;
            }

            Console.WriteLine($"Bulunan Öğrenci: {student.StudentFirstName} {student.StudentLastName}");

            Console.Write("Yeni adını giriniz (değiştirmek istemiyorsanız boş bırakın): ");
            string? firstName = Console.ReadLine();
            if (!string.IsNullOrEmpty(firstName))
            {
                student.StudentFirstName = firstName;
            }

            Console.Write("Yeni soyadını giriniz (değiştirmek istemiyorsanız boş bırakın): ");
            string? lastName = Console.ReadLine();
            if (!string.IsNullOrEmpty(lastName))
            {
                student.StudentLastName = lastName;
            }

            Console.Write("Yeni vize notunu giriniz (değiştirmek istemiyorsanız boş bırakın): ");
            string? midTermInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(midTermInput) && int.TryParse(midTermInput, out int midTerm))
            {
                student.MidTermScore = midTerm;
            }

            Console.Write("Yeni final notunu giriniz (değiştirmek istemiyorsanız boş bırakın): ");
            string? finalInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(finalInput) && int.TryParse(finalInput, out int final))
            {
                student.FinalScore = final;
            }

            Console.WriteLine("Öğrenci bilgileri başarıyla güncellendi.");
            return students;
        }
    }
}
