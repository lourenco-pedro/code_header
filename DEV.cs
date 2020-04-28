using System;

public static class DEV
{
    public static void LogStringArray(string[] files)
    {
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
    }

}