namespace öğrenci_not.Service
{
    public class AddStudent
    {
        public static List<Student> AddNewStudent(List<Student> students)
        {
            Console.Write("Öğrencinin adını giriniz: ");
            string? firstName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("Boş olamaz");
                return students;
            }

            Console.Write("Öğrencinin soyadını giriniz: ");
            string? lastName = Console.ReadLine();

            if (string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Boş olamaz");
                return students;
            }

            Console.Write("Vize notunuz giriniz: ");
            if (!int.TryParse(Console.ReadLine(), out int midTerm))
            {
                Console.WriteLine("Geçersiz bir giriş yaptınız!");
                return students;
            }

            Console.Write("Final notunuz giriniz: ");
            if (!int.TryParse(Console.ReadLine(), out int final))
            {
                Console.WriteLine("Geçersiz bir giriş yaptınız!");
                return students;
            }

            students.Add(new Student(Program._random.Next(1000), firstName, lastName, midTerm, final));
            return students;
        }
    }
}
