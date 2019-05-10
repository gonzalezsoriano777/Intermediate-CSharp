using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{

    public class DbMigratorv2
    {
        // created a private field that will be used for the migration of the database
        private readonly ILogger _logger;


        public DbMigratorv2(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // the purpose of this practice is that we work w/ the applications behavior and be able change the way it processes
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            // Overall details of the migration of the db

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }

    }
}
