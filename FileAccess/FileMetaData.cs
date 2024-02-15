namespace CookiesCookbook.FileAccess;

public class FileMetaData
{
    public string Name { get; set; }
    public EFileFormat Format { get; }
    
    public FileMetaData(string name, EFileFormat format)
    {
        Name = name;
        Format = format;
    }

    public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}