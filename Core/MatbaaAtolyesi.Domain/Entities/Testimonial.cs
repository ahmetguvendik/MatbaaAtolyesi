namespace MatbaaAtolyesi.Domain.Entities;

public class Testimonial : BaseEntity
{
    public string NameSurname { get; set; }
    public string JobTitle { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }    
}