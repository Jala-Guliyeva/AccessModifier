using System;

namespace ClassLibrary
{
    public class Notification
    {
       
         protected internal string Name { get; set; }

        public void Names()
        {
            Console.WriteLine("Name daxil edildi");
        }
    }
    class test:Notification
    {
       
        public void Words()
        {
            Name = "Jale";
            Notification notification = new Notification();
           

        }

    }
}
