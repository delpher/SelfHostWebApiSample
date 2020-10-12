using System.Collections.Generic;
using System.Web.Http;

namespace SelfHostApiSample
{
    namespace OwinSelfhostSample
    {
        public class ValuesController : ApiController
        {
            private readonly IValuesRepository repository;

            public ValuesController(IValuesRepository repository)
            {
                this.repository = repository;
            }

            public IEnumerable<string> Get()
            {
                return this.repository.GetValues();
            }
        }
    }
}
