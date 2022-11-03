using System.Linq;
using HotChocolate;
using GraphQL.Data;

namespace GraphQL
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context)
        {
            return context.Speakers;
        }
    }
}