using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KIS.Models
{
    [Table("Specification")]
    public class SpecificationModel
    {
        [Key]
        [Column("positionID")]
        public int PositionID { get; set; }

        [Column("parentID")]
        public int? ParentID { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("quantityPerParent")]
        public int QuantityPerParent { get; set; }

        [Column("unitMeasurement")]
        public string UnitMeasurement { get; set; }

        //[foreignkey("parentid")] // указание внешнего ключа
        //[jsonignore] // игнорирование свойства при сериализации json, чтобы избежать циклических ссылок
        //public bommodel parentbom { get; set; }

        //[jsonignore] // игнорирование свойства при сериализации json для того же решения
        //public icollection<bommodel> childboms { get; set; }
    }
}

