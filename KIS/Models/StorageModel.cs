using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KIS.Models
{
    [Table("Storage")]
    public class StorageModel
    {
        [Key]
        [Column("ID")]
        public int StorageID { get; set; }
        [Column("PositionID")]
        public int PositionID { get; set; }  // Внешний ключ на таблицу BOM
        [Column("dateAndTime")]
        public DateTime DateAndTime { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("typeOfOperation")]
        public string TypeOfOperation { get; set; }

        // Навигационное свойство для связи с таблицей BOM
        //[ForeignKey("SpecificationID")]  // Указываем, что это внешний ключ
        //public BOMModel BOM { get; set; }


    }
}
