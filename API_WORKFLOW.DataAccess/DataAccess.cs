using System.Web;
using System.Reflection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Cfg;
using API_WORKFLOW.DataAccess.Models;
using System.Linq.Expressions;
using System.Data.SqlClient;
namespace API_WORKFLOW.DataAccess
{
    public class DBaccess
    {

        public DBaccess() { } 

        public Usuario Conexion() {

            string ConnString = "Server=(localdb)\\MSSQLLocalDB;Database=DESA2;Trusted_Connection=True;";
            var config = new Configuration();
            //var nhConfig = new Configuration();

            //nhConfig.Configure(Assembly.GetExecutingAssembly(), "hibernate.cfg.xml");
            //var SessionFactory = nhConfig.BuildSessionFactory();
           
            //var cosas = Assembly.GetExecutingAssembly();
            config.AddAssembly(Assembly.GetExecutingAssembly());
            //config.DataBaseIntegration(d => { d.ConnectionString = ConnString; d.Dialect<MsSql2012Dialect>(); d.Driver<SqlClientDriver>(); });
            config.Configure();
            var SessionFactory = config.BuildSessionFactory( );
            
            
            using (var session = SessionFactory.OpenSession())
            {
                try{
                    var Usuario_nuevo = new Usuario { Email = "lucasnoirat@gmail.com", Password = "123456" };
                    session.Save(Usuario_nuevo);
                    return Usuario_nuevo;
                }
                catch(Exception e)
                {
                    Usuario Usuario_nuevo = new Usuario { Email = e.Message, Password = "123456" };
                    return Usuario_nuevo;
                }
            }
            



        }

    } 
}