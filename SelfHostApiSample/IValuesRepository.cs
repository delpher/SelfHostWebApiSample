using System.Collections.Generic;

namespace SelfHostApiSample
{
    public interface IValuesRepository
    {
        IEnumerable<string> GetValues();
    }
}
