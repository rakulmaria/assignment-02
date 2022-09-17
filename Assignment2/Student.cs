namespace Assignment2;

public class Student 
{
    public int id { get; init; }
    public string name { get; set; } = string.Empty!;
    public string surname { get; set; } = string.Empty!;
    public Status status { get => calcStatus(); }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public DateTime graduationDate { get; set; }



    public Status calcStatus() 
    {
        if(startDate == DateTime.Today) return Status.New;
        if(startDate <= DateTime.Today) return Status.Active;
        if(startDate <= DateTime.Today && endDate <= DateTime.Today) return Status.Dropout;
        if(startDate <= DateTime.Today && endDate <= DateTime.Today && graduationDate <= DateTime.Today) return Status.Graduated;
        else return Status.New;
    }
    

    public override string ToString() 
    {
        return "Name: " + name + "\nSurname: " + surname + "\nStatus: " + 
            status + "\nStart Date: " + startDate + "\nEnd date: " + 
            endDate + "\nGraduation Date: " + graduationDate;
    }

}