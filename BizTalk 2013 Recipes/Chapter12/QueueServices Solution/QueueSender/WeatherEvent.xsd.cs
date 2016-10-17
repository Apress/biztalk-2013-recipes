namespace QueueSender {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://WeatherBizTalkService.WeatherEvent",@"WeatherEvent")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"WeatherEvent"})]
    public sealed class WeatherEvent : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://WeatherBizTalkService.WeatherEvent"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://WeatherBizTalkService.WeatherEvent"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""WeatherEvent"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""EventType"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Temperature"" type=""xs:int"" />
        <xs:element name=""IsAlert"" type=""xs:boolean"" />
        <xs:element name=""AffectedArea"" type=""xs:string"" />
        <xs:element name=""ZipCode"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public WeatherEvent() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "WeatherEvent";
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
