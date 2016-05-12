using Remotion.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToCypher
{

    /// <summary>
    /// Executes parsed linq queries in Cypher. Remotion calls these methods for us. First, QueryableBase parses
    /// linq expressions to construct a QueryModel. Then it passes the query model to the appropriate function in 
    /// this class.
    /// </summary>
    public class CypherExecutor : IQueryExecutor
    {
        public IEnumerable<T> ExecuteCollection<T>(QueryModel queryModel)
        {
            // This method needs to 
            // 1) Transform the queryModel into a cypher query
            // 2) Post the query to neo4j
            // 3) Turn the response into an IEnumerable<T>
            return new T[0];
        }

        // ExecuteSingle is a special case of ExecuteCollection where we 
        // happen to know that there is one element in the result set.
        public T ExecuteSingle<T>(QueryModel queryModel, bool returnDefaultWhenEmpty)
        {
            var result = ExecuteCollection<T>(queryModel);
            return returnDefaultWhenEmpty ? result.SingleOrDefault() : result.Single();
        }
        public T ExecuteScalar<T>(QueryModel queryModel)
        {
            // Open question: Can this use the same code path as ExecuteSingle?
            throw new NotImplementedException();
        }

    }
}
