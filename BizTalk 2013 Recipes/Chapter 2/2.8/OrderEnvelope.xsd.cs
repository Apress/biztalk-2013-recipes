namespace EnvelopeSolution {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://EnvelopeSolution.OrderEnvelope",@"OrderEnvelope")]
    [BodyXPath(@"/*[local-name()='OrderEnvelope' and namespace-uri()='http://EnvelopeSolution.OrderEnvelope']/*[local-name()='Orders' and namespace-uri()='']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderEnvelope"})]
    public sealed class OrderEnvelope : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://EnvelopeSolution.OrderEnvelope"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://EnvelopeSolution.OrderEnvelope"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OrderEnvelope"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='OrderEnvelope' and namespace-uri()='http://EnvelopeSolution.OrderEnvelope']/*[local-name()='Orders' and namespace-uri()='']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""BatchID"" type=""xs:string"" />
        <xs:element name=""Orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Order"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:any />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderEnvelope() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderEnvelope";
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
