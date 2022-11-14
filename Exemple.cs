using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCLI
{
    public class Exemple
    {
        int Y;

        public void AfficheYLocal()
        {
            int Y = 5;
            Console.WriteLine(Y);
        }

        public void AfficheYMembre()
        {
            Console.WriteLine(Y);
        }
    }
}
