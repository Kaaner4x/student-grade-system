namespace öğrenci_not
{
    public class ConsoleHelper
    {
        public static void WaitingScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;
            Console.WriteLine("\n⌛ Devam etmek için herhangi bir tuşa basınız...");
            Console.ReadKey(intercept: true);
            Console.ResetColor();
            Console.CursorVisible = true;
        }
    }
}
