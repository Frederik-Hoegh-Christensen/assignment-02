using System.Xml.Linq;

namespace Assignment2;

public class Queries
{
    public static String[] ReturnNamesByRowling()
    {
        WizardCollection wizards = WizardCollection.Create();

        var characters = from c in wizards
                         where c.Creator.Contains("Rowling")
                         orderby c.Name
                         select new
                         {
                             c.Name
                         };

        List<String> returnNames = new List<String>();

        foreach (var item in characters)
        {
            returnNames.Add(item.Name);
        }


        return returnNames.ToArray();
    }

}
