namespace StoreApp.Services
{
    using StoreApp.Data;

    public abstract class Service
    {
        public Service()
        {
            this.Context = new StoreAppContext();
        }
        protected StoreAppContext Context { get; }
    }
}
