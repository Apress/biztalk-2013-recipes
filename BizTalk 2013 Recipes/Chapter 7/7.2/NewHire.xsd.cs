namespace CreatingAndTestingRules {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CreatingAndTestingRules.NewHire",@"NewHireList")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"NewHireList"})]
    public sealed class NewHire : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CreatingAndTestingRules.NewHire"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CreatingAndTestingRules.NewHire"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""NewHireList"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""DateTime"" type=""xs:dateTime"" />
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ID"" type=""xs:int"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Role"" type=""xs:string"" />
              <xs:element name=""Age"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public NewHire() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "NewHireList";
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
