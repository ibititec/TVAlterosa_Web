//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 28/08/2014 19:49:21
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using CORE.Auth.Entidades;
using CORE.Auth.Mapeamentos;

namespace CORE.Auth.Contexto
{
    public partial class Entities : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities() :
            base(@"name=ISAEntitiesConnectionString")
        {
            Configure();
        }

        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities(string nameOrConnectionString) :
            base(nameOrConnectionString)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(DbConnection existingConnection, bool contextOwnsConnection) :
            base(existingConnection, contextOwnsConnection)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(ObjectContext objectContext, bool dbContextOwnsObjectContext) :
            base(objectContext, dbContextOwnsObjectContext)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string nameOrConnectionString, DbCompiledModel model) :
            base(nameOrConnectionString, model)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) :
            base(existingConnection, model, contextOwnsConnection)
        {
            Configure();
        }

        private void Configure()
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = true;
            Database.SetInitializer<Entities>(null);
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ISAGrupoModuloConfiguration());
            modelBuilder.Configurations.Add(new ISAGrupoTransacaoConfiguration());
            modelBuilder.Configurations.Add(new ISAGrupoUsuaConfiguration());
             

            #region Disabled conventions


            #endregion

        }


        /// <summary>
        /// There are no comments for ISAGrupoModulo in the schema.
        /// </summary>
        public virtual DbSet<ISAGrupoModulo> ISAGrupoModulos { get; set; }

        /// <summary>
        /// There are no comments for ISAGrupoTransacao in the schema.
        /// </summary>
        public virtual DbSet<ISAGrupoTransacao> ISAGrupoTransacaos { get; set; }

        /// <summary>
        /// There are no comments for ISAGrupoUsua in the schema.
        /// </summary>
        public virtual DbSet<ISAGrupoUsua> ISAGrupoUsuas { get; set; }
    }
}
