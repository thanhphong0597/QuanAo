using Doan.Entities;

namespace Doan.Models
{
    public class CategoryModel
    {   
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class ProductModel
    {
        public int Stock { get; set; }
        public string Ima { get; set; }

        public int ColorID { get; set; }
        public int ProductID { get; set; }
        public int SizeID { get; set; }

        public Color Color { get; set; }
        public GeneralProduct GeneralProduct { get; set; }
        public Size Size { get; set; }
    }
}
