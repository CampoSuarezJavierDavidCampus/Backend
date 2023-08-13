using Domain.Entities.Properties;

namespace Domain.Entities;
public class Person: GenericLocationProperty{
    public int IdPersonType { get; set; }        
    public PersonType? PersonType{ get; set; }

    public int IdDocumentType { get; set; }        
    public DocumentType? DocumentType{ get; set; }

    public IEnumerable<PersonWorkshop>? PersonWorkshops{ get; set; }
    public IEnumerable<ContactPerson>? ContactPerson { get; set; }
    public IEnumerable<EPSContact>? EPSContacts { get; set; }
}