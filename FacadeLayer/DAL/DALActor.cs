using EntityLayer.Entities;
using FacadeLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer.DAL
{
    public class DALActor
    {
        public static List<EntityActor> ActorList()
        {
            DbConnection.sqlConnection.Open();  
            List<EntityActor> entityActors = new List<EntityActor>();
            SqlCommand command = new SqlCommand("Select * From TblActor", DbConnection.sqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                EntityActor ent = new EntityActor();
                ent.ActorID = int.Parse(dataReader["ActorID"].ToString());
                ent.ActorName = dataReader["ActorName"].ToString();
                ent.ActorSurname = dataReader["ActorSurname"].ToString();
                ent.ActorAge = dataReader["ActorAge"].ToString();
                entityActors.Add(ent);
            }
            
            DbConnection.sqlConnection.Close();
            return entityActors;
        }
        public static void AddActor(EntityActor p)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblActor (ActorName,ActorSurname,ActorAge) values (@p1,@p2,@p3)", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", p.ActorName);
            command.Parameters.AddWithValue("@p2", p.ActorSurname);
            command.Parameters.AddWithValue("@p3", p.ActorAge);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }
        public static void DeleteActor(int id)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From TblActor where ActorID=@p1", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", id);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }
        public static void UpdateActor(EntityActor p)
        {
            DbConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblActor Set ActorName=@p1,ActorSurname=@p2,ActorAge=@p3 where ActorID=@p4", DbConnection.sqlConnection);
            command.Parameters.AddWithValue("@p1", p.ActorName);
            command.Parameters.AddWithValue("@p2", p.ActorSurname);
            command.Parameters.AddWithValue("@p3", p.ActorAge);
            command.Parameters.AddWithValue("@p4", p.ActorID);
            command.ExecuteNonQuery();
            DbConnection.sqlConnection.Close();
        }
    }

   
   
   





}
