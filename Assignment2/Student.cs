namespace Assignment2;

public class Student 
{
    public int id { get; init; }
    public string name { get; set; } = string.Empty;
    public string surname { get; set; } = string.Empty;
    public Status status { get => calcStatus(); }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public DateTime graduationDate { get; set; }



    public Status calcStatus() 
    {
        if(startDate == DateTime.Today) return Status.New;
        if(startDate < DateTime.Today) return Status.Active;
        if(startDate < DateTime.Today && endDate <= DateTime.Today) return Status.Dropout;
        if(startDate < DateTime.Today && endDate <= DateTime.Today && graduationDate <= DateTime.Today) return Status.Graduated;
        else return Status.New;
    }
    

    public override string ToString() 
    {
        return "Id: " + id + " Name: " + name + " Surname: " + surname + " Status: " + 
            status + " Start date: " + startDate + " End date: " + 
            endDate + " Graduation date: " + graduationDate;
    }

}

