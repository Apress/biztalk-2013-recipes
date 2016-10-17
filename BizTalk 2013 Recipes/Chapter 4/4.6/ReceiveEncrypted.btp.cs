namespace CreatingEncryptionPipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ReceiveEncrypted : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Microsoft.BizTalk.Component.MIME_SMIME_Decoder,Microsoft.BizTal"+
"k.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>     "+
"     <ComponentName>MIME/SMIME decoder</ComponentName>          <Description>MIME/SMIME decoder comp"+
"onent.</Description>          <Version>1.0</Version>          <Properties>            <Property Name"+
"=\"AllowNonMIMEMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Proper"+
"ty>            <Property Name=\"ValidateCRL\">              <Value xsi:type=\"xsd:boolean\">true</Value>"+
"            </Property>            <Property Name=\"BodyPartContentType\" />            <Property Name"+
"=\"BodyPartIndex\">              <Value xsi:type=\"xsd:unsignedInt\">0</Value>            </Property>   "+
"       </Properties>          <CachedDisplayName>MIME/SMIME decoder</CachedDisplayName>          <Ca"+
"chedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>  "+
"    <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1\" "+
"execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </S"+
"tage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" "+
"maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components /"+
">    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" mi"+
"nOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <"+
"Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "81e87c66-d518-45f1-8251-07c195fde013";
        
        public ReceiveEncrypted()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.MIME_SMIME_Decoder,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"AllowNonMIMEMes"+
"sage\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateCR"+
"L\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Property Name=\"BodyPartConten"+
"tType\" />    <Property Name=\"BodyPartIndex\">      <Value xsi:type=\"xsd:unsignedInt\">0</Value>    </P"+
"roperty>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
