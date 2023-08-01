using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Championat_Spain_Entity_Migrations_31._07.Model
{
      class Country
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; } 

        public Country()
        {
        Players = new List<Player>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
