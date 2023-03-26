using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public partial class FileLoader : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadTextFromFileCoroutine(@"D:\!Unity\Projects\Text\Text123.txt"));
    }

    private IEnumerator LoadTextFromFileCoroutine(string filePath)
    {
        string text = File.ReadAllText(filePath);
        Debug.Log(text);

        yield return null;
    }
}