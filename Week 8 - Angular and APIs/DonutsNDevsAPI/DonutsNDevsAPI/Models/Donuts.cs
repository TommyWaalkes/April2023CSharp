
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class DonutSearchResult
{
    public int count { get; set; }
    public Result[] results { get; set; }
}

public class Result
{
    [Key]
    public int id { get; set; }

    //Use the @ symbol this only works for using keywords as identifiers, will not work for other situations
    public string @ref { get; set; }
    public string name { get; set; }
    public string photo { get; set; }
    public string photo_attribution { get; set; }
}


public class DonutDetails
{
    [Key]
    public int id { get; set; }
    //By putting this annotation/tag, you're telling the built in JSON parser in RestSharp, you intend this property to be mapped 
    //to a certain property from the API. This works for using keywords, using numbers at the start of identifiers and any other case

    //This needs to match the property name in your API
    [JsonPropertyName("ref")]

    //The name for this property needs to match what's in your database
    public string _ref { get; set; }
    public string name { get; set; }
    public int calories { get; set; }

    [NotMapped]
    [JsonPropertyName("extras")]
    public string[] extrasApi { get; set; }

    //[ForeignKey("Extra")]
    //public virtual ICollection<Extra> extras { get; set; }

    public string photo { get; set; }
    public string photo_attribution { get; set; }
}

public class Extra
{
    [Key]
    public int id { get; set; }

    public string extra { get; set; }
}


public class DonutExtras
{
    [Key]
    public int id { get; set; }

    [ForeignKey("Extra")]
    public int Extra { get; set; }

    [ForeignKey("DonutDetails")]
    public int DonutDetails { get; set; }
}

