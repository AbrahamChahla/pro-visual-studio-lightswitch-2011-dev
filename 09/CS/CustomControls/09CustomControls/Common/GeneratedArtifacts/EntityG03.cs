

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
    public sealed partial class Order : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Order entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Order()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Order(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Order> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Order.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Order_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Order_AllowSaveWithErrors(ref bool result);
    
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
                return global::LightSwitchApplication.Order.DetailsClass.GetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Order.DetailsClass.SetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Id, value);
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
        public string OrderDesc
        {
            get
            {
                return global::LightSwitchApplication.Order.DetailsClass.GetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.OrderDesc);
            }
            set
            {
                global::LightSwitchApplication.Order.DetailsClass.SetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.OrderDesc, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void OrderDesc_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void OrderDesc_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void OrderDesc_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime OrderDate
        {
            get
            {
                return global::LightSwitchApplication.Order.DetailsClass.GetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.OrderDate);
            }
            set
            {
                global::LightSwitchApplication.Order.DetailsClass.SetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.OrderDate, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void OrderDate_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void OrderDate_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void OrderDate_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Customer Customer
        {
            get
            {
                return global::LightSwitchApplication.Order.DetailsClass.GetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Customer);
            }
            set
            {
                global::LightSwitchApplication.Order.DetailsClass.SetValue(this, global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Customer, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Customer_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Order,
                global::LightSwitchApplication.Order.DetailsClass,
                global::LightSwitchApplication.Order.DetailsClass.IImplementation,
                global::LightSwitchApplication.Order.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>.Entry
                __OrderEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>.Entry(
                    global::LightSwitchApplication.Order.DetailsClass.__Order_CreateNew,
                    global::LightSwitchApplication.Order.DetailsClass.__Order_Created,
                    global::LightSwitchApplication.Order.DetailsClass.__Order_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Order __Order_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Order> es)
            {
                return new global::LightSwitchApplication.Order(es);
            }
            private static void __Order_Created(global::LightSwitchApplication.Order e)
            {
                e.Order_Created();
            }
            private static bool __Order_AllowSaveWithErrors(global::LightSwitchApplication.Order e)
            {
                bool result = false;
                e.Order_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Order.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, string> OrderDesc
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.OrderDesc) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::System.DateTime> OrderDate
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.OrderDate) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::System.DateTime>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::LightSwitchApplication.Customer> Customer
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Customer) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::LightSwitchApplication.Customer>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string OrderDesc { get; set; }
                new global::System.DateTime OrderDate { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Customer { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Order.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, int>.Data> c, global::LightSwitchApplication.Order.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Order e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Order e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Order e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, string>.Entry
                    OrderDesc = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, string>.Entry(
                        "OrderDesc",
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDesc_Stub,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDesc_ComputeIsReadOnly,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDesc_Validate,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDesc_GetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDesc_SetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDesc_OnValueChanged);
                private static void _OrderDesc_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Order.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, string>.Data> c, global::LightSwitchApplication.Order.DetailsClass d, object sf)
                {
                    c(d, ref d._OrderDesc, sf);
                }
                private static bool _OrderDesc_ComputeIsReadOnly(global::LightSwitchApplication.Order e)
                {
                    bool result = false;
                    e.OrderDesc_IsReadOnly(ref result);
                    return result;
                }
                private static void _OrderDesc_Validate(global::LightSwitchApplication.Order e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.OrderDesc_Validate(r);
                }
                private static string _OrderDesc_GetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d)
                {
                    return d.ImplementationEntity.OrderDesc;
                }
                private static void _OrderDesc_SetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d, string v)
                {
                    d.ImplementationEntity.OrderDesc = v;
                }
                private static void _OrderDesc_OnValueChanged(global::LightSwitchApplication.Order e)
                {
                    e.OrderDesc_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::System.DateTime>.Entry
                    OrderDate = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::System.DateTime>.Entry(
                        "OrderDate",
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDate_Stub,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDate_ComputeIsReadOnly,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDate_Validate,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDate_GetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDate_SetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._OrderDate_OnValueChanged);
                private static void _OrderDate_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Order.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::System.DateTime>.Data> c, global::LightSwitchApplication.Order.DetailsClass d, object sf)
                {
                    c(d, ref d._OrderDate, sf);
                }
                private static bool _OrderDate_ComputeIsReadOnly(global::LightSwitchApplication.Order e)
                {
                    bool result = false;
                    e.OrderDate_IsReadOnly(ref result);
                    return result;
                }
                private static void _OrderDate_Validate(global::LightSwitchApplication.Order e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.OrderDate_Validate(r);
                }
                private static global::System.DateTime _OrderDate_GetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d)
                {
                    return d.ImplementationEntity.OrderDate;
                }
                private static void _OrderDate_SetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d, global::System.DateTime v)
                {
                    d.ImplementationEntity.OrderDate = global::LightSwitchApplication.Order.DetailsClass.TruncateDate(v);
                }
                private static void _OrderDate_OnValueChanged(global::LightSwitchApplication.Order e)
                {
                    e.OrderDate_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::LightSwitchApplication.Customer>.Entry
                    Customer = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::LightSwitchApplication.Customer>.Entry(
                        "Customer",
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_Stub,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_ComputeIsReadOnly,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_Validate,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_GetCoreImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_GetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_SetImplementationValue,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_Refresh,
                        global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties._Customer_OnValueChanged);
                private static void _Customer_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Order.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::LightSwitchApplication.Customer>.Data> c, global::LightSwitchApplication.Order.DetailsClass d, object sf)
                {
                    c(d, ref d._Customer, sf);
                }
                private static bool _Customer_ComputeIsReadOnly(global::LightSwitchApplication.Order e)
                {
                    bool result = false;
                    e.Customer_IsReadOnly(ref result);
                    return result;
                }
                private static void _Customer_Validate(global::LightSwitchApplication.Order e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Customer_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Customer_GetCoreImplementationValue(global::LightSwitchApplication.Order.DetailsClass d)
                {
                    return d.ImplementationEntity.Customer;
                }
                private static global::LightSwitchApplication.Customer _Customer_GetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Customer, global::LightSwitchApplication.Customer.DetailsClass>(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Customer, ref d._Customer);
                }
                private static void _Customer_SetImplementationValue(global::LightSwitchApplication.Order.DetailsClass d, global::LightSwitchApplication.Customer v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Customer, ref d._Customer, (i, ev) => i.Customer = ev, v);
                }
                private static void _Customer_Refresh(global::LightSwitchApplication.Order.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.Order.DetailsClass.PropertySetProperties.Customer, ref d._Customer);
                }
                private static void _Customer_OnValueChanged(global::LightSwitchApplication.Order e)
                {
                    e.Customer_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, string>.Data _OrderDesc;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::System.DateTime>.Data _OrderDate;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Order, global::LightSwitchApplication.Order.DetailsClass, global::LightSwitchApplication.Customer>.Data _Customer;
            
        }
    
        #endregion
    }
    
    #endregion
}
