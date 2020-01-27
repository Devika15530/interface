using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritH
{
    public abstract class Player
    {
        protected string name;
        protected string tname;
        protected int noOfMatches;
        public Player(string name, string tname, int noOfMatches)
        {
            this.name = name;
            this.tname = tname;
            this.noOfMatches = noOfMatches;
            Console.WriteLine("parametrsied parent constructor");
        }
        public abstract void Display();
    }

    public class CricketPlayer : Player
    {
        int totalruns;
        int noOfWickets;
        public CricketPlayer(string name, string tname, int noOfMatches,int totalruns, int noOfWickets) : base(name, tname, noOfMatches) {   
            this.totalruns = totalruns;
            this.noOfWickets = noOfWickets;
            Console.WriteLine("cricket parametrised constructor");
        }

        public override void Display()
        {
            Console.WriteLine("name of player:" + this.name + "team name is:" + this.tname + "total no of matches:" + this.noOfMatches + "total runs" + this.totalruns + "no of wickets:" + this.noOfWickets);
        }
    }
    public class HockeyPlayer : Player
    {
        int totalgoals;
        int position;
        public HockeyPlayer(string name, string tname, int noOfMatches, int totalgoals, int position) : base(name, tname, noOfMatches)
        {
            this.totalgoals = totalgoals;
            this.position = position;
            Console.WriteLine("hockey parametrised constructor");
        }


        public override void Display()
        {
            Console.WriteLine("name of player:" + this.name + "team name is:" + this.tname + "total no of matches:" + this.noOfMatches + "total runs" + this.totalgoals + "no of wickets:" + this.position);
        }
    }

}