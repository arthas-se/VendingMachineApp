using System;
using System.IO;

namespace Task2;

public static class AppPaths
{
    public static string History => Path.Combine(Directory.GetCurrentDirectory(), "history.json");
    public static string Resources => Path.Combine(Directory.GetCurrentDirectory(), "resources.json");
    public static string AdminAlert => Path.Combine(Directory.GetCurrentDirectory(), "admin_alert.txt");
}
