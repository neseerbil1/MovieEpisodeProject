using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Entities;
using FacadeLayer;
using FacadeLayer.DAL;


namespace BusinessLayer
{
    public class BLCategory
    {
        public static List<EntityCategory> BLCategoryList()
        {
            return DALCategory.CategoryList();
        }

        public void BLCategoryAdd(EntityCategory entitycategory)
        {
            if(entitycategory.Categoryname!="" && entitycategory.Categoryname.Length<=30 && entitycategory.Categoryname.Length>=5)
            {
                DALCategory.AddCategory(entitycategory);
            }
        }

        public void BLCategoryDelete(int id)
        {
            if(id!=0)
            {
                DALCategory.DeleteCategory(id);
            }
        }

        public void BLCategoryUpdate(EntityCategory entityCategory)
        {
            DALCategory.UpdateCategory(entityCategory);
        }
    }
}
