using Hello.All;

namespace Hello
{
    public class Program
    {
        protected Program() {}

        private static void Main(string[] args)
        {
            var foo = new Foo();
            Console.WriteLine($"Hello, {foo?.Name?.Trim() ?? string.Empty}!");

            Console.WriteLine("Hello, World!");
            DoSomething();
        }

        private static void DoSomething(int index = 0)
        {
            index++;
            Console.WriteLine($"I do something time {index}");
        }
    }
}