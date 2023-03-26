using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public partial class FileLoader : MonoBehaviour
{
    private async void Start()
    {
        string filePath = @"D:\!Unity\Projects\Text\Text123.txt";
        string text = await LoadTextFromFileAsync(filePath);
        Debug.Log(text);
    }

    private async Task<string> LoadTextFromFileAsync(string filePath)
    {
        string text = await File.ReadAllTextAsync(filePath);
        return text;
    }
}