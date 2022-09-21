using System.Xml.Linq;

namespace Assignment2;

public class Queries
{
    public static String[] ReturnNamesByRowlingLINQ()
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

    public static String[] ReturnNamesByRowlingExtensionMethods()
    {
        WizardCollection wizards = WizardCollection.Create();

        var wizardNames = wizards.Where(a => a.Creator.Contains("Rowling")).Select(a => a.Name);

        return wizardNames.ToArray();
    }

    public static int? YearOfFirstSithLINQ()
    {
        WizardCollection wizards = WizardCollection.Create();

        var year = (from c in wizards
                         where c.Name.Contains("Darth")
                         orderby c.Year
                         select new
                         {
                             c.Year
                         }).First();

        return year.Year;
    }

    public static int? YearOfFirstSithExtensionMethods()
    {
        WizardCollection wizards = WizardCollection.Create();

        var year = wizards.Where(a => a.Name.Contains("Darth")).Select(a => a.Year).First();

        return year;
    }

    public static List<(string, int?)> UniqueListOfWizardsLINQ()
    {
        WizardCollection wizards = WizardCollection.Create();

        List<(string, int?)> wizardList = new List<(string, int?)>();

        var wizardsNames = (from c in wizards
                    where c.Medium.Contains("Harry Potter")
                    select new
                    {
                        c.Name,
                        c.Year
                    }).Distinct();

        foreach (var item in wizardsNames)
        {
            wizardList.Add((item.Name, item.Year));
        }

        return wizardList;
    }

    public static List<(string, int?)> UniqueListOfWizardsExtensionMethods()
    {
        WizardCollection wizards = WizardCollection.Create();

        var wizardNames = wizards.Where(a => a.Medium.Contains("Harry Potter")).Select(a => (a.Name, a.Year)).Distinct();

        return wizardNames.ToList();
    }

    public static List<string> WizardsGroupedByCreatorReverseOrderByCreatorAndWizardNameLINQ()
    {
        WizardCollection wizards = WizardCollection.Create();

        var wizardNames = (from c in wizards
                    orderby c.Name descending
                    orderby c.Creator descending
                    select c.Name);

        return wizardNames.ToList();

    }

    public static List<string> WizardsGroupedByCreatorReverseOrderByCreatorAndWizardNameExtensionMethods()
    {
        WizardCollection wizards = WizardCollection.Create();

        var wizardNames = wizards.OrderByDescending(a => a.Creator).ThenBy(a => a.Name).Select(a => a.Name);

        return wizardNames.ToList();

    }

}
