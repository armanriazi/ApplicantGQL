using GraphQL;
using GraphQL.Types;

namespace GQ
{
    public class ProjectSchema : Schema
    {
        public ProjectSchema(ProjectQuery query, IDependencyResolver  resolver)
        {
            Query = query;            
            DependencyResolver = resolver;            
        }      
    }

}
