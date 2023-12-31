namespace Shared.Interfaces;

internal interface IFileService
{
    /// <summary>
    /// Save content to a specified filepath.
    /// </summary>
    /// <param name="filePath">enter the filepath with extension</param>
    /// <param name="content">enter your content as a string</param>
    /// <returns>returns true if saved, else false if failed</returns>
    bool SaveContactToFile(string filePath, string content);
    
    /// <summary>
    /// Get content as string from a specified filepath
    /// </summary>
    /// <param name="filePath">enter the filepath with extension</param>
    /// <returns>returns file content as string if file exist, else returns null.</returns>
    
    string GetContactFromFile(string filePath);
}
