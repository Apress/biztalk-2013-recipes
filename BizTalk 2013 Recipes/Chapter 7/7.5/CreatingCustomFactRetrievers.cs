using System.Data.SqlClient;
using Microsoft.RuleEngine;


namespace CreatingCustomFactRetrievers
{
   public class AssertDBConnection : IFactRetriever
    {
        public object UpdateFacts(RuleSetInfo ruleSetInfo,
                                  RuleEngine engine, object factsHandleIn)
        {
            object factsHandleOut;
            if (factsHandleIn == null)
            {
                SqlConnection SQLConn = new SqlConnection("Initial Catalog=Northwind;Data Source=WIN-LUNNMMJQUVE;Integrated Security=SSPI;");
                DataConnection RulesConn = new DataConnection("Northwind","Customers", SQLConn);
                engine.Assert(RulesConn);
                factsHandleOut = RulesConn;
            }
            else
                factsHandleOut = factsHandleIn;

            return factsHandleOut;
        }
   }
}
