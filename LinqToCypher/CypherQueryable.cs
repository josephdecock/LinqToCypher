using Remotion.Linq;
using Remotion.Linq.Parsing.Structure;
using System.Linq;
using System.Linq.Expressions;

namespace LinqToCypher
{
    /// <summary>
    /// Evaluates queries against a neo4j database using the cypher query language. 
    /// This is the high-level abstraction that users call linq methods against.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CypherQueryable<T> : QueryableBase<T>
    {
        public CypherQueryable() :
            base(QueryParser.CreateDefault(),  new CypherExecutor())
        { }

        public CypherQueryable(IQueryProvider queryProvider, Expression expression) :
            base(queryProvider, expression)
        {}
    }
}
