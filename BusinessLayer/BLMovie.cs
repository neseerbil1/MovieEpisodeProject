using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using FacadeLayer.DAL;

namespace BusinessLayer
{
    public class BLMovie
    {
        public static List<EntityMovie> BLMovieList()
        {
            return DALMovie.MovieList();
        }
        public void BLAddMovie(EntityMovie entityMovie)
        { 
            if(entityMovie.Moviecountry!="" && entityMovie.Moviename.Length>=5 )
            { 
                DALMovie.AddMovie(entityMovie); 
            }
        }
         
        public void BLDeleteMovie(int id)
        {
            if (id != 0)
            {
                DALMovie.DeleteMovie(id);
            }

        }
        
        public void BLUpdateMovie(EntityMovie entityMovie)
        {
            if (entityMovie.Moviecountry != "" && entityMovie.Moviename.Length >=5 && entityMovie.Moviecountry.Length>=3)
            {
                DALMovie.UpdateMovie(entityMovie);
            }

        }
    }
}
