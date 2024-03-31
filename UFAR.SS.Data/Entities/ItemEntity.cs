using System.ComponentModel.DataAnnotations;

namespace UFAR.SS.Data.Entities
{
    public class ItemEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<StyleEntity> Styles { get; set; }
        public bool isSculture = true;
    }
}
