using System;
using System.Linq.Expressions;

namespace Alexa
{
    class Alexa
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public Alexa()
        {
            GreetingMessage = "hello, i am Alexa";
        }

        public void Configure(Action<Alexa> action)
        {
            action.Invoke(this);
        }


        //public void Configure(Alexa alexa)
        //{

        //}

        public string Talk()
        {
            if (OwnerName == null)
            {
                return GreetingMessage;
            }

            return GreetingMessage.Replace("{OwnerName}", OwnerName);
        }
    }
}
