using Domain.Entities.Properties;

namespace Domain.Entities;
public class Department:GenericNameProperty{
    public int IdCountry { get; set; }
    public Country? Country { get; set; }

    public ICollection<City>? Cities{ get; set; }
}