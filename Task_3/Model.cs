using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{


    internal class Model
    {
        public int Sek { get; set; }  = 0;
        public int Min { get; set; }  = 0;

        public void ResetTime()
        {
            Sek = 0; 
            Min = 0;
        }


        public string CurrentTime()
        {
            return $"{Min} : {Sek}";
        }

    }
}
