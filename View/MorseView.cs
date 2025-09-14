using Morze1.Model;
namespace Morze1.View;

public class MorseView
{
    public void ShowToMorse(string msg)
    {
        Console.WriteLine($"Morse: {msg}");
    }

    public void ShowToText(string msg)
    {
        Console.WriteLine($"Text: {msg}");
    }
    
    public void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("#===================== Morse menu =====================#");
        Console.WriteLine("\t1. Text to Morse");
        Console.WriteLine("\t2. Morse to Text");
        Console.WriteLine("\t0. Exit");
    }
}