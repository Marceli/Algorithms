using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms4
{
    class Publisher
    {
        public event EventHandler<EventArgs> MyEvent;
        public void OnNotify()
        {
            if(MyEvent!=null)
                MyEvent(this,EventArgs.Empty);
        }

    }
    public class EventTester
	{
        static void notifier_Notify(object sender,EventArgs e)
        {
            Console.WriteLine("{0} raised event",sender.ToString());
        }
        public static void Main()
        {
            var notifier=new Publisher();
            notifier.MyEvent += notifier_Notify;
            notifier.OnNotify();
            Console.ReadKey();
        }
		
	}
}
