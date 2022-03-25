namespace MvcWebUl.Entity
{
    public class IdentityDbContext<T>
    {
        private string v;

        public IdentityDbContext(string v)
        {
            this.v = v;
        }
    }
}