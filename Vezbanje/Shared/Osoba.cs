using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje.Shared
{
    public abstract class Osoba
    { 
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string LastName { get; set; } 
        public string Phone { get; set; } 
        public string Mail { get; set; }
    }
}
