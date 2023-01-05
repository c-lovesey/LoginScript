class Program
{
    private static void Main(string[] args)
    {
        bool login = false;
        while (login == false)
        {


            // Prompt the user for their username
            Console.WriteLine("Please enter your username:");
            string? username = Console.ReadLine();

            // Prompt the user for their password
            Console.WriteLine("Please enter your password:");
            string? password = Console.ReadLine();

            // Check if the entered credentials are valid
            if (username == "admin" && password == "password")
            {
                Console.WriteLine("Login successful!");
                login = true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }
    }
}