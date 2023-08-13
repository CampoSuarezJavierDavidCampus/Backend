using Domain.Entities.Properties;

namespace Domain.Entities;
public class ServiceTypeArea{
    public int IdArea { get; set; }
    public Area? Area { get; set; }

    public int IdSeviceType { get; set; }
    public ServiceType? ServiceType { get; set; }
}