using Morze1.Model;
using Morze1.Data;
using Morze1.View;
using System.Text;

namespace Morze1.Controller;

public class MorseController
{
    private readonly MorseView view;
    private readonly FileStorage storage;
    private List<MorseModel> morseCode;
    private List<FileModel> fileModel;

    public MorseController(MorseView view, FileStorage storage)
    {
        this.view = view;
        this.storage = storage;
        morseCode = storage.Load();
        fileModel = new List<FileModel>();
    }

    public void Run()
    {
        while (true)
        {
            view.ShowMenu();
            ConsoleKeyInfo c = Console.ReadKey(true);

            switch (c.KeyChar)
            {
                case '1':
                    TextToMorse();
                    break;
                case '2':
                    MorseToText();
                    break;
                case '0':
                    if (fileModel != null)
                    {
                        storage.Save(fileModel);
                    }
                    return;
            }
        }
    }

    private void TextToMorse()
    {
        Console.WriteLine("Text: ");
        string text = Console.ReadLine() ?? "Unknown";

        string morse = GetMorse(text);
        view.ShowToText(morse);

        var res = new FileModel
        {
            Text = text,
            Morse = morse
        };
        fileModel.Add(res);
        Console.ReadKey();
    }

    private void MorseToText()
    {
        Console.WriteLine("Morse: ");
        string morse = Console.ReadLine() ?? "Unknown";

        string text = GetText(morse) ?? "Unknown";
        view.ShowToText(text);

        var res = new FileModel
        {
            Text = text,
            Morse = morse
        };
        fileModel.Add(res);
        Console.ReadKey();
    }

    private string GetMorse(string text)
    {
        StringBuilder strbuild = new StringBuilder();

        foreach (var ch in text.ToUpper())
        {
            if (ch == ' ')
            {
                strbuild.Append("/ ");
            }
            else
            {
                var entry = morseCode.FirstOrDefault(x => x.Letter == ch);
                if (entry != null)
                {
                    strbuild.Append(entry.Morse + " ");
                }
                else
                {
                    strbuild.Append("? ");
                }
            }
        }

        return strbuild.ToString().Trim();
    }

    private string GetText(string morse)
    {
        StringBuilder strbuild = new StringBuilder();

        var words = morse.Split('/', StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            var letters = word.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var letter in letters)
            {
                var entry = morseCode.FirstOrDefault(x => x.Morse == letter);
                if (entry != null)
                {
                    strbuild.Append(entry.Letter);
                }
                else
                {
                    strbuild.Append('?');
                }
            }

            strbuild.Append(' ');
        }

        return strbuild.ToString().Trim();
    }
}