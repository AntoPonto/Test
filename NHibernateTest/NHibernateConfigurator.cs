using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernateTest.Mapping;
using NHibernateTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NHibernateTest
{
    public partial class NHibernateConfigurator
    {        
        private static ISessionFactory _sessionFactory;
        private static string _tagConnectionString = "DefaulConnection";

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InizializeSessionFactory();

                return _sessionFactory;
            }
        }

        private static void InizializeSessionFactory()
        {
            IPersistenceConfigurer iPersistenceConfigurer = CreateDbConfig();

            _sessionFactory = Fluently.Configure()
                .Database(iPersistenceConfigurer)                
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Entity>())                                
                .BuildSessionFactory();            
        }

        private static MsSqlConfiguration CreateDbConfig()
        {
            string connectioString = ConfigurationManager.ConnectionStrings[_tagConnectionString].ConnectionString;

            var con = MsSqlConfiguration.MsSql2012
                .ConnectionString(connectioString);

            return con;
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static ISession OpenSession(string TagConnection)
        {
            _tagConnectionString = TagConnection;
            return SessionFactory.OpenSession();
        }
    }
}
