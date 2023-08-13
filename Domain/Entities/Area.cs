using Domain.Entities.Properties;

namespace Domain.Entities;
public class Area: GenericDescriptionProperty{
    public int IdWorkshop { get; set; }
    public Workshop? Workshop { get; set; } 

    public IEnumerable<ServiceTypeArea>? ServiceTypeAreas { get; set; }
}