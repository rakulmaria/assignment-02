namespace Assignment2;

public record ImmutableStudent
{
    public int Id { get; init; }
    public string GivenName { get; init; }
    public string Surname { get; init; }
    public Status _Status { get => calcStatus(); }
    public enum Status
    {
        New,
        Active,
        Dropout,
        Graduated
    };
    
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }
    
    public Status calcStatus() 
    {
        if(StartDate == DateTime.Today) return Status.New;
        if(StartDate < DateTime.Today) return Status.Active;
        if(StartDate < DateTime.Today && EndDate <= DateTime.Today) return Status.Dropout;
        if(StartDate < DateTime.Today && EndDate <= DateTime.Today && GraduationDate <= DateTime.Today) return Status.Graduated;
        else return Status.New;
    }
    

    public override string ToString()
    {
        return "Id: "
            + Id
            + ", Givenname: "
            + GivenName
            + ", Surname: "
            + Surname
            + ", Status: "
            + _Status
            + ", Start date: "
            + StartDate
            + ", End date: "
            + EndDate
            + ", Graduation date: "
            + GraduationDate;
    }
}
