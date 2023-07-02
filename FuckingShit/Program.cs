using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FuckingShit
{
    internal class Pizzaz
    {
        public int Zippo;

        public void Bamboo(int eek)
        {
            Zippo += eek;
        }
    }

    class Abracadabra
    {
        public int Vavavoom;

        public bool Lala(int floq)
        {
            if (floq < Vavavoom)
            {
                Vavavoom += floq;
                return true;
            }
            return false;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
          Pizzaz foxtrot = new Pizzaz() { Zippo = 2 };
          foxtrot.Bamboo(foxtrot.Zippo);
          Pizzaz november = new Pizzaz() { Zippo = 3 };
          Abracadabra tango = new Abracadabra() { Vavavoom = 4 };
          while (tango.Lala(foxtrot.Zippo))
            {
                november.Zippo *= -1;
                november.Bamboo(tango.Vavavoom);
                foxtrot.Bamboo(november.Zippo);
                tango.Vavavoom -= foxtrot.Zippo;
            }
            Console.WriteLine("november.Zippo = " + november.Zippo);
            Console.WriteLine("foxtrot.Zippo = " + foxtrot.Zippo);
            Console.WriteLine("tango.Vavavoom = " + tango.Vavavoom);
        }
    }
}
