using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Championat_Spain_Entity_Migrations_31._07.Model;

namespace WF_Championat_Spain_Entity_Migrations_31._07
{
     class Controller
    {
        public MatchDbContext DB; 

        public  Controller()
        {
           
        }

        public void IniDataBase()
        {
            using(DB = new MatchDbContext())
            {
                Team Girona = new Team { Name = "Girona" };
                Team RealMadrid = new Team { Name = "Real Madrid" };
                Team Atletik = new Team { Name = "Atletik" };
                

                Position GoalKipper = new Position { Name = "Goalkipper" };
                Position Defender = new Position { Name = "Defender" };
                Position Midfielder = new Position { Name = "Midfielder" };
                Position Striker = new Position { Name = "Striker" };
               

                Country German = new Country { Name = "German" };
                Country Spain = new Country { Name = "Spain" };
                Country Uruguay = new Country { Name = "Uruguay" };
                Country Denmark = new Country { Name = "Denmark" };
                Country France = new Country { Name = "France" };
                Country USA = new Country { Name = "USA" };
                Country Netherlands = new Country { Name = "Netherlands" };
                Country Ivory_Coast = new Country { Name = "Ivory Coast" };
                Country Brasil = new Country { Name = "Brasil" };
                Country Poland = new Country { Name = "Poland" };
                Country Marocco = new Country { Name = "Marocco" };
                Country Belgium = new Country { Name = "Belgium" };
                Country Ukraine = new Country { Name = "Ukraine" };
                Country Austria = new Country { Name = "Austria" };
                Country Croatia = new Country { Name = "Croatia" };
                Country Argentina = new Country { Name = "Argentina" };
                Country Columbia = new Country { Name = "Columbia" };
                Country Venezuela = new Country { Name = "Venezuela" };


                

                Player TiboCurtua = new Player { Name = "Tibo", Surname = "Curtua", Position = GoalKipper, Number = 1, Team = RealMadrid, Country = Belgium };
                Player AndriyLunin = new Player { Name = "Andriy", Surname = "Lunin", Position = GoalKipper, Number = 13, Team = RealMadrid, Country = Ukraine };

                Player FerlandMendy = new Player { Name = "Ferland", Surname = "Mendy", Position = Defender, Number = 23, Team = RealMadrid, Country = France };
                Player IgnacioFernandez = new Player { Name = "Ignacio", Surname = "Fernandez", Position = Defender, Number = 6, Team = RealMadrid, Country = Spain };
                Player DanielCarvajal = new Player { Name = "Daniel", Surname = "Carvajal", Position = Defender, Number = 2, Team = RealMadrid, Country = Spain };
                Player EderMilitao = new Player { Name = "Eder", Surname = "Militao", Position = Defender, Number = 3, Team = RealMadrid, Country = Brasil };
                Player DavidAlaba = new Player { Name = "David", Surname = "Alaba", Position = Defender, Number = 4, Team = RealMadrid, Country = Austria };
                Player AlvaroOdriozola = new Player { Name = "Alvaro", Surname = "Odriozola", Position = Defender, Number = 16, Team = RealMadrid, Country = Spain };
                Player AntonioRudiger = new Player { Name = "Antonio", Surname = "Rudiger", Position = Defender, Number = 22, Team = RealMadrid, Country = German };

                Player FedericoValverde = new Player { Name = "Federico", Surname = "Valverde", Position = Midfielder, Number = 15, Team = RealMadrid, Country = Uruguay };
                Player LucasVazquez = new Player { Name = "Lucas", Surname = "Vazquez", Position = Midfielder, Number = 17, Team = RealMadrid, Country = Spain };
                Player ToniKroos = new Player { Name = "Toni", Surname = "Kroos", Position = Midfielder, Number = 8, Team = RealMadrid, Country = German };
                Player LukaModric = new Player { Name = "Luka", Surname = "Modric", Position = Midfielder, Number = 10, Team = RealMadrid, Country = Croatia };
                Player DanielCeballos = new Player { Name = "Daniel", Surname = "Ceballos", Position = Midfielder, Number = 19, Team = RealMadrid, Country = Spain };
                Player AurelienTchouameni = new Player { Name = "Aurelien", Surname = "Tchouameni", Position = Midfielder, Number = 18, Team = RealMadrid, Country = France };

                Player ViniciusJunior = new Player { Name = "Vinicius", Surname = "Junior", Position = Striker, Number = 7, Team = RealMadrid, Country = Brasil };
                Player RodrygoGoes = new Player { Name = "Rodrygo", Surname = "Goes", Position = Striker, Number = 11, Team = RealMadrid, Country = Brasil };

              

                Player PauloGazzaniga = new Player { Name = "Paulo", Surname = "Gazzaniga", Position = GoalKipper, Number = 13, Team = Girona, Country = Argentina };
                Player JuanMartin = new Player { Name = "Juan Carlos", Surname = "Martin ", Position = GoalKipper, Number = 1, Team = Girona, Country = Spain };

                Player ValeriFernandez = new Player { Name = "Valeri", Surname = "Fernandez", Position = Midfielder, Number = 11, Team = Girona, Country = Spain };
                Player JuanRamirez = new Player { Name = "Juan", Surname = "Ramirez", Position = Midfielder, Number = 15, Team = Girona, Country = Spain };
                Player AlexSerrano = new Player { Name = "Alex", Surname = "Serrano", Position = Midfielder, Number = 14, Team = Girona, Country = Spain };
                Player BorjaGarcia = new Player { Name = "Borja", Surname = "Garcia", Position = Midfielder, Number = 24, Team = Girona, Country = Spain };
                Player AntonioVilla = new Player { Name = "Antonio", Surname = "Villa", Position = Midfielder, Number = 12, Team = Girona, Country = Spain };
                Player YangelHerrera = new Player { Name = "Yangel", Surname = "Herrera", Position = Midfielder, Number = 21, Team = Girona, Country = Venezuela };
                Player IvanMartin = new Player { Name = "Ivan", Surname = "Martin", Position = Midfielder, Number = 23, Team = Girona, Country = Spain };


                Player SantiagoBueno = new Player { Name = "Santiago", Surname = "Bueno", Position = Defender, Number = 22, Team = Girona, Country = Uruguay };
                Player BernardoEspinosa = new Player { Name = "Bernardo", Surname = "Espinosa", Position = Defender, Number = 2, Team = Girona, Country = Columbia };
                Player ArnauMartines = new Player { Name = "Arnau", Surname = "Martines", Position = Defender, Number = 4, Team = Girona, Country = Spain };
                Player MiguelGutierez = new Player { Name = "Miguel", Surname = "Gutierez", Position = Defender, Number = 3, Team = Girona, Country = Spain };
                Player DavidLopez = new Player { Name = "David", Surname = "Lopez", Position = Defender, Number = 5, Team = Girona, Country = Spain };

                Player ViktorTsygankov = new Player { Name = "Viktor", Surname = "Tsygankov", Position = Striker, Number = 8, Team = Girona, Country = Ukraine };
                Player ChristianStuani = new Player { Name = "Christian", Surname = "Stuani", Position = Striker, Number = 7, Team = Girona, Country = Uruguay };
                Player ManuelVallejo = new Player { Name = "Manuel", Surname = "Vallejo", Position = Striker, Number = 25, Team = Girona, Country = Spain };

               

                Player UnaiSimon = new Player { Name = "Unai", Surname = "Simon", Position = GoalKipper, Number = 1, Team = Atletik, Country = Spain };
                Player HulienAggirecebalia = new Player { Name = "Hulien", Surname = "Aggirecebalia", Position = GoalKipper, Number = 13, Team = Atletik, Country = Spain };

                Player YuriBeriche = new Player { Name = "Yuri", Surname = "Beriche", Position = Defender, Number = 17, Team = Atletik, Country = Spain };
                Player OscarDeMarcos = new Player { Name = "Oscar", Surname = "Marcos", Position = Defender, Number = 18, Team = Atletik, Country = Spain };
                Player YerayAlvarez = new Player { Name = "Yeray", Surname = "Alvarez", Position = Defender, Number = 5, Team = Atletik, Country = Spain };
                Player Inigomartinez = new Player { Name = "Inigo", Surname = "Martines", Position = Defender, Number = 15, Team = Atletik, Country = Spain };
                Player DanielVivian = new Player { Name = "Daniel", Surname = "Vivian", Position = Defender, Number = 3, Team = Atletik, Country = Spain };

                Player DanielGarcia = new Player { Name = "Daniel", Surname = "Garcia", Position = Midfielder, Number = 14, Team = Atletik, Country = Spain };
                Player RaulGarcia = new Player { Name = "Daniel", Surname = "Vivian", Position = Midfielder, Number = 22, Team = Atletik, Country = Spain };
                Player MikelVesga = new Player { Name = "Mikel", Surname = "Vesga", Position = Midfielder, Number = 6, Team = Atletik, Country = Spain };
                Player AnderAguera = new Player { Name = "Ander", Surname = "Augera", Position = Midfielder, Number = 23, Team = Atletik, Country = Spain };

                Player IkerMunian = new Player { Name = "Iker", Surname = "Munian", Position = Striker, Number = 10, Team = Atletik, Country = Spain };
                Player IniakiWilliams = new Player { Name = "Iniaki", Surname = "Williams", Position = Striker, Number = 9, Team = Atletik, Country = Spain };
                Player AlejandroBerenger = new Player { Name = "Alejandro", Surname = "Berenger", Position = Striker, Number = 7, Team = Atletik, Country = Spain };
                Player NikoWiliams = new Player { Name = "Niko", Surname = "Williams", Position = Striker, Number = 11, Team = Atletik, Country = Spain };
                Player GorkaGuruzeta = new Player { Name = "Gorka", Surname = "Guruzeta", Position = Striker, Number = 12, Team = Atletik, Country = Spain };

               
                DB.Countries.AddRange(new List<Country> {Austria,Ukraine, Belgium , German, Spain, Uruguay, Denmark, France, USA, Netherlands
                ,Ivory_Coast, Brasil, Poland, Marocco, Croatia,Argentina , Columbia , Venezuela});
                DB.Positions.AddRange(new List<Position> { GoalKipper, Defender, Midfielder, Striker });
                DB.Teams.AddRange(new List<Team> { Girona, RealMadrid, Atletik });
                DB.Players.AddRange(new List<Player> {UnaiSimon, HulienAggirecebalia, YuriBeriche, OscarDeMarcos, YerayAlvarez, IniakiWilliams, Inigomartinez, DanielVivian,
                DanielGarcia, RaulGarcia, MikelVesga, AnderAguera, IkerMunian, AlejandroBerenger, NikoWiliams, GorkaGuruzeta ,  TiboCurtua, AndriyLunin, FerlandMendy, IgnacioFernandez, DanielCarvajal, EderMilitao, DavidAlaba,
                AlvaroOdriozola, AntonioRudiger, FedericoValverde, LucasVazquez, ToniKroos, LukaModric, DanielCeballos, AurelienTchouameni, ViniciusJunior, RodrygoGoes,PauloGazzaniga, JuanMartin, ValeriFernandez, JuanRamirez, AlexSerrano , BorjaGarcia, AntonioVilla, YangelHerrera, IvanMartin, SantiagoBueno, BernardoEspinosa,
                ArnauMartines, MiguelGutierez, DavidLopez, ViktorTsygankov, ChristianStuani, ManuelVallejo});


                
                Matches Girona_Atletik = new Matches() { FirstTeam = Girona, SecondTeam = Atletik, Date = new DateTime(2023, 4, 23)};
                Matches Girona_Real = new Matches() { FirstTeam = Girona, SecondTeam = RealMadrid, Date = new DateTime(2023, 5, 10)};
                Matches Real_Atletik = new Matches() { FirstTeam = RealMadrid, SecondTeam = Atletik, Date = new DateTime(2023, 5, 15) };
                Matches Real_Girona = new Matches() { FirstTeam = RealMadrid, SecondTeam = Girona, Date = new DateTime(2023, 6, 20) };
               

                Goal goal1 = new Goal() { Player = SantiagoBueno , Match = Girona_Atletik};
                Goal goal2 = new Goal() { Player = ManuelVallejo, Match = Girona_Real };
                Goal goal3 = new Goal() { Player = RodrygoGoes, Match = Girona_Real };
                Goal goal4 = new Goal() { Player = ViniciusJunior, Match = Real_Girona };
                Goal goal5 = new Goal() { Player = ViniciusJunior, Match = Real_Girona };
                Goal goal6 = new Goal() { Player = RodrygoGoes, Match = Real_Girona };
                Goal goal7 = new Goal() { Player = ManuelVallejo, Match = Real_Girona };


                DB.Matches.AddRange(new List<Matches> { Girona_Atletik, Girona_Real, Real_Girona, Real_Atletik });
                DB.Goals.AddRange(new List<Goal> { goal1, goal2, goal3, goal4, goal5, goal6, goal7 });


                DB.SaveChanges();




            }
        }




