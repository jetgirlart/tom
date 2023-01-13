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
        this.tropeLibrary.Add(new Trope("Psychic Nosebleed", "When someone's nose bleeds when they use a mental power.", new String[] { }));
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
        this.tropeLibrary.Add(new Trope("Waitstaff", "A character who waits tables or tends bar.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Robot", "An electronic machine that performs tasks. Typically styled as a human, who may or may not have some AI brain", new String[] { }));
        this.tropeLibrary.Add(new Trope("From the Future!", "Something that just so happens to be from the future so you don't have to explain it's real life origins.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Alternate Universe", "Another universe similar to the one the story is set in.", new String[] { }));
        this.tropeLibrary.Add(new Trope("It's Aliens", "Mulder was right.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Hacker", "A computer programmer who uses thier skills to penetrate a network or hardware.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Magic", "A supernatural power or ability.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Start in a Tavern", "Your story begins in a bar or tavern.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Prison Break", "Someone has escaped prison!", new String[] { }));
        this.tropeLibrary.Add(new Trope("Here there be Dragons", "This story has dragons in it.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The sea", "The ocean is involved someway.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Priates", "Thieves on boats who torrent music!", new String[] { }));
        this.tropeLibrary.Add(new Trope("Angels", "Heaveny creatures are involved somehow.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Main Questline", "You're characters are mainlining the plot, no room for subplots or stand-alone chapters here.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Unhinged Genius", "Super smart character who acts erratically or eccentrically.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Femme Fatale", "Seductive woman who uses her beauty to entrap other characters.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Usual Suspects", "Something has happened and these guys are probably responsible.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Dead Bodies Everywhere", "A whole bunch of people have died suddenly.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Unreliable Narrator", "A first person narrator or third omni is not giving you all the info.", new String[] { }));
        this.tropeLibrary.Add(new Trope("I Work Alone", "A character who refuses help from others.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Thriller", "A story dripping in suspense.", new String[] { }));
        this.tropeLibrary.Add(new Trope("How's the Peeping?", "A character participates in spying, voyeurism, or surveillance", new String[] { }));
        this.tropeLibrary.Add(new Trope("Zombies", "The reanimated dead. It's fun when they pop out of the ground.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Secret Diary", "These bad boys can hold so much exposition.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Chekhov's Gun", "'If you say in the first chapter that there is a rifle hanging on the wall, in the second or third chapter it absolutely must go off..'", new String[] { }));
        this.tropeLibrary.Add(new Trope("Precious Pet", "The MC's loyal animal friend.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Not Like Other Girls", "Whatever the other girls do, she does not.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Don't You Know Who My Father is?", "Character who think's they have more clout due to family.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Fighter", "Martial artists, warriors, knights, boxers, ninjas, whatever.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Big Race", "They have been practicing the whole time for this one race.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Plot Armor", "When a main character survives something that would otherwise kill a minor one.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Reformed Villain", "It's ok, the bad guy from earlier is now good.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Final Girl", "The last survivor of a story. Typically horror or disaster.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Obvious Metaphor", "Shove that giant whale right down their throats.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Conlang", "A constructed language, commonly for constructed cultures.", new String[] { }));
        this.tropeLibrary.Add(new Trope("When Tech Goes Bad", "Oh no the thing we made to fix the problem is now the problem!", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Luddite", "Everything modern is an unecessary convenience and must be made an example of.", new String[] { }));
        this.tropeLibrary.Add(new Trope("In College", "Story takes place in a college setting.", new String[] { }));
        this.tropeLibrary.Add(new Trope("A Road Trip", "Throw in a hitchhiker, a flat tire, and a diner and you're set.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Folklore", "A culture's fables or stories passed down through the years.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The West", "This is dependent on geographic location.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Creative Non-Fiction", "It really happened but I polished it up.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Dead End Job", "A job the character is stuck in or is underpaid. Blue or White collar. ", new String[] { }));
        this.tropeLibrary.Add(new Trope("A Play", "One of the characters is very wealthy but this is not shown or known to others.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Desert", "You love sand, admit it.", new String[] { }));
        this.tropeLibrary.Add(new Trope("The Woods", "Get lost in it, hide in it, burn it down, have fun.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Speculative Fiction", "Taking a stab at what might occur. Traditionally science fiction but you do you.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Satire", "Making fun of something but written very well.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Absurdist", "Stop that, it's silly.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Comedy", "Write something funny.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Drama", "Srs bsns.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Modernist", "It's the 20's do whatever you want, there are no rules.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Slice of Life", "A story that follows way of life for the characters involved.", new String[] { }));
        this.tropeLibrary.Add(new Trope("Epistolary", "Dear diary, you won't believe the wallpaper in this room...", new String[] { }));

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