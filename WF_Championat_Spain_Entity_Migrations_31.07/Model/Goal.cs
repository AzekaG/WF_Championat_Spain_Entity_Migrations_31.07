
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WF_Championat_Spain_Entity_Migrations_31._07.Model
{
     class Goal
    {
        public int Id { get; set; }

        public virtual Matches Match { set; get; }

        public virtual Player Player { set; get; }

        public Goal()
        {

           
        }

        public override string ToString()
        {
            return $"{Player.Name} {Player.Surname}  {Player.Number}  {Player.Team.Name}  -  1";
        }


    }
}
