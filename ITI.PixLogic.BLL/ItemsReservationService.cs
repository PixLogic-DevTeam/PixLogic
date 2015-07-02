using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.PixLogic.DAL.Contexts;

namespace ITI.PixLogic.BLL
{
    class ItemsReservationService
    {

        ItemsEntity _itemsEntity = new ItemsEntity( );

        public List<Item>GetItemsBySubCategory( string categoryName)
        {
            var getitems = from item in _itemsEntity.Items join functionalCategory in _itemsEntity.ItemFunctionalCategories
						   on item.FunctionalCategory equals functionalCategory.Id
						   where functionalCategory.Name == categoryName
                           select item;

            return getitems.ToList( );
        }

    }
}
