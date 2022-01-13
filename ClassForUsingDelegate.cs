using System;
namespace Delegates_and_Events
{

    public delegate void AccountHandler(string message);
   
    
    public class ClassForUsingDelegate
    {
        int subs { get; set; }
        string SubscriberName { get; set; }
        AccountHandler? Handler;
        public ClassForUsingDelegate(string SubscriberName, int subs)
        { this.SubscriberName = SubscriberName;
            this.subs = subs;
        }
        
           
        public void HandlerRegister(AccountHandler handler)
        {
            Handler = handler;
        }
        public void NumSubs ()
        {
            if (subs > 0)
            {
                Handler?.Invoke($"Количество подписок {SubscriberName} = {subs}");
            }
            else
            {
                Handler?.Invoke("У пользователя нет подписок");
            }
        }
        public void Subscribe()
        {
            Handler?.Invoke("Пользователь подписался на обновления");
        }
        public void Unsubscribe()
        {

            Handler?.Invoke($"{SubscriberName} отписался от обновлений ");
        }
        
        
    }
}
