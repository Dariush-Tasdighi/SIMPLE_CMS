namespace Infrastructure
{
    public class BaseController : System.Web.Mvc.Controller
    {
        public BaseController() : base()
        {
        }

        private Models.DatabaseContext myDatabaseContext;

        public Models.DatabaseContext MydataBaseContext
        {
            get
            {
                if (myDatabaseContext == null)
                {
                    myDatabaseContext = new Models.DatabaseContext();
                }
                return myDatabaseContext;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (myDatabaseContext != null)
                {
                    myDatabaseContext.Dispose();

                    myDatabaseContext = null;
                }
            }

            base.Dispose(disposing);
        }



    }
}
