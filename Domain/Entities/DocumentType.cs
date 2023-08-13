using Domain.Entities.Properties;

namespace Domain.Entities;
public class DocumentType:GenericDescriptionProperty{
    public ICollection<Person>? Persons { get; set; }
}