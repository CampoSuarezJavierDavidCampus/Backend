using Domain.Entities.Properties;

namespace Domain.Entities;
public class Country:GenericNameProperty{
    public ICollection<Department>? Departments { get; set; }
}
