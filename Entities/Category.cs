using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Doan.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get;set; }
        public string Name { get; set; }

    
        //foreign key
        public virtual IEnumerable<GeneralProduct> GeneralProducts { get; set; }
    }
}
