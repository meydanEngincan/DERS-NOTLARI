using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User();
            usr.setAdSoyad("Engin Can Meydan");
            Console.WriteLine(usr.getAdSoyad());
            usr.setAdSoyad("        ");
            Console.WriteLine(usr.getAdSoyad());
        }
    }
}
