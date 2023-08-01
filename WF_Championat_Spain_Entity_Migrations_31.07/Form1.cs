using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Championat_Spain_Entity_Migrations_31._07.Model;

namespace WF_Championat_Spain_Entity_Migrations_31._07
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
          //IniBase();              //инициализация БД , при первом запуске расскоментить
            IniTeam();
            
        }

      
        public void IniBase()
        {
            controller = new Controller();
            controller.IniDataBase();


        }
        public void IniTeam()
        {
            controller = new Controller();
            listBoxTeams.DataSource = null;
            listBoxTeams.DataSource = controller.TeamsIni();
           
        }

        public void IniMatches()
        {
            listBoxMatches.DataSource = null;
            
            listBoxMatches.DataSource = controller.MatchesIni(listBoxTeams.SelectedItem.ToString());
   }

        void iniGoals(int id)
        {

            controller = new Controller();

            listBoxGoals.DataSource = null;
           
            listBoxGoals.DataSource = controller.GoalsIni(id);
        }


        private void listBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPlayers.DataSource = null;
            controller = new Controller();
            listBoxPlayers.DataSource = controller.PlayersIni(listBoxTeams.SelectedItem.ToString());
            
            IniMatches();
        }



        void Mess()
        {
        
        
        }
        
        
        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {




            Matches obj = new Matches();
            obj = (Matches)listBoxMatches.SelectedItem;
            int index = obj.Id;
            iniGoals(index);
            

        }

        private void listBoxGoals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMatches_DoubleClick(object sender, EventArgs e)
        {


           

        }
    }
}
