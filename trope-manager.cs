public class TropeManager
{
    public static Random rnd = new Random();

    private HashSet<int> alreadySelected = new();

    private List<Trope> tropeLibrary = new();
    public TropeManager()
    {
        this.tropeLibrary.Add(new Trope("Enemies to Lovers", "Characters who begin as enemies that fall in love with each other.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Magical Realism", "Latin-American narrative strategy that is characterized by the matter-of-fact inclusion of fantastic or mythical elements into seemingly realistic fiction.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Mad Scientist", "Scientists who use their knowledge to create or do evil things.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Psychic Nosebleed", "That thing where someone's nose bleeds when they use a mental power.", new String[] { }));
        this.tropeLibrary.Add(new Trope("There's Only One Bed", "When two or more characters have to share a bedroom for the night but there is only one bed available.", new String[] { }));
        this.tropeLibrary.Add(new Trope("In Medias Res", "Starting the story in the middle.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Rags to Riches", "Characters start off poor and end up with money.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Hero's Journey", "A character sets out on an adventure, overcoming a great obstacle and returns changed by the outcome.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Tragedy", "A story in which the main character(s) are subjected to an unfortunate event, typically with an unhappy ending.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Chosen One", "Characters who are selected by destiny or higher power to fulfill some purpose.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Dark Lord", "An omnipotent evil overlord character, typically with henchmen, evil armies, and a blighted kingdom.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Love Triange", "Character A loves Character B loves Character C loves Character A... ", new String[] { }));
        this.tropeLibrary.Add(new Trope("Hidden Prince", "A male character with unknown origins turns out to have royal blood.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Hidden Princess", "A female character with unknown origins turns out to have royal blood", new String[] { }));
        this.tropeLibrary.Add(new Trope("Save the World!", "Chracters are on a quest to save the world from whatever is threatening it", new String[] { }));
        this.tropeLibrary.Add(new Trope("Conspiracy", "Grab your tinfoil hats it's time for wild speculation!", new String[] { }));
        this.tropeLibrary.Add(new Trope("Vampires", "Monsters who drink the blood of humans. Are killed by a stake to the heart, silver weapons, or sunlight.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Werewolves", "Monsters who are humans that have been bit by another werewolf and can now transform into either a large wolf or some wolf/human hybrid.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Demons", "Unholy evil mosnters, typically from hell.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Battle Pets", "Small animals or creatures that the main characters use to fight with.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Magical High School", "A specialised high school for kids with some manner of magic prowess or abilities", new String[] { }));
        this.tropeLibrary.Add(new Trope("Friends to Lovers", "Characters who are platonic friends who become lovers.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Late Night Diner", "A story set in a diner late at night.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Small Town", "A story set in a rural town. Great for romance or murder mystery.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Big City", "A story set in a large city. Great for big monsters and detective stories.", new String[] { }));
        this.tropeLibrary.Add(new Trope("THERE HAS BEEN A MURDER", "Accidents happen all the time. Not everything's a MUR-DUR.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Ex Girlfriend", "A secondary character that was once romantically involved with a main character. Can be used for good or evil.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Crumbling Victorian House", "It's cold, it's damp, it's swarming with beetles! Perfect for a haunted house or historical drama.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Cat and Mouse", "Character A pursues Chracter B for some reason. ", new String[] { }));
        this.tropeLibrary.Add(new Trope("Ticking Clock", "You've got thirty seconds before the bomb goes off!", new String[] { }));
        this.tropeLibrary.Add(new Trope("Ancient Evil", "An evil that predates the common era of the story.", new String[] { }));
        this.tropeLibrary.Add(new Trope("A Cult", "An easy way to make a group of non-monster characters a morally acceptable target.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Forbidden Fruit", "Something the character was told not to do, or shouldn't have.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Manic Pixie Dream Girl", "Exists solely in the fevered imaginations of sensitive writer-directors to teach broodingly soulful young men/women to embrace life and its infinite mysteries and adventures.", new String[] { }));
        this.tropeLibrary.Add(new Trope("In Space!", "Whatever is happening is happening in outer space.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Time Traveling", "We gotta go back! Characters travel through time in some way.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Prostitute", "Someone who offers sex in exchange for goods and services.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Robot", "An electronic machine that performs tasks. Typically styled as a human, who may or may not have some AI brain", new String[] { }));
        this.tropeLibrary.Add(new Trope("From the Future!", "Something that just so happens to be from the future so you don't have to explain it's real life origins.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Alternate Universe", "Another universe similar to the one the story is set in.", new String[] { }));
        this.tropeLibrary.Add(new Trope("It's Aliens", "Mulder was right.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Hacker", "A computer programmer who uses thier skills to penetrate a network or hardware.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Magic", "A supernatural power or ability.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Start in a Tavern", "Your story begins in a bar or tavern. A staple of fantasy and D&D campaigns.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Prison Break", "Someone has escaped prison!", new String[] { }));
        this.tropeLibrary.Add(new Trope("Here there be Dragons", "This story has dragons in it.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The sea", "The ocean is involved someway.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Priates", "Theives on boats who torrent music!", new String[] { }));
        this.tropeLibrary.Add(new Trope("Angels", "Heaveny creatures are involved somehow.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Main Questline", "You're characters are mainlining the plot, no room for subplots or stand-alone chapters here.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Unhinged Genius", "Super smart character who acts erratically or eccentrically.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Femme Fatale", "Seductive woman who uses her beauty to entrap other characters.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Usual Suspects", "Something has happened and these guys are probably responsible.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Dead Bodies Everywhere", "A whole bunch of people have died suddenly.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Unreliable Narrator", "A first person narrator or third omni is not giving you all the info.", new String[] { }));
        this.tropeLibrary.Add(new Trope("She Breasted Boobily", "A wildly unnecessary and possibly incorrect description of a female character's anatomy.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Savant", "A character with Savant Syndrome plays an important part of the story.", new String[] { }));
        this.tropeLibrary.Add(new Trope("How's the Peeping?", "A character participates in spying, voyeurism, or surveillance", new String[] { }));
        this.tropeLibrary.Add(new Trope("Secretly Rich", "One of the characters is very wealthy but this is not shown or known to others.", new String[] { }));
    }

    private int getRandomNumber()
    {
        int tropeLibraryCount = tropeLibrary.Count();
        int index = rnd.Next(0, tropeLibraryCount);
        return index;
    }

    public void clearSelected()
    {
        this.alreadySelected.Clear();
    }

    public Trope? getRandomTrope()
    {
        int index = getRandomNumber();
        if (alreadySelected.Count == tropeLibrary.Count)
        {
            return null;
        }
        if (alreadySelected.Contains(index))
        {
            return getRandomTrope();
        }
        Trope selected = tropeLibrary[index];
        alreadySelected.Add(index);
        return selected;
    }
}