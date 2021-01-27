using System.Collections.Generic;

namespace Template.Business
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public List<string> Categories { get; set; }
    }
}
