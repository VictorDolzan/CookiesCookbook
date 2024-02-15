namespace CookiesCookbook.FileAccess;

public static class FileFormatExtensions
{
    public static string AsFileExtension(this EFileFormat fileFormat) =>
        fileFormat == EFileFormat.Json ? "json" : "txt";
}