using Domain.Entities.Properties;

namespace Domain.Entities;
public class EPSType:GenericDescriptionProperty{
    public IEnumerable<EPSContact>? EPSContacts { get; set; }
}