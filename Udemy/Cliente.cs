using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy {
    internal class Cliente {
        public string? Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString() { 
            return Room.ToString() + ": " + Name + ", " + Email;
        }
    }
}
