using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WordwiseLibrary.Models;

namespace WordwiseLibrary
{
    public static class GlobalConfig
    {
        public static string DBConnString()
        {
            //return ConfigurationManager.
            return "postgres://sudo-datluu:G6sgrDIyiY1P@ep-plain-pond-580166.ap-southeast-1.aws.neon.tech/wordwise";
        }
    }
}
