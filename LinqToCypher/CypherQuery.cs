using Remotion.Linq;

namespace LinqToCypher
{
    // This is the class that transforms QueryModels into strings of Cypher.
    // Maybe it really is correct to call this class "CypherQuery" after all, it represents a Cypher Query, in the
    // literal sense of being the text that will be sent to Neo4j. 
    // Should this extend QueryModel or take one in as a parameter?
    /// <summary>
    /// Represents cypher queries
    /// </summary>
    public class CypherQuery
    {
        private string Query;

        public CypherQuery(QueryModel model)
        {
        }
    }
}
