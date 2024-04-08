using System.ComponentModel.DataAnnotations;

// This namespace contains entity classes representing data entities.
namespace UFAR_SS_Data.Entities
{
    // This class represents a style entity, which contains the name of the style.
    public class StyleEntity : BaseEntity
    {
        public string Name { get; set; }
    }
}