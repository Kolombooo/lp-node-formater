namespace lp_node_formater;

public class FormatNode
{
    public string NodeFormater(string input)
    {
        string format = "/addperms h " + input + " true global";
        return format;
    }
}