using System;


public class Prompt
{   
    //Get random prompt from a list of 20 and return that prompt
    public string JournalPrompt()
    {
        string newPrompt;
        Random randomGenerator = new Random();
        int randomNumb = randomGenerator.Next(0, 20);
        List<string> prompts = new List<string> {"What was the best part of today?",
        "What challenged you most today, and how did you respond?",
    "Did you learn something new today? What was it?",
    "How did you take care of yourself today?",
    "What made you smile or laugh today?",
    "Was there a moment today when you felt proud of yourself?",
    "What’s one thing you wish you had done differently today?",
    "How did you connect with others today?",
    "What’s one thing you accomplished today, no matter how small?",
    "How did today align with your goals or values?",
    "What’s something you noticed today that you often overlook?",
    "Did you face any distractions or procrastination today? How did you handle it?",
    "What emotions did you experience most today?",
    "What’s one thing you’re grateful for from today?",
    "How did today contribute to your personal growth?",
    "Did you experience any moments of kindness today? Give details.",
    "What surprised you about today?",
    "How did you manage your energy or mood throughout the day?",
    "What’s one positive habit you practiced or could have practiced today?",
    "What’s one thing you want to remember about today?", };

        newPrompt = prompts[randomNumb];                              
        return newPrompt;
    }

}