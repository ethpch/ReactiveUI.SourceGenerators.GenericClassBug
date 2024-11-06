using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestClass<int> test = new();
            test.TestFunction1();
        }
    }
    internal partial class TestClass<T> : ReactiveObject
    {
        [Reactive] T? _value;
        [ReactiveCommand]
        void TestFunction()
        {
            
        }
        public void TestFunction1()
        {
            Console.WriteLine("Call TestFunction1");
        }
    }
}
