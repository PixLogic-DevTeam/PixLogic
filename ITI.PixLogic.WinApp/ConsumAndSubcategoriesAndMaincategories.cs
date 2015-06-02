using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PixLogic.DAL
{
    class ConsumAndSubcategoriesAndMaincategories
    {
        public consumables consumables { get; set; }
        public consumables_sub_categories sub_categories { get; set; }
        public states state { get; set; }
        public Int64 id
        {
            get { return consumables.id; }
            set { consumables.id = value; }
        }
        public string sub_category
        {
            get { return sub_categories.name; }
            set { sub_categories.name = value; }
        }
		public string product_reference
        {
            get { return consumables.product_reference; }
			set { consumables.product_reference = value; }
        }
        public long? reservation_cost
        {
            get { return consumables.reservation_cost; }
            set { consumables.reservation_cost = value; }
        }
        public string current_state
        {
            get { return state.name; }
            set { state.name = value; }
        }
        public string description
        {
            get { return consumables.description; }
            set { consumables.description = value; }
        }
    }
}
