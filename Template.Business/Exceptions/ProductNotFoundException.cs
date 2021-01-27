namespace Template.Business.Exceptions
{
    public class ProductNotFoundException : TemplateException
    {
        public ProductNotFoundException(string message) : base(message)
        {
        }
    }
}
