using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCdemoBook.Models
{
    [Table("tblBooks")]
    public class BookModel
    {
       
        [Key]
        public int BookModelId { get; set; }

        public string BName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}

