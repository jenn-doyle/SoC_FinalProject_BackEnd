using System.Collections.Generic;

public class Homework
{
    public long? Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }

    // to implement later once we have figured out how to synchronize SQL and C# Dates
    //  public string Dateset { get; set; }

    public string Datedue { get; set; }
    public string Comment { get; set; }

    public List<Children> children { get; set; }


}