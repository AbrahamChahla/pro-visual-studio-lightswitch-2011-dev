

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
    public sealed partial class User : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the User entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public User()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public User(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.User> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.User.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void User_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void User_AllowSaveWithErrors(ref bool result);
    
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
                return global::LightSwitchApplication.User.DetailsClass.GetValue(this, global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.User.DetailsClass.SetValue(this, global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Id, value);
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
        public string Username
        {
            get
            {
                return global::LightSwitchApplication.User.DetailsClass.GetValue(this, global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Username);
            }
            set
            {
                global::LightSwitchApplication.User.DetailsClass.SetValue(this, global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Username, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Username_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Username_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Username_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Password
        {
            get
            {
                return global::LightSwitchApplication.User.DetailsClass.GetValue(this, global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Password);
            }
            set
            {
                global::LightSwitchApplication.User.DetailsClass.SetValue(this, global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Password, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Password_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Password_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Password_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.User,
                global::LightSwitchApplication.User.DetailsClass,
                global::LightSwitchApplication.User.DetailsClass.IImplementation,
                global::LightSwitchApplication.User.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>.Entry
                __UserEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>.Entry(
                    global::LightSwitchApplication.User.DetailsClass.__User_CreateNew,
                    global::LightSwitchApplication.User.DetailsClass.__User_Created,
                    global::LightSwitchApplication.User.DetailsClass.__User_AllowSaveWithErrors);
            private static global::LightSwitchApplication.User __User_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.User> es)
            {
                return new global::LightSwitchApplication.User(es);
            }
            private static void __User_Created(global::LightSwitchApplication.User e)
            {
                e.User_Created();
            }
            private static bool __User_AllowSaveWithErrors(global::LightSwitchApplication.User e)
            {
                bool result = false;
                e.User_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.User.DetailsClass.PropertySet Properties
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
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string> Username
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Username) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string> Password
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.User.DetailsClass.PropertySetProperties.Password) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new string Username { get; set; }
                new string Password { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.User.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, int>.Data> c, global::LightSwitchApplication.User.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.User e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.User e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.User.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.User.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.User e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Entry
                    Username = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Entry(
                        "Username",
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Username_Stub,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Username_ComputeIsReadOnly,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Username_Validate,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Username_GetImplementationValue,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Username_SetImplementationValue,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Username_OnValueChanged);
                private static void _Username_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.User.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Data> c, global::LightSwitchApplication.User.DetailsClass d, object sf)
                {
                    c(d, ref d._Username, sf);
                }
                private static bool _Username_ComputeIsReadOnly(global::LightSwitchApplication.User e)
                {
                    bool result = false;
                    e.Username_IsReadOnly(ref result);
                    return result;
                }
                private static void _Username_Validate(global::LightSwitchApplication.User e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Username_Validate(r);
                }
                private static string _Username_GetImplementationValue(global::LightSwitchApplication.User.DetailsClass d)
                {
                    return d.ImplementationEntity.Username;
                }
                private static void _Username_SetImplementationValue(global::LightSwitchApplication.User.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Username = v;
                }
                private static void _Username_OnValueChanged(global::LightSwitchApplication.User e)
                {
                    e.Username_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Entry
                    Password = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Entry(
                        "Password",
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Password_Stub,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Password_ComputeIsReadOnly,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Password_Validate,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Password_GetImplementationValue,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Password_SetImplementationValue,
                        global::LightSwitchApplication.User.DetailsClass.PropertySetProperties._Password_OnValueChanged);
                private static void _Password_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.User.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Data> c, global::LightSwitchApplication.User.DetailsClass d, object sf)
                {
                    c(d, ref d._Password, sf);
                }
                private static bool _Password_ComputeIsReadOnly(global::LightSwitchApplication.User e)
                {
                    bool result = false;
                    e.Password_IsReadOnly(ref result);
                    return result;
                }
                private static void _Password_Validate(global::LightSwitchApplication.User e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Password_Validate(r);
                }
                private static string _Password_GetImplementationValue(global::LightSwitchApplication.User.DetailsClass d)
                {
                    return d.ImplementationEntity.Password;
                }
                private static void _Password_SetImplementationValue(global::LightSwitchApplication.User.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Password = v;
                }
                private static void _Password_OnValueChanged(global::LightSwitchApplication.User e)
                {
                    e.Password_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Data _Username;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.User, global::LightSwitchApplication.User.DetailsClass, string>.Data _Password;
            
        }
    
        #endregion
    }
    
    #endregion
}
