using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordwiseLibrary.Data
{
    // Connector operate database functions
    public class DBConnector
    {
        // Database context, initialize when create a connector
        protected Context _context;

        public DBConnector(Context context) { _context = context; }
    }
}
