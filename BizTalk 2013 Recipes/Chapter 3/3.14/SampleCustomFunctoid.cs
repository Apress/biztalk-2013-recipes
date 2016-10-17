using System;
using Microsoft.BizTalk.BaseFunctoids;
using System.Reflection;

namespace SampleCustomFunctoid
{
    /// <summary>
    /// See sample solution (SampleCustomFunctoid.sln)
    /// which accompanies this recipe
    /// </summary>
    [Serializable]
    public class EncodeFunctoid : BaseFunctoid
    {
        public EncodeFunctoid()
            : base()
        {
            //Custom functoids should begin with 6000 or higher
            this.ID = 6667;

            // resource assembly reference
            SetupResourceAssembly
                ("SampleCustomFunctoid.SampleCustomFunctoidResource",
                Assembly.GetExecutingAssembly());

            //Set the properties for this functoid
            SetName("SAMPLECUSTOMFUNCTOID_NAME");
            SetTooltip("SAMPLECUSTOMFUNCTOID_TOOLTIP");
            SetDescription("SAMPLECUSTOMFUNCTOID_DESCRIPTION");
            SetBitmap("SAMPLECUSTOMFUNCTOID_BITMAP");

            // one parameter in, one parameter out
            this.SetMinParams(1);
            this.SetMaxParams(1);


            //Function code below
            SetExternalFunctionName(GetType().Assembly.FullName,
             "SampleCustomFunctoid.EncodeFunctoid", "EncodeChars");

            //Category in Toolbox where this functoid will appear
            this.Category = FunctoidCategory.String;

            //output of functoid can go to all nodes indicated
            this.OutputConnectionType = ConnectionType.All;

            // add one of the following lines of code for every input
            // parameter. All lines would be identical.
            AddInputConnectionType(ConnectionType.All);
        }


        // Actual function which does the replacement of symbols
        public string EncodeChars(String strInputValue)
        {
            strInputValue = strInputValue.Replace("&", "&amp;");
            strInputValue = strInputValue.Replace("<", "&lt;");
            strInputValue = strInputValue.Replace(">", "&gt;");

            return strInputValue;
        }
    }
}

