using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTest.Models
{
    public abstract partial class Entity
    {
        public virtual long Id { get; set; }
    }
}
