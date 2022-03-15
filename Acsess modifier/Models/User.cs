using System;
using System.Collections.Generic;
using System.Text;

namespace Acsess_modifier.Models
{
    class User
    { 
        public string userName;
        public int age;
    //protected int Speed;
         private int password;
    
        public User()
        {
            
        }
        public User(string userName, int Age, int password):base(userName,password)

        {
            this.Age = age;
         

        }

        public string UserName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
        public int Age 
        {
            get
            {
                if (Age<0)
                {
                    Console.WriteLine("Age menfi ola bilmez");
                    return -1;
                }
                return Age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age 18den  kicik ola bilmez");
                    return;
                }
                Age = value;
                Console.WriteLine("Okay giris olundu");
                
            }
        }


        private int Password {
            
            get
            {
                if (password == 0 )
                {
                    Console.WriteLine("Bos ola bilmez");
                    return -1;

                }
                else
                {
                    
                }
               
                return password;
            }
            set
            {
                if (value >8)
                {
                    Console.WriteLine("OKAY giris olundu");
                    return ;
                }
                else
                {
                    Console.WriteLine("olmadi");
                   
                }return;

               

            }
        }
       
       

               
               
            
        

    }
    
    
}
