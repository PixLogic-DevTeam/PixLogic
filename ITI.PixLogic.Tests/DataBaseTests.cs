using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ITI.PixLogic.DAL;
using System.Data.Entity;
using System.Data.EntityClient;

namespace ITI.PixLogic.Tests
{
	[TestFixture]
    public class DataBaseTests
    {
        [Test]
        public void tables_consumable_is_not_null()
        {
            pldb_entities ple = new pldb_entities();
            ple.consumables.Load();
           var data =  ple.consumables.Local.ToBindingList();

           Assert.That(data != null);
        }
    }
}
