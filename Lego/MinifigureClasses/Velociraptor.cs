using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurassicWorldLego.Classes
{
    class Velociraptor
    {
        public Velociraptor(string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }
        public bool pounces { get; set; }
        public string color { get; set; }
        public string size { get; set; }
    }
}
