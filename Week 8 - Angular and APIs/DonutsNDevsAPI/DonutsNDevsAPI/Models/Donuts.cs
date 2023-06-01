
public class DonutSearchResult
{
    public int count { get; set; }
    public Result[] results { get; set; }
}

public class Result
{
    public int id { get; set; }
    public string _ref { get; set; }
    public string name { get; set; }
    public string photo { get; set; }
    public string photo_attribution { get; set; }
}


public class DonutDetails
{
    public int id { get; set; }
    public string _ref { get; set; }
    public string name { get; set; }
    public int calories { get; set; }
    public string[] extras { get; set; }
    public string photo { get; set; }
    public string photo_attribution { get; set; }
}

