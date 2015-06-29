using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.PixLogic.DAL.Contexts.Items;

namespace ITI.PixLogic.BLL
{
    class ItemsReservationService
    {

        ItemsEntity _itemEntity = new ItemsEntity( );

        public List<Item>GetItemsBySubCategory( string subcat)
        {
            var getitems = from a in _itemEntity.Items
                           join subcategory in _itemEntity.ItemSubCategories on a.SubCategory equals subcategory.Id
                           where subcategory.Name == subcat
                           select a;

            return getitems.ToList( );
        }

    }
}
