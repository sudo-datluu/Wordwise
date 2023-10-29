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
            return "User ID=sudo-datluu;Password=G6sgrDIyiY1P;Host=ep-plain-pond-580166.ap-southeast-1.aws.neon.tech;Port=5432;Database=wordwise;";
        }
    }
}
