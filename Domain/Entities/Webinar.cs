using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Webinar:Entity
    {
        public Webinar()
        {

        }
        public Webinar(Guid id,string name, DateTime scheduledOn):base(id)
        {
            this.Name = name;
            this.ScheduledOn = scheduledOn;
        }

        public string Name { get; private set; }
        public DateTime ScheduledOn { get; private set; }
    }
}
