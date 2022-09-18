namespace Assignment2;
using System.Linq;

public class Queries
{
    public static IEnumerable<string> QueryOne(WizardCollection wizardCollection)
    {
        var rowling =
            from w in wizardCollection
            where w.Creator.Contains("Rowling")
            select w.Name;
        
        rowling.ToList();
        return rowling;    
    }
    public static IEnumerable<string> QueryOneExtensionMethod(WizardCollection wizardcollection){
        return wizardcollection.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name).ToList();
    }

    public static int QueryTwo(WizardCollection wizardcollection){
        var siths = 
        from w in wizardcollection
        where w.Name.Contains("Darth") 
        orderby w.Year descending
        select w.Year;
        int firstyear = Convert.ToInt32(siths.First());
        return firstyear; 
    }
    public static int QueryTwoExtensionMethod(WizardCollection wizardcollection){
        var siths = wizardcollection.Where(w => w.Name.Contains("Darth")).OrderByDescending(w => w.Year).Select(w => w.Year);
        int firstyear = Convert.ToInt32(siths.First());
        return firstyear; 
    }

    public static IEnumerable<(string,int)> QueryThree(WizardCollection wizardcollection){
       var uniquelist = from w in wizardcollection
       where w.Medium.Contains("Harry Potter")
       group w by w.Name into newGroup select newGroup.First();
       
       uniquelist.ToList();
       foreach (Wizard w in uniquelist){
            yield return (w.Name,Convert.ToInt32(w.Year));
        }
        

    }
    public static IEnumerable<(string,int)> QueryThreeExtensionMethod(WizardCollection wizardcollection){
        var uniquelist = wizardcollection.Where(w => w.Medium.Contains("Harry Potter")).GroupBy(w => w.Name).Select(g => g.First()).ToList();
        foreach (Wizard w in uniquelist){
            yield return (w.Name,Convert.ToInt32(w.Year));
        }
    }
    //List of wizard names grouped by creator in reverse order by creator name and then wizard name.
    public static IEnumerable<string> QueryFour(WizardCollection wizardcollection){
        var reverseOrder = from w in wizardcollection
        group w by w.Creator into newGroup select newGroup.Reverse();
        reverseOrder.ToList();
        foreach (var w in reverseOrder){
            foreach (var x in w){
                yield return x.Creator + " "+ x.Name; 
            }
        }
    }
    public static IEnumerable<string> QueryFourExtensionMethod(WizardCollection wizardcollection){
        var reverseOrder = wizardcollection.GroupBy(w => w.Creator).Select(group => group.Reverse().ToList());
            foreach (var w in reverseOrder){
            foreach (var x in w){
                yield return x.Creator + " "+ x.Name; 
            }
        }
        }
    }

