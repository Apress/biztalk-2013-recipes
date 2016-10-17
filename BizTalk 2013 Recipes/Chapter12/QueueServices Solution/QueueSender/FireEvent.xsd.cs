namespace QueueSender {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://EventConsumerProj.FireEvent",@"FireEvent")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::QueueSender.PropertySchema.ZipCode), XPath = @"/*[local-name()='FireEvent' and namespace-uri()='http://EventConsumerProj.FireEvent']/*[local-name()='ZipCode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::QueueSender.PropertySchema.AlertType), XPath = @"/*[local-name()='FireEvent' and namespace-uri()='http://EventConsumerProj.FireEvent']/*[local-name()='AlertType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ZipCode", XPath = @"/*[local-name()='FireEvent' and namespace-uri()='http://EventConsumerProj.FireEvent']/*[local-name()='ZipCode' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FireEvent"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"QueueSender.PropertySchema.PropertySchema", typeof(global::QueueSender.PropertySchema.PropertySchema))]
    public sealed class FireEvent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://EventConsumerProj.FireEvent"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://QueueSender.PropertySchema"" targetNamespace=""http://EventConsumerProj.FireEvent"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://QueueSender.PropertySchema"" location=""QueueSender.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""FireEvent"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:ZipCode"" xpath=""/*[local-name()='FireEvent' and namespace-uri()='http://EventConsumerProj.FireEvent']/*[local-name()='ZipCode' and namespace-uri()='']"" />
          <b:property name=""ns0:AlertType"" xpath=""/*[local-name()='FireEvent' and namespace-uri()='http://EventConsumerProj.FireEvent']/*[local-name()='AlertType' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FireEvent' and namespace-uri()='http://EventConsumerProj.FireEvent']/*[local-name()='ZipCode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""AlertType"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""AlertColor"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Temperature"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AlertMessage"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ZipCode"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public FireEvent() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "FireEvent";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
