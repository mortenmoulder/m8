namespace m8.Web.Models;

public class Skill
{
    public Skill(string name, int percentage)
    {
        Name = name;
        Percentage = percentage;
    }

    public string Name { get; set; }
    public int Percentage { get; set; }
}
