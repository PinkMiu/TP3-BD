namespace TP3_ORM.DataAccessLayer
{
    internal class IndexAnnotation
    {
        private IndexAttribute[] indexAttribute;

        public IndexAnnotation(IndexAttribute[] indexAttribute)
        {
            this.indexAttribute = indexAttribute;
        }
    }
}