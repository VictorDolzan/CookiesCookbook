namespace CookiesCookbook.DataAccess;

public class StringTextualRepository : StringsRepository
{
    private static readonly string Separator = Environment.NewLine;
    protected override List<string> TextToStrings(string fileContents)
    {
        return fileContents.Split(Separator).ToList();
    }

    protected override string StringsToText(List<string> strings)
    {
        return string.Join(Separator, strings);
    }
}