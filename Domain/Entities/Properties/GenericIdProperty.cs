using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Properties
{
    public class GenericIdProperty
    {
        [Key]
        public int Id { get; set; }
    }
}