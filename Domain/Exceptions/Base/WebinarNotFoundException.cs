using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions.Base
{
    public sealed class WebinarNotFoundException : Exception
    {
        public WebinarNotFoundException(Guid webinarId):base($"The webinar with the identifier {webinarId} was not found.") { }
    }
}
