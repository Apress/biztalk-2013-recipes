using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Resources;
using System.Reflection;
// BizTalk classes
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;

namespace PropertyPromotionPipelineExample
{
    /// <summary>
    /// BizTalk Server custom pipeline component that creates 
    /// a custom context property for the inbound message.

    /// </summary>
    /// 
    // Attribute declarations to identify this class is a pipeline component 
    // and that the assembly can be used in any pipeline stage
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("63ed4b26-63cd-4d29-9661-f584c94cf858")]
    public class PropertyPromotionPipelineExample : 
        Microsoft.BizTalk.Component.Interop.IBaseComponent
        , Microsoft.BizTalk.Component.Interop.IComponent
        , Microsoft.BizTalk.Component.Interop.IComponentUI
        , Microsoft.BizTalk.Component.Interop.IPersistPropertyBag
    {
        //Key for storage on property bag:
        private string m_propbagkey_customproprop
                = "SAMPLECUSTOMPROPROP";
        private string m_propbagkey_custompropropnamespace
                = "SAMPLECUSTOMPROPROPNAMESPACE";
    
        //Var to store design time value
        private string m_propname = "";
        private string m_propnamespace = "";

        static ResourceManager resManager = new ResourceManager("SampleCustom PipelineComponent.SampleCustomPipelineComponent", Assembly.GetExecutingAssembly());

        public PropertyPromotionPipelineExample()
        {
            // Default constructor logic
        }

        #region Public Properties
        // Display the following public properties for design time
        public string CustomContextPropertyName
        {
            get {    return m_propname;}
            set {    m_propname = value;}
        }

        // Display the following public properties for design time
        public string CustomContextPropertyNamespace
        {
            get {    return m_propnamespace;}
            set {    m_propnamespace = value;}
        }
        #endregion

        #region IBaseComponent members defines Description, Name, and Version
        public string Description
        {
            get
            {
                return "Sample Custom Pipeline Component";
            }
        }

        public string Name
        {
            get
            {
                return "Sample Custom Pipeline Component";
            }
        }

        public string Version
        {
            get
            {
                return "1.0";
            }
        }
        #endregion

        #region IComponent members contains the main implementation
        public IBaseMessage Execute(IPipelineContext pContext
                                , IBaseMessage pInMsg)
        {
            // Create custom context property on message
            pInMsg.Context.Promote(m_propname, m_propnamespace, string.Empty);
            return pInMsg;
        }
        #endregion

        #region IComponentUI members contains design time information
        // Include a validate method used by BizTalk
        public IEnumerator Validate(object obj)
        {
            IEnumerator enumerator = null;
            // Return a null            
                return enumerator;
        }
        // We do not have an icon for this custom component
        [Browsable(false)]
        public System.IntPtr Icon
        {
            get
            {
                // No icon associated with this pipeline component
                return  IntPtr.Zero;
            }
        }
        #endregion

        #region IPersistPropertyBag members contains placeholders
        public void GetClassID(out Guid classid)
        {
            // Return class ID of this component for usage from unmanaged code.
            classid = new System.Guid("63ed4b26-63cd-4d29-9661-f584c94cf858");
        }
        
        public void InitNew()
        {
            // Initialization not implemented
        }
        
        public void Load(IPropertyBag propertyBag, Int32 errorlog)
        {
            // Load configuration property for component.
            string val = (string)ReadPropertyBag(propertyBag,
                    m_propbagkey_customproprop);
            
            if (val != null)
                m_propname = val;

            val = (string)ReadPropertyBag(propertyBag,
                    m_propbagkey_custompropropnamespace);
            if (val != null) 
                m_propnamespace = val;
        }
        
        public void Save(IPropertyBag propertyBag
                , Boolean clearDirty, Boolean saveAllProperties)
        {
            // Saves the current component configuration into the property bag.
            object val = (object)m_propname;
            WritePropertyBag(propertyBag, 
                m_propbagkey_customproprop, val);

            val = (object)m_propnamespace;
            WritePropertyBag(propertyBag, 
                m_propbagkey_custompropropnamespace, val);
        }

        private static object ReadPropertyBag(IPropertyBag propertyBag
                , string propertyName)
        {
            // Reads property value from property bag.
            object val = null;
            try
            {
                propertyBag.Read(propertyName, out val, 0);
            }
            catch(ArgumentException)
            {
                return val;
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return val;
        }

        private static void WritePropertyBag(IPropertyBag propertyBag
                , string propertyName, object val)
        {
            // Writes property values into a property bag.
            try
            {
                propertyBag.Write(propertyName, ref val);
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        #endregion
    }
}

