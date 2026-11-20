public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What is the most important thing to do this week?",
        "Who do you have to meet today?",
        "When do you have to play your games?",
        "Which movie would you like to watch?",
        "How many kilometer do you have to run today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}