namespace ReceivingSQLAdapter {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SQLReceiveAdapter",@"Customer_Response")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customer_Response"})]
    public sealed class SQLService : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://SQLReceiveAdapter"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <msbtssql:sqlScript value=""exec [CustomerToBizTalk]"" xmlns:msbtssql=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Customer_Response"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""http://SQLReceiveAdapter"" minOccurs=""0"" maxOccurs=""unbounded"" name=""Customer"" type=""q1:CustomerType"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""CustomerType"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element xmlns:q2=""http://SQLReceiveAdapter"" name=""CustomerID"" type=""q2:CustomerIDType"" />
      <xs:element xmlns:q3=""http://SQLReceiveAdapter"" name=""CustomerName"" type=""q3:CustomerNameType"" />
      <xs:element xmlns:q4=""http://SQLReceiveAdapter"" name=""Address"" type=""q4:AddressType"" />
      <xs:element xmlns:q5=""http://SQLReceiveAdapter"" name=""City"" type=""q5:CityType"" />
      <xs:element xmlns:q6=""http://SQLReceiveAdapter"" name=""Region"" type=""q6:RegionType"" />
      <xs:element xmlns:q7=""http://SQLReceiveAdapter"" name=""PostalCode"" type=""q7:PostalCodeType"" />
      <xs:element xmlns:q8=""http://SQLReceiveAdapter"" name=""RecordStatus"" type=""q8:RecordStatusType"" />
    </xs:choice>
  </xs:complexType>
  <xs:complexType name=""CustomerIDType"">
    <xs:simpleContent>
      <xs:extension base=""xs:int"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""CustomerNameType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""AddressType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""CityType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""RegionType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PostalCodeType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""RecordStatusType"">
    <xs:simpleContent>
      <xs:extension base=""xs:unsignedByte"" />
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public SQLService() {
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
