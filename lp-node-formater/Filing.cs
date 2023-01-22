namespace lp_node_formater;

using System.IO;
using System.Text;

public class Filing
{
    public string ContentExtractor(string FilePath)
    {
        return File.ReadAllText(FilePath);
    }
}