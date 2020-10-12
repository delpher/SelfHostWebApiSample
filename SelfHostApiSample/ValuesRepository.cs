using System.Collections.Generic;

namespace SelfHostApiSample
{
    public class ValuesRepository : IValuesRepository
    {
        public IEnumerable<string> GetValues()
        {
            return new[] { "string1", "string2" };
        }
    }
}
