

public class PromptGenerator
{

    public List<string> _prompts = new List<string>() { "What was the most exiting thing that happened today?", "What was your favorite activity you particitpated in today?", "Have I seen the Lord's hand in my life today?", "What has been the worst part of the day?", "What was the best food today?" };
    public Random _randomNumberList = new Random();
    public int _randomNumber;
public string GetRandomPrompt()
    {
        _randomNumber = _randomNumberList.Next(1, 6);
        return _prompts[_randomNumber];
    }
}