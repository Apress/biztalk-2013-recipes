
#pragma warning disable 162

namespace QueueSender
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(QueueSender.__messagetype_QueueSender_FireEvent)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class FireAlertMsg_Rcv_PortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public FireAlertMsg_Rcv_PortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public FireAlertMsg_Rcv_PortType(FireAlertMsg_Rcv_PortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            FireAlertMsg_Rcv_PortType p = new FireAlertMsg_Rcv_PortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(FireAlertMsg_Rcv_PortType),
            typeof(__messagetype_QueueSender_FireEvent),
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
            typeof(QueueSender.__messagetype_QueueSender_FireEvent)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class FireAlertMsg_Q_Snd_PortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public FireAlertMsg_Q_Snd_PortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public FireAlertMsg_Q_Snd_PortType(FireAlertMsg_Q_Snd_PortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            FireAlertMsg_Q_Snd_PortType p = new FireAlertMsg_Q_Snd_PortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(FireAlertMsg_Q_Snd_PortType),
            typeof(__messagetype_QueueSender_FireEvent),
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
            typeof(QueueSender.__messagetype_QueueSender_FireEvent)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class QReceiverOrch_FireEvent_Rcv_PortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public QReceiverOrch_FireEvent_Rcv_PortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public QReceiverOrch_FireEvent_Rcv_PortType(QReceiverOrch_FireEvent_Rcv_PortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            QReceiverOrch_FireEvent_Rcv_PortType p = new QReceiverOrch_FireEvent_Rcv_PortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(QReceiverOrch_FireEvent_Rcv_PortType),
            typeof(__messagetype_QueueSender_FireEvent),
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
            typeof(QueueSender.__messagetype_QueueSender_FireEvent)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class QReceiverOrch_FireEvent_92610_Snd_PortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public QReceiverOrch_FireEvent_92610_Snd_PortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public QReceiverOrch_FireEvent_92610_Snd_PortType(QReceiverOrch_FireEvent_92610_Snd_PortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            QReceiverOrch_FireEvent_92610_Snd_PortType p = new QReceiverOrch_FireEvent_92610_Snd_PortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(QReceiverOrch_FireEvent_92610_Snd_PortType),
            typeof(__messagetype_QueueSender_FireEvent),
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
            typeof(QueueSender.__messagetype_QueueSender_FireEvent)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class QReceiverOrch_FireEvent_92708_Snd_PortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public QReceiverOrch_FireEvent_92708_Snd_PortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public QReceiverOrch_FireEvent_92708_Snd_PortType(QReceiverOrch_FireEvent_92708_Snd_PortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            QReceiverOrch_FireEvent_92708_Snd_PortType p = new QReceiverOrch_FireEvent_92708_Snd_PortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(QReceiverOrch_FireEvent_92708_Snd_PortType),
            typeof(__messagetype_QueueSender_FireEvent),
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
    //#line 172 "C:\Projects\Apress\Chapters\Chapter12\QueueServices Solution\QueueSender\QSenderOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "FireAlertMsg_Rcv_Port", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(QueueSender.FireAlertMsg_Rcv_PortType),
            typeof(QueueSender.FireAlertMsg_Q_Snd_PortType)
        },
        new System.String[] {
            "FireAlertMsg_Rcv_Port",
            "FireAlertMsg_Q_Snd_Port"
        },
        new System.Type[] {
            null,
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
    sealed internal class QSenderOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(QSenderOrch));
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

        static QSenderOrch()
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
            _rootContext = new __QSenderOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public QSenderOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "QSenderOrch", tracker)
        {
            ConstructorHelper();
        }

        public QSenderOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "QSenderOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>e51df31a-a4f9-4c52-a750-0ab20db54076</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>b21de1b2-86be-4c35-85c7-ad5b53b2a002</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_FireAlertMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>55809969-21ce-4485-87b8-4cab101fba7e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Debug</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>15adfe33-ba21-48f7-924e-d2b3d14d7542</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Construct MsUpdated</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>d7220e66-7673-46ad-8212-d77ea758d36a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ab6cd4e9-deae-41d0-a9b8-421916e700da</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f8f29da8-986f-447a-b4a8-6ec141b90261</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Debug</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d3194361-2024-49ab-b0b2-6e7474c5e87f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_FireAlertMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'QSenderOrch'</ActionName><IsAtomic>0</IsAtomic><Line>172</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>183</Line><Position>22</Position><ShapeID>'b21de1b2-86be-4c35-85c7-ad5b53b2a002'</ShapeID>
<Messages>
	<MsgInfo><name>Msg</name><part>part</part><schema>QueueSender.FireEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>185</Line><Position>47</Position><ShapeID>'55809969-21ce-4485-87b8-4cab101fba7e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>187</Line><Position>13</Position><ShapeID>'15adfe33-ba21-48f7-924e-d2b3d14d7542'</ShapeID>
<Messages>
	<MsgInfo><name>MsgUpdated</name><part>part</part><schema>QueueSender.FireEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>196</Line><Position>47</Position><ShapeID>'f8f29da8-986f-447a-b4a8-6ec141b90261'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>198</Line><Position>13</Position><ShapeID>'d3194361-2024-49ab-b0b2-6e7474c5e87f'</ShapeID>
<Messages>
	<MsgInfo><name>MsgUpdated</name><part>part</part><schema>QueueSender.FireEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='30e095ad-61f3-4a13-b43a-3d526eb20662' LowerBound='1.1' HigherBound='49.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='QueueSender' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='c54b1519-ad3b-452d-84b8-e5b7262fde06' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FireAlertMsg_Rcv_PortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='0228b3e2-c62d-44c7-9070-61ff8494f65a' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='53fb6396-d937-459b-b326-105498189782' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='QueueSender.FireEvent' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='eac15878-a655-4234-91a1-1e5dc0c26f5a' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FireAlertMsg_Q_Snd_PortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='05819a56-4413-4a28-85bf-bab256fc32d0' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='e10d0d97-0f18-440f-bc04-8a81750bb74a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.22'>
                    <om:Property Name='Ref' Value='QueueSender.FireEvent' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='4da32933-021e-47de-849a-d3a11619ba29' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='48.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='QSenderOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='b3cf48f9-858b-4271-b70e-e8de3f0be34f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='QueueSender.FireEvent' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='52cc9a5f-3cd5-4260-af32-652f51b4a5b1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='QueueSender.FireEvent' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgUpdated' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e51df31a-a4f9-4c52-a750-0ab20db54076' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='b21de1b2-86be-4c35-85c7-ad5b53b2a002' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='FireAlertMsg_Rcv_Port' />
                    <om:Property Name='MessageName' Value='Msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_FireAlertMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='55809969-21ce-4485-87b8-4cab101fba7e' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='33.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.Debug.WriteLine(&quot;Received a message in QSenderOrch.&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Debug' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='15adfe33-ba21-48f7-924e-d2b3d14d7542' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='42.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Construct MsUpdated' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='d7220e66-7673-46ad-8212-d77ea758d36a' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='41.1'>
                        <om:Property Name='Expression' Value='MsgUpdated = Msg;&#xD;&#xA;MsgUpdated(*) = Msg(*);&#xD;&#xA;//MsgUpdated(SBMessaging.SessionId) = Msg.ZipCode;&#xD;&#xA;//System.Diagnostics.Debug.WriteLine(&quot;Set Session ID:&quot; + Msg.ZipCode);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='ab6cd4e9-deae-41d0-a9b8-421916e700da' ParentLink='Construct_MessageRef' LowerBound='34.23' HigherBound='34.33'>
                        <om:Property Name='Ref' Value='MsgUpdated' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='f8f29da8-986f-447a-b4a8-6ec141b90261' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='44.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.Debug.WriteLine(&quot;About to send out to a Queue.&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Debug' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='d3194361-2024-49ab-b0b2-6e7474c5e87f' ParentLink='ServiceBody_Statement' LowerBound='44.1' HigherBound='46.1'>
                    <om:Property Name='PortName' Value='FireAlertMsg_Q_Snd_Port' />
                    <om:Property Name='MessageName' Value='MsgUpdated' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_FireAlertMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='725d46ec-028c-4c07-b2a0-640f758fdb34' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='QueueSender.FireAlertMsg_Rcv_PortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FireAlertMsg_Rcv_Port' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='64e6b242-b79d-4ca3-9d40-8aa2f38017dd' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='738f7920-3e25-47e8-a69d-e6329b1c1f27' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='QueueSender.FireAlertMsg_Q_Snd_PortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FireAlertMsg_Q_Snd_Port' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='0671488b-00ba-4b03-ae78-7643a2baef31' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __QSenderOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __QSenderOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "QSenderOrch")
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
                QSenderOrch __svc__ = (QSenderOrch)_service;
                __QSenderOrch_root_0 __ctx0__ = (__QSenderOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.FireAlertMsg_Q_Snd_Port != null)
                {
                    __svc__.FireAlertMsg_Q_Snd_Port.Close(this, null);
                    __svc__.FireAlertMsg_Q_Snd_Port = null;
                }
                if (__svc__.FireAlertMsg_Rcv_Port != null)
                {
                    __svc__.FireAlertMsg_Rcv_Port.Close(this, null);
                    __svc__.FireAlertMsg_Rcv_Port = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __QSenderOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __QSenderOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "QSenderOrch")
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
                QSenderOrch __svc__ = (QSenderOrch)_service;
                __QSenderOrch_1 __ctx1__ = (__QSenderOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg);
                    __ctx1__.__Msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__MsgUpdated != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgUpdated);
                    __ctx1__.__MsgUpdated = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg")]
            public __messagetype_QueueSender_FireEvent __Msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgUpdated")]
            public __messagetype_QueueSender_FireEvent __MsgUpdated;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("FireAlertMsg_Rcv_Port")]
        internal FireAlertMsg_Rcv_PortType FireAlertMsg_Rcv_Port;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("FireAlertMsg_Q_Snd_Port")]
        internal FireAlertMsg_Q_Snd_PortType FireAlertMsg_Q_Snd_Port;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FireAlertMsg_Rcv_PortType.Operation_1},
                                               typeof(QSenderOrch).GetField("FireAlertMsg_Rcv_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(QSenderOrch), "FireAlertMsg_Rcv_Port"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FireAlertMsg_Q_Snd_PortType.Operation_1},
                                               typeof(QSenderOrch).GetField("FireAlertMsg_Q_Snd_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(QSenderOrch), "FireAlertMsg_Q_Snd_Port"),
                                               null)
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b21de1b2-86be-4c35-85c7-ad5b53b2a002", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "b21de1b2-86be-4c35-85c7-ad5b53b2a002", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "55809969-21ce-4485-87b8-4cab101fba7e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "55809969-21ce-4485-87b8-4cab101fba7e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "15adfe33-ba21-48f7-924e-d2b3d14d7542", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "15adfe33-ba21-48f7-924e-d2b3d14d7542", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "f8f29da8-986f-447a-b4a8-6ec141b90261", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "f8f29da8-986f-447a-b4a8-6ec141b90261", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "d3194361-2024-49ab-b0b2-6e7474c5e87f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "d3194361-2024-49ab-b0b2-6e7474c5e87f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,6,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __QSenderOrch_root_0 __ctx0__ = (__QSenderOrch_root_0)_stateMgrs[0];
            __QSenderOrch_1 __ctx1__ = (__QSenderOrch_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                FireAlertMsg_Rcv_Port = new FireAlertMsg_Rcv_PortType(0, this);
                FireAlertMsg_Q_Snd_Port = new FireAlertMsg_Q_Snd_PortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], FireAlertMsg_Rcv_Port, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __QSenderOrch_1(this);
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
            __QSenderOrch_root_0 __ctx0__ = (__QSenderOrch_root_0)_stateMgrs[0];
            __QSenderOrch_1 __ctx1__ = (__QSenderOrch_1)_stateMgrs[1];

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
                if (!FireAlertMsg_Rcv_Port.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg);
                __ctx1__.__Msg = new __messagetype_QueueSender_FireEvent("Msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg);
                FireAlertMsg_Rcv_Port.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (FireAlertMsg_Rcv_Port != null)
                {
                    FireAlertMsg_Rcv_Port.Close(__ctx1__, __seg__);
                    FireAlertMsg_Rcv_Port = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg);
                    __edata.PortName = @"FireAlertMsg_Rcv_Port";
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
                System.Diagnostics.Debug.WriteLine("Received a message in QSenderOrch.");
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
                {
                    __messagetype_QueueSender_FireEvent __MsgUpdated = new __messagetype_QueueSender_FireEvent("MsgUpdated", __ctx1__);

                    __MsgUpdated.CopyFrom(__ctx1__.__Msg);
                    __MsgUpdated.CopyContextPropertiesFrom(__ctx1__.__Msg);
                    if (__ctx1__ != null && __ctx1__.__Msg != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Msg);
                        __ctx1__.__Msg = null;
                    }

                    if (__ctx1__.__MsgUpdated != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MsgUpdated);
                    __ctx1__.__MsgUpdated = __MsgUpdated;
                    __ctx1__.RefMessage(__ctx1__.__MsgUpdated);
                }
                __ctx1__.__MsgUpdated.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MsgUpdated);
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                System.Diagnostics.Debug.WriteLine("About to send out to a Queue.");
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                FireAlertMsg_Q_Snd_Port.SendMessage(0, __ctx1__.__MsgUpdated, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (FireAlertMsg_Q_Snd_Port != null)
                {
                    FireAlertMsg_Q_Snd_Port.Close(__ctx1__, __seg__);
                    FireAlertMsg_Q_Snd_Port = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MsgUpdated);
                    __edata.PortName = @"FireAlertMsg_Q_Snd_Port";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MsgUpdated != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgUpdated);
                    __ctx1__.__MsgUpdated = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 21;
            case 21:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 224 "C:\Projects\Apress\Chapters\Chapter12\QueueServices Solution\QueueSender\QReceiverOrch.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "QReceiverOrch_FireEvent_Rcv_Port", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(QueueSender.QReceiverOrch_FireEvent_Rcv_PortType),
            typeof(QueueSender.QReceiverOrch_FireEvent_92610_Snd_PortType),
            typeof(QueueSender.QReceiverOrch_FireEvent_92708_Snd_PortType)
        },
        new System.String[] {
            "QReceiverOrch_FireEvent_Rcv_Port",
            "QReceiverOrch_FireEvent_92610_Snd_Port",
            "QReceiverOrch_FireEvent_92708_Snd_Port"
        },
        new System.Type[] {
            null,
            null,
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
    sealed internal class QReceiverOrch : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(QReceiverOrch));
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

        static QReceiverOrch()
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
            _rootContext = new __QReceiverOrch_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public QReceiverOrch(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "QReceiverOrch", tracker)
        {
            ConstructorHelper();
        }

        public QReceiverOrch(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "QReceiverOrch")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>e609f42b-7ece-4372-8e33-80f5082dbc32</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>883bd956-e99e-4c19-ac4d-90c46daaae7f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_FireEvent</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7690c7dc-5a9f-4fcb-9c0f-224b93a4815c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Debug</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>04dc61be-afac-4c05-ad91-ccfb6718afc9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>148843c8-fab1-4880-a1b0-70150c77b472</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>92610</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f95ed5c4-43d4-481d-89f2-525b5ee4fbca</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Debug</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>f5bfeaf2-679e-4eeb-9d4e-a7760ef6aaee</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_92610</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5b3c166f-2495-40b7-a9a8-4c897cc3e80b</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a78de76f-6c5b-49ce-a593-6668a911923d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Debug</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e38d96d3-c566-42c6-9fc7-369c6de70963</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_92708</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'QReceiverOrch'</ActionName><IsAtomic>0</IsAtomic><Line>224</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>236</Line><Position>22</Position><ShapeID>'883bd956-e99e-4c19-ac4d-90c46daaae7f'</ShapeID>
