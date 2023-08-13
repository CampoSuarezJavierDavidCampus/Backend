using Domain.Entities.Properties;
namespace Domain.Entities;
public class City:GenericNameProperty{
    public int IdDepartment { get; set; }
    public Department? Department { get; set; }

    public ICollection<Workshop>? workshops{ get; set; }
}