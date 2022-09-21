namespace Assignment2;

public class Student
{
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public enum _Status
    {
        New,
        Active,
        Dropout,
        Graduated
    };
    public _Status Status { 
        get { 
           if (DateTime.Now >= GraduationDate && EndDate == GraduationDate){
            return _Status.Graduated;
           }
           else if (DateTime.Now >= EndDate && EndDate < GraduationDate) {
            return _Status.Dropout;
           }
           else if (DateTime.Now < GraduationDate && DateTime.Now < EndDate && StartDate < DateTime.Now ) {
            return _Status.Active;
           }
           else {
            return _Status.New;
           }
        }
     }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }
    public Student(
        int id,
        string givenName,
        string surname,
        DateTime startDate,
        DateTime endDate,
        DateTime graduationDate
    )
    {
        this.Id = id;
        this.GivenName = givenName;
        this.Surname = surname;
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.GraduationDate = graduationDate;
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
            + Status
            + ", Start date: "
            + StartDate
            + ", End date: "
            + EndDate
            + ", Graduation date: "
            + GraduationDate;
    }
}
