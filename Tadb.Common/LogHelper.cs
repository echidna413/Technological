using System;

namespace Tadb.Common
{
    public enum DbEvent
    {
        AddData,
        ImportData,
        EditData,
        DeleteData,
        AddECatalog,
        EditECatalog,
        DeleteECatalog,
        AddFCatalog,
        EditFCatalog,
        DeleteFCatalog,
        AddPCatalog,
        EditPCatalog,
        DeletePCatalog,
        AddSCatalog,
        EditSCatalog,
        DeleteSCatalog
    }

    public class LogHelper
    {
        public LogHelper()
        {
        }

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string Naming()
        {
            DateTime now = DateTime.Now;
            string naming = string.Format("{0}_{1}{2}", ApplicationData.Instance.Login, now.ToShortDateString(), now.ToLongTimeString());
            return naming;
        }

        public string ImportNaming(string filename)
        {
            DateTime now = DateTime.Now;
            string naming = string.Format("{0}_{3}_{1}{2}", ApplicationData.Instance.Login, now.ToShortDateString(), now.ToLongTimeString(), filename);
            return naming;
        }

        public void LogString(DbEvent dbEvent, string identificator)
        {
            string logString = string.Format("{0}__{1}", dbEvent, identificator);
            logger.Info(logString);
        }
    }
}