

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class Customer : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Customer entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Customer()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Customer(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Customer> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Customer.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Surname
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Surname);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Surname, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Surname_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Surname_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Surname_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Firstname
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Firstname);
            }
            set
            {
                global::LightSwitchApplication.Customer.DetailsClass.SetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Firstname, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Firstname_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Firstname_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Firstname_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Order> Orders
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetValue(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Orders);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Order> OrdersQuery
        {
            get
            {
                return global::LightSwitchApplication.Customer.DetailsClass.GetQuery(this, global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Orders);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Customer,
                global::LightSwitchApplication.Customer.DetailsClass,
                global::LightSwitchApplication.Customer.DetailsClass.IImplementation,
                global::LightSwitchApplication.Customer.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>.Entry
                __CustomerEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>.Entry(
                    global::LightSwitchApplication.Customer.DetailsClass.__Customer_CreateNew,
                    global::LightSwitchApplication.Customer.DetailsClass.__Customer_Created,
                    global::LightSwitchApplication.Customer.DetailsClass.__Customer_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Customer __Customer_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Customer> es)
            {
                return new global::LightSwitchApplication.Customer(es);
            }
            private static void __Customer_Created(global::LightSwitchApplication.Customer e)
            {
                e.Customer_Created();
            }
            private static bool __Customer_AllowSaveWithErrors(global::LightSwitchApplication.Customer e)
            {
                bool result = false;
                e.Customer_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Customer.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string> Surname
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Surname) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string> Firstname
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Firstname) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Order> Orders
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Orders) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Order>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string Surname { get; set; }
                new string Firstname { get; set; }
                new global::System.Collections.IEnumerable Orders { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry
                    Surname = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry(
                        "Surname",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Surname_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Surname_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Surname_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Surname_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Surname_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Surname_OnValueChanged);
                private static void _Surname_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._Surname, sf);
                }
                private static bool _Surname_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.Surname_IsReadOnly(ref result);
                    return result;
                }
                private static void _Surname_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Surname_Validate(r);
                }
                private static string _Surname_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.Surname;
                }
                private static void _Surname_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Surname = v;
                }
                private static void _Surname_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.Surname_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry
                    Firstname = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Entry(
                        "Firstname",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Firstname_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Firstname_ComputeIsReadOnly,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Firstname_Validate,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Firstname_GetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Firstname_SetImplementationValue,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Firstname_OnValueChanged);
                private static void _Firstname_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._Firstname, sf);
                }
                private static bool _Firstname_ComputeIsReadOnly(global::LightSwitchApplication.Customer e)
                {
                    bool result = false;
                    e.Firstname_IsReadOnly(ref result);
                    return result;
                }
                private static void _Firstname_Validate(global::LightSwitchApplication.Customer e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Firstname_Validate(r);
                }
                private static string _Firstname_GetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.Firstname;
                }
                private static void _Firstname_SetImplementationValue(global::LightSwitchApplication.Customer.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Firstname = v;
                }
                private static void _Firstname_OnValueChanged(global::LightSwitchApplication.Customer e)
                {
                    e.Firstname_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Order>.Entry
                    Orders = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Order>.Entry(
                        "Orders",
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Orders_Stub,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Orders_GetReferencedEntities,
                        global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties._Orders_GetEntityCollection);
                private static void _Orders_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Customer.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Order>.Data> c, global::LightSwitchApplication.Customer.DetailsClass d, object sf)
                {
                    c(d, ref d._Orders, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Order> _Orders_GetReferencedEntities(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>(global::LightSwitchApplication.Customer.DetailsClass.PropertySetProperties.Orders, ref d._Orders);
                }
                private static global::System.Collections.IEnumerable _Orders_GetEntityCollection(global::LightSwitchApplication.Customer.DetailsClass d)
                {
                    return d.ImplementationEntity.Orders;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data _Surname;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, string>.Data _Firstname;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass, global::LightSwitchApplication.Order>.Data _Orders;
            
        }
    
        #endregion
    }
    
    #endregion
}
