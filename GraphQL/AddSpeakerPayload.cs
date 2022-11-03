using GraphQL.Data;
using GraphQL.Data;
using Microsoft.EntityFrameworkCore;

namespace GraphQL
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }

        public Speaker Speaker { get; }
    }
}