using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
        public string Type{ get; set; }
        public bool CanFly{ get; set; }
        public string Sound{ get; set; }
        public bool IsAnnoying{ get; set; }

    }
}
