using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyline二次开发平台1._0
{
    class Log4NetHelper
    {
        public static void WriteLog(Type e, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(e);
            log.Error("Error", ex);
        }

        public static void WriteLog(Type e, string msg)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(e);
            log.Error(msg);
        }
    }
}
