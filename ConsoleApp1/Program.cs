using ReactiveUI;
using ReactiveUI.SourceGenerators;
using ReactiveUI.SourceGenerators.WinForms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestClass1<int> test = new();
            test.TestFunction2();
        }
    }
    internal partial class TestClass1<T> : ReactiveObject
    {
        [Reactive] string? _myProperty1;
        [ObservableAsProperty] string? _myProperty2;
        [ReactiveCommand]
        void TestFunction1()
        {
            
        }
        public void TestFunction2()
        {
            Console.WriteLine("Call TestFunction2");
        }
    }
    [IViewFor<string>]
    internal partial class TestClass2<T> : ReactiveObject
    {

    }
    [RoutedControlHost("")]
    internal partial class TestClass3<T> : ReactiveObject
    {

    }
    [ViewModelControlHost("")]
    internal partial class TestClass4<T> : ReactiveObject
    {

    }
}
