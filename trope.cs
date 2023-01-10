public class Trope{
  
    public String title { get; }

    public String description {get;}

    public String[] examples {get;}

    public bool flipped {get;set;}

    public Trope(String title, String description, String[] examples){
        this.title = title;
        this.description = description;
        this.examples = examples;
        this.flipped = false;
    
    }

}
