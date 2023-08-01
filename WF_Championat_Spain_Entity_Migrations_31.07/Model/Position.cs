using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Championat_Spain_Entity_Migrations_31._07.Model
{
     class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; } 

        public Position() 
        {
        Players = new List<Player>();
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
