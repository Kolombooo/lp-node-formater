using lp_node_formater;

string FileContent = new Filing().ContentExtractor(@"c:\Users\Kolombo\RiderProjects\lp-node-formater\lp-node-formater\resources\input.txt");
List<string> FileContentList = new List<string>(
    FileContent.Split(new string[] { "\r\n" }, 
        StringSplitOptions.RemoveEmptyEntries));


foreach (var i in FileContentList)
{
    var nodeFormater = i;
    nodeFormater = new FormatNode().NodeFormater(i);
    Console.WriteLine(nodeFormater);
}