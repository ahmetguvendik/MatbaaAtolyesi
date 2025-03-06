namespace MatbaaAtolyesi.Domain.Entities;

public class Contact : BaseEntity 
{
    public string Adres { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string TwitterLink { get; set; }
    public string FacebookLink { get; set; }
    public string InstagramLink { get; set; }   
}