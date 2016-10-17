namespace SendingUpdateGramsSQLAdapter {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customer_Request", @"Customer_Response"})]
    public sealed class InsertCustomerService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://SQLAdapterUpdateGram"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SQLAdapterUpdateGram"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Customer_Request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:updategram=""urn:schemas-microsoft-com:xml-updategram"" updategram:Prefix=""updg"" minOccurs=""1"" maxOccurs=""unbounded"" name=""sync"">
          <xs:complexType>
            <xs:sequence>
              <xs:element updategram:Prefix=""updg"" minOccurs=""0"" maxOccurs=""unbounded"" name=""after"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Customer"">
                      <xs:complexType>
                        <xs:attribute name=""CustomerName"" type=""xs:string"" />
                        <xs:attribute name=""Address"" type=""xs:string"" />
                        <xs:attribute name=""City"" type=""xs:string"" />
                        <xs:attribute name=""Region"" type=""xs:string"" />
                        <xs:attribute name=""PostalCode"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Customer_Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Success"" type=""xs:anyType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InsertCustomerService() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Customer_Request";
                _RootElements[1] = "Customer_Response";
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
        
        [Schema(@"http://SQLAdapterUpdateGram",@"Customer_Request")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Customer_Request"})]
        public sealed class Customer_Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Customer_Request() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Customer_Request";
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
        
        [Schema(@"http://SQLAdapterUpdateGram",@"Customer_Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Customer_Response"})]
        public sealed class Customer_Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Customer_Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Customer_Response";
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
}
