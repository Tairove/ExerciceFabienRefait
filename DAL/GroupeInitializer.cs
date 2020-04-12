using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Groupe.Models;

namespace Groupe.DAL
{
    public class GroupeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GroupeContext>
    {
        protected override void Seed(GroupeContext context)
        {
            var personnes = new List<Personne>
            {

            };

            personnes.ForEach(s => context.Personnes.Add(s));
            context.SaveChanges();



            var pays = new List<Pays>
            {

            };

            pays.ForEach(s => context.Pays.Add(s));
            context.SaveChanges();

        }
    }
}