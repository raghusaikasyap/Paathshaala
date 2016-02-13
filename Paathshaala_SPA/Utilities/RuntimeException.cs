using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class RuntimeException
    {        
        private static readonly ILog logger = LogManager.GetLogger(typeof(RuntimeException));
        
        public static void LogExceptionWithSource(Exception exceptionSource)
        {
            logger.Error(exceptionSource.Message + "\n Source :" + exceptionSource.Source + "\n Stack trace : " + exceptionSource.StackTrace);
        }

        public static void LogExceptionWithSource(Exception exceptionSource, string message)
        {
            logger.Error(message);
            logger.Error(exceptionSource.Message + "\n Source :" + exceptionSource.Source + "\n Stack trace : " + exceptionSource.StackTrace);
        }
    }
}
