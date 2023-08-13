namespace Domain.Entities;
public class EPSContact{
    public int IdPerson { get; set; }
    public Person? Person { get; set; }

    public int IdEPSType { get; set; }
    public EPSType? EPSType { get; set; }
    
}