        public List<Team> TeamsIni()
        {
            List<Team> res = new List<Team>();
            using (DB = new MatchDbContext())
            {
                res = DB.Teams.ToList();
            }
            return res;
        }


        public List<Player> PlayersIni(string TeamName) 
        {
             List<Player> res = new List<Player>();
            
            using(DB = new MatchDbContext()) 
            {
                Team team = DB.Teams.Where(t => t.Name == TeamName).FirstOrDefault();
               
                DB.Entry(team).Collection("Players").Load();
                DB.Positions.Load();
                DB.Countries.Load();

                foreach (var Players in team.Players)
                {
                    res.Add(Players);
                }
            
            }
            return res;
        }

        public List<Matches> MatchesIni(string TeamName)
        {
            List<Matches> res = new List<Matches>();
           
          
            using (DB = new MatchDbContext())
            {
                DB.Matches.Load();
                DB.Goals.Load();
                DB.Players.Load();
                DB.Teams.Load();


                foreach (var el in DB.Matches)
                {
                    el.goalIni();
                }

                foreach (var el in DB.Matches)
                {
                    if(el.FirstTeam.Name == TeamName || el.SecondTeam.Name == TeamName)
                        res.Add(el);
                }   

            }

                return res;
        }


        public List<Goal> GoalsIni(int id)
        {
            List<Goal> res = new List<Goal>();
            
            using (DB = new MatchDbContext())
            {
                DB.Goals.Load();
                DB.Matches.Load();
                DB.Players.Load();
                DB.Teams.Load();
               
                foreach(var el in DB.Matches) 
                {
                    if(el.Id == id)
                    foreach(var goal in el.Goals)
                    {
                        res.Add((Goal)goal);
                    }
                }

            }
                return res;

        }


    }
}
