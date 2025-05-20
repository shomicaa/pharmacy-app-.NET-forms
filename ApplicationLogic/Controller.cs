namespace ApplicationLogic
{
    public class Controller
    {
        #region singleton
        private volatile static Controller instance;
        private static object _lock = new object();
        
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
        }
        #endregion
    }
}
