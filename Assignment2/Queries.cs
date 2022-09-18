namespace Assignment2;

public class Queries
{
    // 1. Wizards invented by Rowling. Only return the names.
    
    // LINQ implementation
    public static IEnumerable<string> GetRowlingWizardsOne(IEnumerable<Wizard> wizards) =>
        from w in wizards
        where w.Creator.Contains("J.K. Rowling")
        select w.Name;

    // Extension method implementation 
    public static IEnumerable<string> GetRowlingWizardsTwo(IEnumerable<Wizard> wizards) => 
        wizards.Where(w => w.Creator.Contains("J.K. Rowling")).Select(w => w.Name);



    // 2. The year the first sith lord was introduced. Let's define a sith lord to be one named Darth something.

    // LINQ implementation
    public static int? GetFirstSithLordYearOne(IEnumerable<Wizard> wizards) => 
        (from w in wizards
        where w.Name.Contains("Darth")
        select w).First().Year;

    // Extension method implementation 
    public static int? GetFirstSithLordYearTwo(IEnumerable<Wizard> wizards) => 
        wizards.First(w => w.Name.Contains("Darth")).Year;



    // 3. Unique list of wizards from the Harry Potter books - only return name and year (as a value tuple).

    // LINQ implementation
    public static IEnumerable<(string name, int? year)> GetUniqueRowlingWizardsOne(IEnumerable<Wizard> wizards) => 
        (from w in wizards
        where w.Medium.Equals("Harry Potter")
        select (w.Name, w.Year)).Distinct();

    // Extension method implementation 
    public static IEnumerable<(string name, int? year)> GetUniqueRowlingWizardsTwo(IEnumerable<Wizard> wizards) => 
        wizards.Where(w => w.Medium.Equals("Harry Potter")).Select(w => (w.Name, w.Year)).Distinct();



    // 4. List of wizard names grouped by creator in reverse order by creator name and then wizard name.

    // LINQ implementation
    public static IEnumerable<(string, IEnumerable<string>)> GetWizardsByCreatorOne(IEnumerable<Wizard> wizards) => 
        from w in wizards
        group w by w.Creator into g
        orderby g.Key descending
        select (g.Key, (from x in g select x.Name));

    // Extension method implementation 
    public static IEnumerable<(string, IEnumerable<string>)> GetWizardsByCreatorTwo(IEnumerable<Wizard> wizards) => 
        wizards.GroupBy(w => w.Creator).OrderByDescending(w => w.Key).Select(w => (w.Key, w.Select(x => x.Name)));
}