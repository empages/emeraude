using System;
using System.IO;

namespace Emeraude.Essentials.Helpers;

/// <summary>
/// Functions for random generations.
/// </summary>
public static class RandomUtilities
{
    private static readonly Random Random = new Random();

    /// <summary>
    /// Gets random element from array.
    /// </summary>
    /// <typeparam name="T">Type of the array elements.</typeparam>
    /// <param name="array"></param>
    /// <returns></returns>
    public static T GetRandomElementFromArray<T>(T[] array)
    {
        return array[Random.Next(0, array.Length)];
    }

    /// <summary>
    /// Gets random file from directory.
    /// </summary>
    /// <param name="directory"></param>
    /// <returns></returns>
    public static string GetRandomFileFromDirectory(string directory)
    {
        if (Directory.Exists(directory))
        {
            var files = Directory.GetFiles(directory);
            if (files.Length > 0)
            {
                return GetRandomElementFromArray(files);
            }
        }

        return null;
    }
}