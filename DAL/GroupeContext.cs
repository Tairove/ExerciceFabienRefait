using Groupe.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Groupe.DAL
{
    public class GroupeContext : DbContext //Hérite de DbContext .
    {

        public GroupeContext() : base("GroupeContext")
        {
        }

        public DbSet<Personne> Personnes { get; set; } //Mettre dans la bdd le modèle Personne

        public DbSet<Pays> Pays { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) //La table sera modelé en foction du model
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Evite de mettre les noms de table au pluriels
        }
    }
}