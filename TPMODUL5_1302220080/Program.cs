using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL5_1302220080
{
    
    class Program
    {

        public class HaloGeneric
        {
            public void SapaUser<T>(T userName)
            {
                Console.WriteLine($"Halo user {userName}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                HaloGeneric halo = new HaloGeneric();


                string namaPanggilan = "Ascar";
                halo.SapaUser(namaPanggilan);
                Console.Read();
            }
        }
    }
}