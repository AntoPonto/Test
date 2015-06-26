using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTest.Models
{
    public class Area : Entity
    {
        public Area() { }
        public virtual long CD_AREA { get; set; }
        public virtual string DE_AREA { get; set; }
        public virtual string CA_AREA { get; set; }
        public virtual int FL_DELETE { get; set; }       
    }
}
