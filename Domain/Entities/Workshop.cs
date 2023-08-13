using Domain.Entities.Properties;

namespace Domain.Entities;
public class Workshop: GenericLocationProperty{
    public int IdCity { get; set; }
    public City? City { get; set;}

    public IEnumerable<PersonWorkshop>? PersonWorkshops{ get; set; }
    public IEnumerable<Area>? Areas{ get; set; }

}