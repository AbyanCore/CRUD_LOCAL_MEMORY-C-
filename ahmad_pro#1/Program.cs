using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLogin
{
    class program
    {
        static void Main(string[] Args)
        {
            string username,password;
            Console.WriteLine("Masukkan Username : ");
            username= Console.ReadLine();
            Console.WriteLine("Masukkan Password : ");
            password = Console.ReadLine();
            Console.WriteLine("============");
            if(username=="Ahmad" && password=="123")
            {
                Console.WriteLine("Login Berhasil");

            }
            else 
            {
            Console.WriteLine("Login Gagal!!!");    
            }
            Console.ReadKey();
        }
    }
}
            

