using EntityLayer.Entities;
using FacadeLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLActor
    {
        public static List<EntityActor> BLActorList()
        {
            return DALActor.ActorList();
        }
        public static void BLAddActor(EntityActor p)
        {
            if (p.ActorName != "" && p.ActorSurname != "" && p.ActorAge.Length == 2)
            {
                DALActor.AddActor(p);
            }
        }
        public static void BLDeleteActor(int id)
        {
            if (id != 0)
            {
                DALActor.DeleteActor(id);
            }
        }
        public static void BLUpdateActor(EntityActor p)
        {
            if (p.ActorName != "" && p.ActorSurname.Length >= 4)
            {
                DALActor.UpdateActor(p);
            }
        }
    }
}