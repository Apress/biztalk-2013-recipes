namespace CustomPipeline
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ReceiveCustomContext : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" N"+
"ame=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040"+
"674ad6\" />      <Components>        <Component>          <Name>PropertyPromotionPipelineExample.Prop"+
"ertyPromotionPipelineExample,PropertyPromotionPipelineExample, Version=1.0.0.0, Culture=neutral, Pub"+
"licKeyToken=null</Name>          <ComponentName>Sample Custom Pipeline Component</ComponentName>    "+
"      <Description>Sample Custom Pipeline Component</Description>          <Version>1.0</Version>   "+
"       <Properties>            <Property Name=\"SAMPLECUSTOMPROPROP\">              <Value xsi:type=\"x"+
"sd:string\" />            </Property>            <Property Name=\"SAMPLECUSTOMPROPROPNAMESPACE\">      "+
"        <Value xsi:type=\"xsd:string\" />            </Property>          </Properties>          <Cach"+
"edDisplayName>Sample Custom Pipeline Component</CachedDisplayName>          <CachedIsManaged>true</C"+
"achedIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage "+
"_locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" sta"+
"geId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "5efaf2e2-e457-4771-a8a1-1e87b96ad422";
        
        public ReceiveCustomContext()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("PropertyPromotionPipelineExample.PropertyPromotionPipelineExample,PropertyPromotionPipelineExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"SAMPLECUSTOMPRO"+
"PROP\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"SAMPLECUSTOMPROPROPNAM"+
"ESPACE\">      <Value xsi:type=\"xsd:string\" />    </Property>  </Properties></PropertyBag>";
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
