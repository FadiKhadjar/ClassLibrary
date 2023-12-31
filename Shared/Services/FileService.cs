using Shared.Interfaces;
using System.Diagnostics;

namespace Shared.Services;

internal class FileService : IFileService
{
    public string GetContactFromFile(string filePath)
    {
        try 
        {
            if (File.Exists(filePath)) 
            {
                return File.ReadAllText(filePath);            
            }
        
        }
        catch (Exception ex) { Debug.WriteLine("FileService - ReadContactFromFile ::" + ex.Message); }
        return null!;
    }


    public bool SaveContactToFile(string filePath, string content)
    {
        try
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
            return true;

        }
        catch (Exception ex) { Debug.WriteLine("FileService - SaveContactToFile ::" + ex.Message); }
        return false!;
    }
}
