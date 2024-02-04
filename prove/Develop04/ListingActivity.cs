public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {   
        _name = "Listing Activity";


    } 

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        var aniList = new List<string> {"|", "/", "-", "\\"};
        return aniList;
    }
}