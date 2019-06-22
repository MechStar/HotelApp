using System.Web.Mvc;

namespace HotelApp.Filters
{
    public class LogAndHandleErrorAttribute : HandleErrorAttribute
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public override void OnException(ExceptionContext filterContext)
        {
            Logger.Error(filterContext.Exception);

            base.OnException(filterContext);
        }
    }
}
