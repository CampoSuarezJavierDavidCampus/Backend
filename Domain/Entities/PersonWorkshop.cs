using Domain.Entities.Properties;

namespace Domain.Entities;
public class PersonWorkshop{
    public Workshop? Workshop { get; set; }
    public Person? Person { get; set; }
}