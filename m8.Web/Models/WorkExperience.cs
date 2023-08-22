namespace m8.Web.Models;

public class WorkExperience
{
    public string Company { get; set; }
    public string Location { get; set; }
    public string JobTitle { get; set; }
    public string Description { get; set; }
    public List<string> Technologies { get; set; }
    public DateTime From { get; set; }
    public DateTime? To { get; set; }
}
