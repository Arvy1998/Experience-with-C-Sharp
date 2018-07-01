using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace PlayerDatabase {
    class Player {
        public int id;
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public int server_id;
        public int Server_id {
            get { return server_id; }
            set { server_id = value; }
        }

        public string username;
        public string Username {
            get { return username; }
            set { username = value; }
        }

        public int age;
        public int Age {
            get { return age; }
            set { age = value; }
        }

        public string team;
        public string Team {
            get { return team; }
            set { team = value; }
        }

        /*protected string password;
        protected string Password {
            get { return password; }
            set { password = value; }
        }

        protected static void PasswordDecryption(string password) { // naujo vartotojo slaptazodzio saugojimo budo ideja
            // sugalvotas matematinis pavidalas, padarantis ivesta zodi neatpazistama (nesugalvojau, bet turiu ideja sekanciai programai)
        }

        protected static void PasswordEncryption(string password) { // jau esamo vartotojo prisijungimo atveju vykdoma funkcija
            // sugalvotas matematinis pavidalas, padarantis neatpazistama zodi vel i slaptazodi ir tikrinantis, ar sutampa su ivestuoju zodziu
        }*/

        public Player(int id, int server_id, string username, int age, string team) { // constructor ~
            this.id = 0;
            this.server_id = 0;
            this.username = "No Username Choosen";
            this.age = 0;
            this.team = "No Team Choosen";
            NumOfPlayers++; // kiekviena kart, kai konstruktorius pakviestas, NumOfPlayers inkrementuojamas
        }

        static int NumOfPlayers = 0;

        public static int GetNumOfPlayers() {
            Console.WriteLine("Currently we have " + NumOfPlayers + " players.");
            var stopwatch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(2550);
            stopwatch.Stop();
            Console.Clear();
            return NumOfPlayers;
        }

        public string ReturnInformation(int id, int server_id, string username, int age, string team) {
            return String.Format("Id: {0};" +
                " Server Id: {1};" +
                " Choosen Username: {2};" +
                " Choosen Age: {3};" +
                " Choosen Team: {4}.", id, server_id, username, age, team);
        }

        static void Main(string[] args) {
            bool IsAccountCreated = false;
            Console.WriteLine("Welcome, please choose your Username!");
            string TempUsername = Console.ReadLine();
            Console.WriteLine("Glad to meet you, " + TempUsername + "! What's your age?");
            string TempAge = Console.ReadLine();
            Console.WriteLine("And final step! Please enter your team name!");
            string TempTeam = Console.ReadLine();
            Console.WriteLine("Almost done! Wait till your account will be succesfully created...");
            var stopwatch = Stopwatch.StartNew();
            System.Threading.Thread.Sleep(3000);
            stopwatch.Stop();
            Console.Clear();
            if (IsAccountCreated == true) {
                Console.WriteLine("Sorry, you already have an account..");
                for (int i = 0; i <= 1; i++) {
                    Console.Beep();
                }
            }
            else if (TempUsername == "" || int.Parse(TempAge) <= 12 || TempTeam == "") {
                Console.WriteLine("Sorry, we couldn't create account with given information...");
                for (int j = 0; j <= 1; j++) {
                    Console.Beep();
                }
            }
            else {
                Random random = new Random();
                int TempId = random.Next(1, 256);
                int TempServerId = random.Next(1001, 109991);
                Player TempPlayer = new Player(TempId, TempServerId, TempUsername, int.Parse(TempAge), TempTeam);
                IsAccountCreated = true;
                Console.WriteLine("Congratulations, you have succesfuly created a new account!");
                stopwatch = Stopwatch.StartNew();
                System.Threading.Thread.Sleep(3000);
                stopwatch.Stop();
                Console.Clear();
                Console.WriteLine("Your account information: ");
                Console.WriteLine(TempPlayer.ReturnInformation(TempId, TempServerId, TempUsername, int.Parse(TempAge), TempTeam));
                Console.WriteLine("Have a nice further game!");
            }
        }
    }
}
