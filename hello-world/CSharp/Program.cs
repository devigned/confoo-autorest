using HelloWorld;


namespace Confoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new HelloWorldClient();
            System.Console.WriteLine(client.Greeting.Get());
        }
    }
}