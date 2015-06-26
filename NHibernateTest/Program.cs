using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateTest.Models;
using NHibernateTest.Mapping;
using System.Collections;

namespace NHibernateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sessionFactory = NHibernateConfigurator.CreateSessionFactory();

            //using (var session = NHibernateConfigurator.OpenSession())
            {
                // Begin a transaction
                //using (var transaction = session.BeginTransaction())
                {
                    //var areaList = session.QueryOver<Area>().Where(x => x.CD_AREA == 1).SingleOrDefault(); // .List();// .CreateCriteria(typeof(Area)).List();
                    //Area area = session.QueryOver<Area>().Where(x => x.CD_AREA == 2).SingleOrDefault(); // .List();// .CreateCriteria(typeof(Area)).List();
                    //if(area != null)
                    //    Console.WriteLine(area.CA_AREA);

                    //area.DE_AREA = "ALLORA";

                    //Group group = session.QueryOver<Group>().Where(x => x.CdGroup == 1).SingleOrDefault(); // .List();// .CreateCriteria(typeof(Area)).List();
                    Group group = Group.GetGroup(1, "connectionString");
                    //Group group = new Group(1);
                    if (group != null)
                    {
                        Console.WriteLine("Gruppo : " + group.CaGroup);
                        //group.CaGroup = group.CaGroup + "123";
                        //group.Save();
                    }


                    //area = new Area { CA_AREA = "PROVA", DE_AREA = "PROVA", FL_DELETE = 0 };

                    //session.SaveOrUpdate(area);

                    //IList<Area> areaList = session.QueryOver<Area>().List();
                    //foreach (Area item in areaList)
                    //    Console.WriteLine(item.CA_AREA);

                    //transaction.Commit();    
                }
            }

            Console.WriteLine("Fine");
            Console.ReadKey();
        }
    }
}
