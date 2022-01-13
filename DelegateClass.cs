using System;
namespace Delegates_and_Events
{
    public class DelegateClass
    {
        public void Method()
        {
            int a = 17;
            int b = 22;
            Console.WriteLine($"Вызван Method из класса DelegateClass , сумма слогаемых Класса равна{a+b}");
        }
    }
    public class DelegateClass1
    {
        int a = 5;
        int b = 6;
        public void Method1()
        {
            Console.WriteLine($"Вызван Method1 из класса DelegateClass1, сумма слогаемых Класса равна{a+b}");
        }
    }

}
