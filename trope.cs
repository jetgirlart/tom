public class Trope{
  
    public String Title { get; }

    public String Description {get;}

    public String[] Examples {get;}

    public bool Flipped {get;set;}

    public Trope(String title, String description, String[] examples){
        Title = title;
        Description = description;
        Examples = examples;
        Flipped = false;
    
    }

}
