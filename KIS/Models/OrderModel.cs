using System.ComponentModel.DataAnnotations.Schema;

namespace KIS.Models
{
    [Table("order")]
    public class OrderModel
    {
            [Column("ID")]
            public int ID { get; set; }
            [Column("SpecificationID")]
            public int SpecificationID { get; set; }  // Внешний ключ на таблицу BOM
            [Column("orderDate")]
            public DateTime OrderDate { get; set; }
            [Column("clientName")]
            public string ClientName { get; set; }
            [Column("measureUnit")]
            public string MeasureUnit { get; set; }

        // Навигационное свойство для связи с таблицей BOM
            [ForeignKey("SpecificationID")]  // Указываем, что это внешний ключ
            public SpecificationModel Specification { get; set; }


    }
}
