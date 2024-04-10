namespace GitTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //es1
            Console.WriteLine("Hello, World!");
            Console.WriteLine("add a contact: ");
            string newContact = Console.ReadLine();
            string contact1 = "aaaaaaaaa";
            string contact2 = "bbbbbbbbb";

            //es2
            Console.WriteLine($"{contact1}, {contact2}, {newContact}");

        }
    }
}
