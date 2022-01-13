using System;
namespace Delegates_and_Events
{
     public class ClassForEvent
    {
        public delegate void NotificationHandler(string message);
        public event NotificationHandler? Notification;

        
        
        public int Apples { get; private set; }
        public ClassForEvent(int Apples) => this.Apples = Apples;

        public void PutApplesInBasket(int Apples)
        {
            this.Apples +=Apples;
            if (Notification !=null)
            {
                Notification.Invoke($"В корзину положили {Apples} яблок");
            }
           
        }
        public void TakeApplesFromBasket(int Apples)
        {
            if (this.Apples>Apples)
            {
                this.Apples -= Apples;
                
            }
            else if(this.Apples<Apples)
            {
                Notification("В корзине нет достаточного количества яблок");
            }

            else if (Apples >= 2)
            {
                Notification($"Из корзины взяли {Apples} яблок");
            }
            else if (Apples == 1)
            {
                Notification($"Из корзины взяли {Apples} яблокo");
            }
            else if(Apples ==0)
            {
                Notification($"В корзине нет яблок");

            };
            
        }

        public void DisplayApples() => Console.WriteLine(Apples);
    }
}
