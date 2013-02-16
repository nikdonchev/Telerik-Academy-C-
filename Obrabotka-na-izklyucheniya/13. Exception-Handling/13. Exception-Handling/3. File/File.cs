using System;
using System.IO;
using System.Security;

public class File
{
    public static void Main()
    {
        string path = Console.ReadLine();
        ReadFile(path);
    }

    private static void ReadFile(string path)
    {
        try
        {
            string content = System.IO.File.ReadAllText(path);
            Console.WriteLine(content);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path directory is incorrect");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file is not found");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path is not given");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered path is incorrect");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long - 248 characters are the maximum");
        }
        catch (UnauthorizedAccessException uoae)
        {
            Console.WriteLine(uoae.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You dont have permissions. Please contact your system administrator");
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}