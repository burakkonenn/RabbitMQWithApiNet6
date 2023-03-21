using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RabbitMQWithApiNet6.Model
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string ProductDescription
        {
            get;
            set;
        }
        public int ProductPrice
        {
            get;
            set;
        }
        public int ProductStock
        {
            get;
            set;
        }
    }
}
