using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Championat_Spain_Entity_Migrations_31._07.Model
{
     class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }


        public virtual Team Team { get; set; }
        public virtual Position Position { get; set; }
        public virtual Country Country { get; set; }
        

        public Player() { }

        public override string ToString()
        {
            return $"{Name}  {Surname}  {Number}  {Country}   {Position}";
        }

    }
}