<Messages>
	<MsgInfo><name>Msg</name><part>part</part><schema>QueueSender.FireEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>238</Line><Position>47</Position><ShapeID>'7690c7dc-5a9f-4fcb-9c0f-224b93a4815c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>240</Line><Position>13</Position><ShapeID>'04dc61be-afac-4c05-ad91-ccfb6718afc9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>243</Line><Position>51</Position><ShapeID>'f95ed5c4-43d4-481d-89f2-525b5ee4fbca'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>245</Line><Position>17</Position><ShapeID>'f5bfeaf2-679e-4eeb-9d4e-a7760ef6aaee'</ShapeID>
<Messages>
	<MsgInfo><name>Msg</name><part>part</part><schema>QueueSender.FireEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>250</Line><Position>51</Position><ShapeID>'a78de76f-6c5b-49ce-a593-6668a911923d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>252</Line><Position>17</Position><ShapeID>'e38d96d3-c566-42c6-9fc7-369c6de70963'</ShapeID>
<Messages>
	<MsgInfo><name>Msg</name><part>part</part><schema>QueueSender.FireEvent</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ea258b5e-f290-46d8-8f1d-4918768909c1' LowerBound='1.1' HigherBound='59.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='QueueSender' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='cbbd4c66-ada4-4570-98dc-54236210a84d' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='QReceiverOrch_FireEvent_Rcv_PortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a802fbee-bfb0-489c-9abc-1941afc7a2ac' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ea43709b-d8ed-4741-98a9-3468b58b3510' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='QueueSender.FireEvent' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='1a378b69-d859-4dff-96d9-c136a614fdee' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='QReceiverOrch_FireEvent_92610_Snd_PortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fc05f8f5-170d-4d5c-a51c-ebbc94a9f09e' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='a42e1342-b21b-4fad-9847-e081e67dc0a7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.22'>
                    <om:Property Name='Ref' Value='QueueSender.FireEvent' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='d37d89a6-7b85-4287-a16e-5cf689ea8623' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='QReceiverOrch_FireEvent_92708_Snd_PortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3fd03e7d-d2eb-4318-8a7c-5cc7ed115eec' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='05f71488-e429-4a57-9686-4cc87710dbad' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.22'>
                    <om:Property Name='Ref' Value='QueueSender.FireEvent' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='08d89bf5-1487-487b-a349-c12ca1ae41bb' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='58.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='QReceiverOrch' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='6214b00e-eb48-4175-929c-a81712ea76bb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='QueueSender.FireEvent' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e609f42b-7ece-4372-8e33-80f5082dbc32' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='883bd956-e99e-4c19-ac4d-90c46daaae7f' ParentLink='ServiceBody_Statement' LowerBound='37.1' HigherBound='39.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='QReceiverOrch_FireEvent_Rcv_Port' />
                    <om:Property Name='MessageName' Value='Msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_FireEvent' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='7690c7dc-5a9f-4fcb-9c0f-224b93a4815c' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='41.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.Debug.WriteLine(&quot;Received a message in QReceiverOrch.&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Debug' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='04dc61be-afac-4c05-ad91-ccfb6718afc9' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='56.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='148843c8-fab1-4880-a1b0-70150c77b472' ParentLink='ReallyComplexStatement_Branch' LowerBound='42.13' HigherBound='49.1'>
                        <om:Property Name='Expression' Value='Msg(QueueSender.PropertySchema.ZipCode) == &quot;92610&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='92610' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='f95ed5c4-43d4-481d-89f2-525b5ee4fbca' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='46.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.Debug.WriteLine(&quot;BrokeredMessage .... 92610.&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Debug' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Send' OID='f5bfeaf2-679e-4eeb-9d4e-a7760ef6aaee' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='48.1'>
                            <om:Property Name='PortName' Value='QReceiverOrch_FireEvent_92610_Snd_Port' />
                            <om:Property Name='MessageName' Value='Msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_92610' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='5b3c166f-2495-40b7-a9a8-4c897cc3e80b' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='a78de76f-6c5b-49ce-a593-6668a911923d' ParentLink='ComplexStatement_Statement' LowerBound='51.1' HigherBound='53.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.Debug.WriteLine(&quot;BrokerdMessage 92708.&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Debug' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Send' OID='e38d96d3-c566-42c6-9fc7-369c6de70963' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='55.1'>
                            <om:Property Name='PortName' Value='QReceiverOrch_FireEvent_92708_Snd_Port' />
                            <om:Property Name='MessageName' Value='Msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_92708' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='eacb0f6c-1193-4623-84b4-a4a9b36e1fd7' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='QueueSender.QReceiverOrch_FireEvent_Rcv_PortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='QReceiverOrch_FireEvent_Rcv_Port' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e63d0617-88a5-4b7d-966e-d1355a2dcaad' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d85aafc8-1242-472d-9308-7dbed5b1ed4a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='QueueSender.QReceiverOrch_FireEvent_92610_Snd_PortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='QReceiverOrch_FireEvent_92610_Snd_Port' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8f50229e-2efd-440f-bb9e-01f8bc0a0a02' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='72dd1a49-8611-4518-8dc6-1c7ee2c2a65e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='7' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='QueueSender.QReceiverOrch_FireEvent_92708_Snd_PortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='QReceiverOrch_FireEvent_92708_Snd_Port' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='3bbef182-2fed-4fab-987b-d0d3070a4061' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __QReceiverOrch_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __QReceiverOrch_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "QReceiverOrch")
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
                QReceiverOrch __svc__ = (QReceiverOrch)_service;
                __QReceiverOrch_root_0 __ctx0__ = (__QReceiverOrch_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.QReceiverOrch_FireEvent_Rcv_Port != null)
                {
                    __svc__.QReceiverOrch_FireEvent_Rcv_Port.Close(this, null);
                    __svc__.QReceiverOrch_FireEvent_Rcv_Port = null;
                }
                if (__svc__.QReceiverOrch_FireEvent_92708_Snd_Port != null)
                {
                    __svc__.QReceiverOrch_FireEvent_92708_Snd_Port.Close(this, null);
                    __svc__.QReceiverOrch_FireEvent_92708_Snd_Port = null;
                }
                if (__svc__.QReceiverOrch_FireEvent_92610_Snd_Port != null)
                {
                    __svc__.QReceiverOrch_FireEvent_92610_Snd_Port.Close(this, null);
                    __svc__.QReceiverOrch_FireEvent_92610_Snd_Port = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __QReceiverOrch_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __QReceiverOrch_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "QReceiverOrch")
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
                QReceiverOrch __svc__ = (QReceiverOrch)_service;
                __QReceiverOrch_1 __ctx1__ = (__QReceiverOrch_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg);
                    __ctx1__.__Msg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg")]
            public __messagetype_QueueSender_FireEvent __Msg;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("QReceiverOrch_FireEvent_Rcv_Port")]
        internal QReceiverOrch_FireEvent_Rcv_PortType QReceiverOrch_FireEvent_Rcv_Port;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("QReceiverOrch_FireEvent_92610_Snd_Port")]
        internal QReceiverOrch_FireEvent_92610_Snd_PortType QReceiverOrch_FireEvent_92610_Snd_Port;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("QReceiverOrch_FireEvent_92708_Snd_Port")]
        internal QReceiverOrch_FireEvent_92708_Snd_PortType QReceiverOrch_FireEvent_92708_Snd_Port;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {QReceiverOrch_FireEvent_Rcv_PortType.Operation_1},
                                               typeof(QReceiverOrch).GetField("QReceiverOrch_FireEvent_Rcv_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(QReceiverOrch), "QReceiverOrch_FireEvent_Rcv_Port"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {QReceiverOrch_FireEvent_92610_Snd_PortType.Operation_1},
                                               typeof(QReceiverOrch).GetField("QReceiverOrch_FireEvent_92610_Snd_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(QReceiverOrch), "QReceiverOrch_FireEvent_92610_Snd_Port"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {QReceiverOrch_FireEvent_92708_Snd_PortType.Operation_1},
                                               typeof(QReceiverOrch).GetField("QReceiverOrch_FireEvent_92708_Snd_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(QReceiverOrch), "QReceiverOrch_FireEvent_92708_Snd_Port"),
                                               null)
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
                h[_portInfo[2].Name] = _portInfo[2];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "883bd956-e99e-4c19-ac4d-90c46daaae7f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "883bd956-e99e-4c19-ac4d-90c46daaae7f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "7690c7dc-5a9f-4fcb-9c0f-224b93a4815c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "7690c7dc-5a9f-4fcb-9c0f-224b93a4815c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "04dc61be-afac-4c05-ad91-ccfb6718afc9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f95ed5c4-43d4-481d-89f2-525b5ee4fbca", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "f95ed5c4-43d4-481d-89f2-525b5ee4fbca", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "f5bfeaf2-679e-4eeb-9d4e-a7760ef6aaee", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f5bfeaf2-679e-4eeb-9d4e-a7760ef6aaee", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a78de76f-6c5b-49ce-a593-6668a911923d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a78de76f-6c5b-49ce-a593-6668a911923d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "e38d96d3-c566-42c6-9fc7-369c6de70963", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "e38d96d3-c566-42c6-9fc7-369c6de70963", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "04dc61be-afac-4c05-ad91-ccfb6718afc9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "00000000-0000-0000-0000-000000000000", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,15,15,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,4,5,5,6,6,7,8,8,8,9,5,10,10,11,12,12,12,13,14,15,15,15,15,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __QReceiverOrch_1 __ctx1__ = (__QReceiverOrch_1)_stateMgrs[1];
            __QReceiverOrch_root_0 __ctx0__ = (__QReceiverOrch_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                QReceiverOrch_FireEvent_Rcv_Port = new QReceiverOrch_FireEvent_Rcv_PortType(0, this);
                QReceiverOrch_FireEvent_92610_Snd_Port = new QReceiverOrch_FireEvent_92610_Snd_PortType(1, this);
                QReceiverOrch_FireEvent_92708_Snd_Port = new QReceiverOrch_FireEvent_92708_Snd_PortType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], QReceiverOrch_FireEvent_Rcv_Port, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __QReceiverOrch_1(this);
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
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __QReceiverOrch_1 __ctx1__ = (__QReceiverOrch_1)_stateMgrs[1];
            __QReceiverOrch_root_0 __ctx0__ = (__QReceiverOrch_root_0)_stateMgrs[0];

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
                if (!QReceiverOrch_FireEvent_Rcv_Port.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg);
                __ctx1__.__Msg = new __messagetype_QueueSender_FireEvent("Msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg);
                QReceiverOrch_FireEvent_Rcv_Port.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (QReceiverOrch_FireEvent_Rcv_Port != null)
                {
                    QReceiverOrch_FireEvent_Rcv_Port.Close(__ctx1__, __seg__);
                    QReceiverOrch_FireEvent_Rcv_Port = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg);
                    __edata.PortName = @"QReceiverOrch_FireEvent_Rcv_Port";
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
                System.Diagnostics.Debug.WriteLine("Received a message in QReceiverOrch.");
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
                __condition__ = (System.String)__ctx1__.__Msg.GetPropertyValueThrows(typeof(QueueSender.PropertySchema.ZipCode)) == "92610";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 18;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                System.Diagnostics.Debug.WriteLine("BrokeredMessage .... 92610.");
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                QReceiverOrch_FireEvent_92610_Snd_Port.SendMessage(0, __ctx1__.__Msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg);
                    __edata.PortName = @"QReceiverOrch_FireEvent_92610_Snd_Port";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                System.Diagnostics.Debug.WriteLine("BrokerdMessage 92708.");
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                QReceiverOrch_FireEvent_92708_Snd_Port.SendMessage(0, __ctx1__.__Msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg);
                    __edata.PortName = @"QReceiverOrch_FireEvent_92708_Snd_Port";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg);
                    __ctx1__.__Msg = null;
                }
                if (QReceiverOrch_FireEvent_92708_Snd_Port != null)
                {
                    QReceiverOrch_FireEvent_92708_Snd_Port.Close(__ctx1__, __seg__);
                    QReceiverOrch_FireEvent_92708_Snd_Port = null;
                }
                if (QReceiverOrch_FireEvent_92610_Snd_Port != null)
                {
                    QReceiverOrch_FireEvent_92610_Snd_Port.Close(__ctx1__, __seg__);
                    QReceiverOrch_FireEvent_92610_Snd_Port = null;
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 29;
            case 29:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __QueueSender_FireEvent__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static QueueSender.FireEvent _schema = new QueueSender.FireEvent();

        public __QueueSender_FireEvent__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "QueueSender.FireEvent",
        new System.Type[]{
            typeof(QueueSender.FireEvent)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__QueueSender_FireEvent__)
        },
        0,
        @"http://EventConsumerProj.FireEvent#FireEvent"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_QueueSender_FireEvent : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __QueueSender_FireEvent__ part;

        private void __CreatePartWrappers()
        {
            part = new __QueueSender_FireEvent__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_QueueSender_FireEvent(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
