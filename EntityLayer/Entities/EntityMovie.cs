using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class EntityMovie
    {
        private int movieid;
        private string moviename;
        private string moviedirector;
        private string moviecountry;
        private string movieimdb;
        private int categoryid;

        public int Movieid { get => movieid; set => movieid = value; }
        public string Moviename { get => moviename; set => moviename = value; }
        public string Moviedirector { get => moviedirector; set => moviedirector = value; }
       
        public string Moviecountry { get => moviecountry; set => moviecountry = value; }
        public string Movieimdb { get => movieimdb; set => movieimdb = value; }
        public int Categoryid { get => categoryid; set => categoryid = value; }

    }
}
