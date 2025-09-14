using System.Text;
using System.Text.Json;
using Morze1.Model;

namespace Morze1.Data;

public class FileStorage
{
    private readonly string filePath;

    public FileStorage(string filePath = "morse.json")
    {
        this.filePath = filePath;
    }

    public List<MorseModel> Load()
    {
        if (!File.Exists(this.filePath))
        {
            throw new Exception($"No file found: {this.filePath}");
        }
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<MorseModel>>(json) ?? new List<MorseModel>();
    }

    public void Save(List<FileModel> file)
    {
        string json = JsonSerializer.Serialize(file, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText("output.json", json);
    }
}