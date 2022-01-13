using System;

namespace Delegates_and_Events
{
    class Program
    {
        delegate int MTF(int x, int y);

        int Multiply(int x, int y) => x * y;
        int Devide(int x, int y) => x / y;
       
        /// /////////////////////////////////
        /////////////////////////////////////
        /////////////////////////////////////


        public delegate void MathDelegate();

        ///////////////////////////////
        /// ///////////////////////////
        ///////////////////////////////
        
        delegate void TakeMessage(string message);

        ///////////////////////////////
        /// ///////////////////////////
        ///////////////////////////////
        delegate void DelegateAdd(int a, int b);

        ///////////////////////////////
        /// ///////////////////////////
        ///////////////////////////////

        
        
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
           void Add()
            {

                Console.WriteLine($"Сумма слогаемых : {a + b}");
            }
            MathDelegate mathDelegate;
            mathDelegate = Add;
            mathDelegate();
            mathDelegate = new DelegateClass().Method;
            mathDelegate();
            mathDelegate = new DelegateClass1().Method1;
            mathDelegate();
            Console.WriteLine();
            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ////////////////////////////////////////////
            int Multiply(int x, int y) => x * y;
            int Devide(int x, int y) => x / y;
            MTF MyDelegateVariable;
            MTF MyDelegateVariable1;
            MyDelegateVariable1 = Multiply;
            int MultiplyResult = MyDelegateVariable1.Invoke(5, 4);
            Console.WriteLine(MultiplyResult);
            MyDelegateVariable = Devide;
            int DevideResult = MyDelegateVariable(12, 2);
            Console.WriteLine(DevideResult);
            Console.WriteLine();
            /////////////////////////////////////
            /////////////////////////////////////
            /////////////////////////////////////
            ClassForUsingDelegate CFUD = new ClassForUsingDelegate("Ilya", 12);
            CFUD.HandlerRegister(DisplaySubs);
            CFUD.NumSubs();
            CFUD.Subscribe();
            CFUD.Unsubscribe();
            void DisplaySubs(string message) => Console.WriteLine(message);
            Console.WriteLine();
            //////////////////////////////////////
            ///////anon methods///////////////////
            //////////////////////////////////////

            TakeMessage message = delegate (string message)
            {
                Console.WriteLine(message);
            };

            message.Invoke("ilya");
            Console.WriteLine();
            //////////////////////////////////////
            ///////lambda expression//////////////
            //////////////////////////////////////
            DelegateAdd deladd= (a,b) => Console.WriteLine(a+b);
            deladd(1, 3);
            deladd(100, 20);
            Console.WriteLine();
            //////////////////////////////////////
            ///////Event//////////////////////////
            //////////////////////////////////////

            ClassForEvent Basket = new ClassForEvent(0);
            Basket.Notification += new ClassForEvent.NotificationHandler(DisplayEvent);
            Basket.PutApplesInBasket(5);
            Basket.TakeApplesFromBasket(10);
            void DisplayEvent(string message) => Console.WriteLine(message);

        }
    }
    
}
