using Domain.Entities.Properties;

namespace Domain.Entities;
public class ContactPerson: GenericDescriptionProperty{
    public int IdPersona { get; set; }
    public Person? Person { get; set; }
}