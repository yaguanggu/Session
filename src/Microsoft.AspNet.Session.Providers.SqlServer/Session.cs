using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Session.Providers.SqlServer
{
    public class Session
    {
        //todo:remove later: id from the session cookie
        public string Id { get; set; }

        //todo:remove later: serialized session data having both keys and their values.
        public byte[] Value { get; set; }

        public DateTimeOffset LastAccessedInUTC { get; set; }
    }
}
