using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class DbMigratorv2
    {
        private readonly ILogger _logger;

        public DbMigratorv2(ILogger logger)
        {
            _logger = logger;
        }
    }
}
