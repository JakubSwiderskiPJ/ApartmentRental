namespace ApartmentRental.Core.Entities;

public class Tenant : BaseEntity
{
    public Apartment apartment { get; set; }
    
}
