using öğrenci_not;
using öğrenci_not.Service;
using System.Text;

public class Program
{
    public static List<Student> students;
    public static Random _random = new Random();

    static Program()
    {
        students = new List<Student>()
        {
        new Student(_random.Next(1000),"Mehmet", "Demir", 85, 92),
        new Student(_random.Next(1000),"Ayşe", "Kaya", 78, 88),
        new Student(_random.Next(1000),"Fatma", "Yıldız", 95, 90),
        new Student(_random.Next(1000),"Mustafa", "Çelik", 60, 75),
        new Student(_random.Next(1000),"Ali", "Şahin", 100, 95),
        new Student(_random.Next(1000),"Zeynep", "Öztürk", 45, 65),
        new Student(_random.Next(1000),"Emre", "Aydın", 88, 84),
        new Student(_random.Next(1000),"Elif", "Özdemir", 92, 96),
        new Student(_random.Next(1000),"Hasan", "Arslan", 70, 68),
        new Student(_random.Next(1000),"Hatice", "Doğan", 82, 79),
        new Student(_random.Next(1000),"Merve", "Kılıç", 55, 60),
        new Student(_random.Next(1000),"Burak", "Aslan", 90, 85),
        new Student(_random.Next(1000),"Gizem", "Çetinkaya", 76, 80),
        new Student(_random.Next(1000),"Can", "Kara", 65, 70),
        new Student(_random.Next(1000),"Berk", "Koç", 80, 82),
        new Student(_random.Next(1000),"Selin", "Kurt", 98, 95),
        new Student(_random.Next(1000),"Eda", "Özkan", 72, 75),
        new Student(_random.Next(1000),"Volkan", "Şimşek", 62, 58),
        new Student(_random.Next(1000),"Cem", "Erdoğan", 84, 88),
        new Student(_random.Next(1000),"Derya", "Çetin", 91, 94)
    };



    }

    public static void Main(String[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Menu.MainMenu();

            Console.Write("\n👉 Lütfen yapmak istediğiniz işlemi seçiniz: ");
            if (!byte.TryParse(Console.ReadLine(), out byte inputVal))
            {
                Console.WriteLine("\n❓ Geçersiz");
                return;
            }

            Console.Clear();
            switch (inputVal)
            {
                case 1: ListStudent.ListStudents(students); break;
                case 2: students = AddStudent.AddNewStudent(students); break;
                case 3: students = DeleteStudent.DeleteStudentById(students); break;
                case 4: students = UpdateStudent.UpdateStudentById(students); break;
                case 5: Environment.Exit(0); break;
                default: Console.WriteLine("\n❓ Yapmak istediğiniz işlem geçersizdir."); break;
            }
            ConsoleHelper.WaitingScreen();
        }
    }
}