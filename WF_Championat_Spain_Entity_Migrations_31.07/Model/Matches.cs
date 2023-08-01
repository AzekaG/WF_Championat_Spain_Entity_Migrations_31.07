using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Championat_Spain_Entity_Migrations_31._07.Model
{
     class Matches
    {

        public int Id { get; set; } 

        public virtual Team FirstTeam { get; set; }

        public virtual Team SecondTeam { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Goal> Goals { get; set; } = new List<Goal>();


        int goalFT = 0 ;        //голы , которая забила первая команда
        int goalST = 0 ;         //голы , которая забила вторая команда

        public Matches() 
        {
           
         
        }

        

        public void goalIni()
        {


            foreach (var goal in Goals) 
            {
                if (goal.Player.Team.Name == FirstTeam.Name) { goalFT++; }
                if (goal.Player.Team.Name == SecondTeam.Name) { goalST++; }

            }
          
            
        }


        public override string ToString()
        {

           
            return $"{FirstTeam.Name}   {SecondTeam.Name}    {goalFT} : {goalST} ";
        }


    }
}
