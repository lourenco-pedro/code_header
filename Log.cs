using System;

public static class Log
{

    public static Exception DirectoryExpection(DirectoryExpection expectionType)
    {
        switch (expectionType)
        {
            default:
                throw new Exception("Directory is null");
        }
    }
}