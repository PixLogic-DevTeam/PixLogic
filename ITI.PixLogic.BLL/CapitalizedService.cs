using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.PixLogic.DAL;


namespace ITI.PixLogic.BLL
{
    public static class CapitalizedService
    {

        static void DeleteCapitalized(capitalized capToDelete)
        {
            PacksEntity _packEntity;

            var getCaptilazedPackRequest = from c in _packEntity.capitalized_items_in_packs 
                                         where c.item=capToDelete.id
                                           select c;
                                                 
                                             
        }
    }
}
