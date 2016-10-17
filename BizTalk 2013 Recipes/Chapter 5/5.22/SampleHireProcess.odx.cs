
#pragma warning disable 162

namespace Sample_Role_Link_Recipe
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Sample_Role_Link_Recipe.__messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceiveNewHireRequestType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveNewHireRequestType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveNewHireRequestType(ReceiveNewHireRequestType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveNewHireRequestType p = new ReceiveNewHireRequestType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceiveNewHireRequestType),
            typeof(__messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Sample_Role_Link_Recipe.__messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class SendPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendPortType(SendPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendPortType p = new SendPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendPortType),
            typeof(__messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.ServiceLinkTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceLinkTypeRoleAttribute(
        "Consumer",
        new System.Type[] {
            typeof(Sample_Role_Link_Recipe.SendPortType)
        }
    )]
    sealed internal class NewHireApprovalType : Microsoft.XLANGs.Core.ServiceLinkType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        sealed public class Consumer : Microsoft.XLANGs.Core.Role
        {
            static private System.Type[] _portTypes = new System.Type[] {
                typeof(Sample_Role_Link_Recipe.SendPortType)
            };
            public override System.Type[] PortTypes { get { return _portTypes; } }
            static public System.Type[] PortTypesList { get { return _portTypes; } }
        }
    }
    //#line 166 "C:\Documents and Settings\Administrator\Desktop\BizTalk Book Solutions\Sample Role Link Recipe Project\SampleHireProcess.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveNewHireRequest", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Sample_Role_Link_Recipe.ReceiveNewHireRequestType),
            typeof(Sample_Role_Link_Recipe.SendPortType)
        },
        new System.String[] {
            "ReceiveNewHireRequest",
            "__NewHireApproval_SendPortType"
        },
        new System.Type[] {
            null,
            typeof(Sample_Role_Link_Recipe.NewHireApprovalType.Consumer)
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eServiceLink|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Sample_Role_Link_Recipe.NewHireApprovalType.Consumer)
        },
        new System.String[] {
            "NewHireApproval"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class SampleHireProcess : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SampleHireProcess));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static SampleHireProcess()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __SampleHireProcess_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public SampleHireProcess(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SampleHireProcess", tracker)
        {
            ConstructorHelper();
        }

        public SampleHireProcess(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "SampleHireProcess")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>ca13f0c7-2a1d-4952-b3d0-5848a41bdeb8</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2b60af9f-2ecb-426a-9a7c-47656a173a4f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ReceiveRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1f68985e-f859-4585-8775-47a07ad4ed3a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>InitializeRoleLinks</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c93d0d4c-55a6-41ae-a94b-2741bc5cb7c5</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SendRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow>
<Metadata>

<TrkMetadata>
<ActionName>'SampleHireProcess'</ActionName><IsAtomic>0</IsAtomic><Line>166</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>175</Line><Position>22</Position><ShapeID>'2b60af9f-2ecb-426a-9a7c-47656a173a4f'</ShapeID>
<Messages>
	<MsgInfo><name>msgNewHire</name><part>part</part><schema>Sample_Role_Link_Recipe.SampleNewHireRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>178</Line><Position>74</Position><ShapeID>'1f68985e-f859-4585-8775-47a07ad4ed3a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>180</Line><Position>13</Position><ShapeID>'c93d0d4c-55a6-41ae-a94b-2741bc5cb7c5'</ShapeID>
<Messages>
	<MsgInfo><name>msgNewHire</name><part>part</part><schema>Sample_Role_Link_Recipe.SampleNewHireRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='00adbd3f-f249-42f3-b1cd-496854d0a0d9' LowerBound='1.1' HigherBound='44.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Sample_Role_Link_Recipe' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='db7de40a-1a76-43fb-895a-db508ce3453b' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='43.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SampleHireProcess' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceLinkDeclaration' OID='0dcfbd15-6a57-41e5-b3ca-08c1ed73d0d7' ParentLink='ServiceDeclaration_ServiceLinkDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='RoleName' Value='Consumer' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Sample_Role_Link_Recipe.NewHireApprovalType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NewHireApproval' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='5b5d40fd-a348-4ab3-934a-c2f4f8b21e2e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='Type' Value='Sample_Role_Link_Recipe.SampleNewHireRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgNewHire' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='ca13f0c7-2a1d-4952-b3d0-5848a41bdeb8' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='2b60af9f-2ecb-426a-9a7c-47656a173a4f' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='36.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveNewHireRequest' />
                    <om:Property Name='MessageName' Value='msgNewHire' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReceiveRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='1f68985e-f859-4585-8775-47a07ad4ed3a' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='39.1'>
                    <om:Property Name='Expression' Value='//set the approver name&#xD;&#xA;NewHireApproval(Microsoft.XLANGs.BaseTypes.DestinationParty) = new Microsoft.XLANGs.BaseTypes.Party(msgNewHire.Approver, &quot;OrganizationName&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='InitializeRoleLinks' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Send' OID='c93d0d4c-55a6-41ae-a94b-2741bc5cb7c5' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='MessageName' Value='msgNewHire' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ServiceLinkName' Value='NewHireApproval' />
                    <om:Property Name='ServiceLinkPortTypeName' Value='Sample_Role_Link_Recipe.SendPortType' />
                    <om:Property Name='ServiceLinkRoleName' Value='Consumer' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SendRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f1c4ec59-290b-4741-bc84-985b30a25c2e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='29.1' HigherBound='31.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Sample_Role_Link_Recipe.ReceiveNewHireRequestType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveNewHireRequest' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='19c8b424-7783-488b-a7e2-ed861bfcecfc' ParentLink='PortDeclaration_CLRAttribute' LowerBound='29.1' HigherBound='30.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='738a4c60-0063-4c3b-91db-876dec5e7810' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveNewHireRequestType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a194ea19-9c5e-4013-bd02-872afd21f2fb' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='d5994ce4-6f2c-4991-98bd-03251171211d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.33'>
                    <om:Property Name='Ref' Value='Sample_Role_Link_Recipe.SampleNewHireRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0c2065c6-a5be-4143-abbc-c0a5a4ddcf03' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d630da51-d565-4415-982a-1778a1248882' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='90026aa5-8979-4949-b9e6-db748c96f643' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.33'>
                    <om:Property Name='Ref' Value='Sample_Role_Link_Recipe.SampleNewHireRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceLinkType' OID='62652536-0f7f-408e-ae39-d0b19d2b24e8' ParentLink='Module_ServiceLinkType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='NewHireApprovalType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='RoleDeclaration' OID='213b623a-73be-4290-b53b-1fd4023db13f' ParentLink='ServiceLinkType_RoleDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Consumer' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PortTypeRef' OID='05a1baf6-81f2-421a-881a-3857a1170489' ParentLink='RoleDeclaration_PortTypeRef' LowerBound='22.13' HigherBound='22.25'>
                    <om:Property Name='Ref' Value='Sample_Role_Link_Recipe.SendPortType' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='PortTypeRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SampleHireProcess_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SampleHireProcess_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SampleHireProcess")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                SampleHireProcess __svc__ = (SampleHireProcess)_service;
                __SampleHireProcess_root_0 __ctx0__ = (__SampleHireProcess_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveNewHireRequest != null)
                {
                    __svc__.ReceiveNewHireRequest.Close(this, null);
                    __svc__.ReceiveNewHireRequest = null;
                }
                if (__svc__.__NewHireApproval_SendPortType != null)
                {
                    __svc__.__NewHireApproval_SendPortType.Close(this, null);
                    __svc__.__NewHireApproval_SendPortType = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __SampleHireProcess_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __SampleHireProcess_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SampleHireProcess")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                SampleHireProcess __svc__ = (SampleHireProcess)_service;
                __SampleHireProcess_1 __ctx1__ = (__SampleHireProcess_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null) __ctx1__.NewHireApproval = null;
                if (__ctx1__ != null && __ctx1__.__msgNewHire != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgNewHire);
                    __ctx1__.__msgNewHire = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("NewHireApproval")]
            internal Microsoft.XLANGs.Core.ServiceLink NewHireApproval;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgNewHire")]
            public __messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest __msgNewHire;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveNewHireRequest")]
        internal ReceiveNewHireRequestType ReceiveNewHireRequest;
        [Microsoft.XLANGs.Core.UserVariableAttribute("__NewHireApproval_SendPortType")]
        internal SendPortType __NewHireApproval_SendPortType;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveNewHireRequestType.Operation_1},
                                               typeof(SampleHireProcess).GetField("ReceiveNewHireRequest", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SampleHireProcess), "ReceiveNewHireRequest"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendPortType.Operation_1},
                                               typeof(SampleHireProcess).GetField("__NewHireApproval_SendPortType", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SampleHireProcess), "__NewHireApproval_SendPortType"),
                                               typeof(NewHireApprovalType.Consumer))
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "2b60af9f-2ecb-426a-9a7c-47656a173a4f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "2b60af9f-2ecb-426a-9a7c-47656a173a4f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "1f68985e-f859-4585-8775-47a07ad4ed3a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "1f68985e-f859-4585-8775-47a07ad4ed3a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "c93d0d4c-55a6-41ae-a94b-2741bc5cb7c5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c93d0d4c-55a6-41ae-a94b-2741bc5cb7c5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,7,7,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,5,6,7,7,7,7,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __SampleHireProcess_root_0 __ctx0__ = (__SampleHireProcess_root_0)_stateMgrs[0];
            __SampleHireProcess_1 __ctx1__ = (__SampleHireProcess_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveNewHireRequest = new ReceiveNewHireRequestType(0, this);
                __NewHireApproval_SendPortType = new SendPortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveNewHireRequest, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SampleHireProcess_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __SampleHireProcess_root_0 __ctx0__ = (__SampleHireProcess_root_0)_stateMgrs[0];
            __SampleHireProcess_1 __ctx1__ = (__SampleHireProcess_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceiveNewHireRequest.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgNewHire != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgNewHire);
                __ctx1__.__msgNewHire = new __messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest("msgNewHire", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgNewHire);
                ReceiveNewHireRequest.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgNewHire, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveNewHireRequest != null)
                {
                    ReceiveNewHireRequest.Close(__ctx1__, __seg__);
                    ReceiveNewHireRequest = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgNewHire);
                    __edata.PortName = @"ReceiveNewHireRequest";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx1__.NewHireApproval = new Microsoft.XLANGs.Core.ServiceLink(
                    new Microsoft.XLANGs.Core.PortBase[] {
                        __NewHireApproval_SendPortType
                    });
                __ctx1__.NewHireApproval.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.DestinationParty), new Microsoft.XLANGs.BaseTypes.Party((System.String)__ctx1__.__msgNewHire.part.GetDistinguishedField("Approver"), "OrganizationName"));
                RootService.CommitStateManager.UserCodeCalled = true;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.NewHireApproval[0].SendMessage(0, __ctx1__.__msgNewHire, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (__ctx1__ != null) __ctx1__.NewHireApproval = null;
                if (__NewHireApproval_SendPortType != null)
                {
                    __NewHireApproval_SendPortType.Close(__ctx1__, __seg__);
                    __NewHireApproval_SendPortType = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgNewHire);
                    __edata.PortName = @"__NewHireApproval_SendPortType";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgNewHire != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgNewHire);
                    __ctx1__.__msgNewHire = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Sample_Role_Link_Recipe_SampleNewHireRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Sample_Role_Link_Recipe.SampleNewHireRequest _schema = new Sample_Role_Link_Recipe.SampleNewHireRequest();

        public __Sample_Role_Link_Recipe_SampleNewHireRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Sample_Role_Link_Recipe.SampleNewHireRequest",
        new System.Type[]{
            typeof(Sample_Role_Link_Recipe.SampleNewHireRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Sample_Role_Link_Recipe_SampleNewHireRequest__)
        },
        0,
        @"http://Sample_Role_Link_Recipe.SampleNewHireRequest#ApplicantApproval"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Sample_Role_Link_Recipe_SampleNewHireRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __Sample_Role_Link_Recipe_SampleNewHireRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Sample_Role_Link_Recipe_SampleNewHireRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
