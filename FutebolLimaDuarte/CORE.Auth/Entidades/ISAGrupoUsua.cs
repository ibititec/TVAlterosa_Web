//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 28/08/2014 19:49:21
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace CORE.Auth.Entidades
{

    /// <summary>
    /// There are no comments for Model.ISAGrupoUsua in the schema.
    /// </summary>
    public partial class ISAGrupoUsua    {

        public ISAGrupoUsua()
        {
            this.ISAGrupoTransacaos = new HashSet<ISAGrupoTransacao>();
        }

        #region Properties
    
        /// <summary>
        /// There are no comments for CDGRUPOUSUA in the schema.
        /// </summary>
        public virtual string CDGRUPOUSUA
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NMGRUPOUSUA in the schema.
        /// </summary>
        public virtual string NMGRUPOUSUA
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for DCGRUPOUSUA in the schema.
        /// </summary>
        public virtual string DCGRUPOUSUA
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NMGRUPOREDECRPD in the schema.
        /// </summary>
        public virtual string NMGRUPOREDECRPD
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for ISAGrupoTransacaos in the schema.
        /// </summary>
        public virtual ICollection<ISAGrupoTransacao> ISAGrupoTransacaos
        {
            get;
            set;
        }

        #endregion
    }

}
