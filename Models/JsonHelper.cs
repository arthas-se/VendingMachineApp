using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Task2;

public class JsonHelper
{
    private readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };
    public T ReadFromFile<T>(string filePath) where T : new()
    {
        if (!File.Exists(filePath))
        {
            return new T();
        }

        try
        {
            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
            {
                return new T();
            }

            return JsonSerializer.Deserialize<T>(json, _options) ?? new T();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error reading file {filePath}: {ex.Message}");
        }
    }

    public void WriteToFile<T>(string filePath, T data)
    {
        try
        {
            string json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error writing to file {filePath}: {ex.Message}");
        }
    }
}
