namespace TP3_ORM.DataAccessLayer
{
    internal class IndexAttribute
    {
        private string v;

        public IndexAttribute(string v)
        {
            this.v = v;
        }

        public bool IsUnique { get; set; }
    }
}