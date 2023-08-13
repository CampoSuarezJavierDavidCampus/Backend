using Domain.Entities.Properties;

namespace Domain.Entities;
public class ServiceType: GenericDescriptionProperty{
    public IEnumerable<ServiceTypeArea>? ServiceTypeAreas { get; set; }    
}