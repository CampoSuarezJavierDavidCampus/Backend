using Domain.Entities.Properties;

namespace Domain.Entities;
public class PersonType: GenericDescriptionProperty{
    public ICollection<Person>? Persons { get; set; }
}