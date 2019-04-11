using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Диплом
{
    class Sql
    {
        string Sql_ = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
    }
}