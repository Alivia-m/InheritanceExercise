using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }
        public string Type{ get; set; }
        public string Name{ get; set; }
        public bool IsVenomous{ get; set; }
        public string Look{ get; set; }
    }
}
