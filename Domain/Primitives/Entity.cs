using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public class Entity
    {
        protected Entity() { }
        protected Entity(Guid id) => this.Id = id;

        public Guid Id { get; protected set; }
    }
}
