namespace SimpleSchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SimpleSchema.Schema1",@"Person")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::SimpleSchema.PropertySchema.StateOfBirth), XPath = @"/*[local-name()='Person' and namespace-uri()='http://SimpleSchema.Schema1']/*[local-name()='StateOfBirth' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Person"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SimpleSchema.PropertySchema.PropertySchema", typeof(global::SimpleSchema.PropertySchema.PropertySchema))]
    public sealed class Schema1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SimpleSchema.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://SimpleSchema.PropertySchema"" targetNamespace=""http://SimpleSchema.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://SimpleSchema.PropertySchema"" location=""SimpleSchema.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Person"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:StateOfBirth"" xpath=""/*[local-name()='Person' and namespace-uri()='http://SimpleSchema.Schema1']/*[local-name()='StateOfBirth' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Name"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FirstName"" type=""xs:string"" />
              <xs:element name=""LastName"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Birthdate"" type=""xs:string"" />
        <xs:element name=""StateOfBirth"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Person";
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
