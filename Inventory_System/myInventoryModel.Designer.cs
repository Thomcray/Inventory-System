﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Inventory_System
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class myInventoryModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new myInventoryModelContainer object using the connection string found in the 'myInventoryModelContainer' section of the application configuration file.
        /// </summary>
        public myInventoryModelContainer() : base("name=myInventoryModelContainer", "myInventoryModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new myInventoryModelContainer object.
        /// </summary>
        public myInventoryModelContainer(string connectionString) : base(connectionString, "myInventoryModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new myInventoryModelContainer object.
        /// </summary>
        public myInventoryModelContainer(EntityConnection connection) : base(connection, "myInventoryModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
