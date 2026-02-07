namespace _01._50._90_輸出
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入姓: ");
            string lastName = Console.ReadLine();
            Console.Write("請輸入名字: ");
            string firstName = Console.ReadLine();
            Console.Write("請輸入Email: ");
            string email = Console.ReadLine();

            string output = $@"您好， {lastName} {firstName}
您的電子信箱是: {email}";
            string output2 = "您好， " + lastName + " " + firstName + "\n" +
                             "您的電子信箱是: " + email;
            string output3 = $"您好， {lastName} {firstName}\n您的電子信箱是: {email}";
            Console.WriteLine(output);
            Console.WriteLine(output2);
            Console.WriteLine(output3);

            string a = string.Empty;

        }
    }
}
