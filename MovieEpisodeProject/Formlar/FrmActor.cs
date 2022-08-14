using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using FacadeLayer;
using BusinessLayer;
using EntityLayer.Entities;
using FacadeLayer.DAL;

namespace MovieEpisodeProject.Formlar
{
    public partial class FrmActor : Form
    {
        public FrmActor()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<EntityActor> entityActors = BLActor.BLActorList();
            dataGridView1.DataSource = entityActors;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EntityActor entityActor = new EntityActor();
            entityActor.ActorName = txtName.Text;
            entityActor.ActorSurname = txtSurname.Text;
            entityActor.ActorAge = txtAge.Text;
            BLActor.BLAddActor(entityActor);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            BLActor.BLDeleteActor(id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityActor ent = new EntityActor();
            ent.ActorID = int.Parse(txtID.Text);
            ent.ActorName = txtName.Text;
            ent.ActorSurname = txtSurname.Text;
            ent.ActorAge = txtAge.Text;
            BLActor.BLUpdateActor(ent);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
