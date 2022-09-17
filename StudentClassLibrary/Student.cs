namespace StudentClassLibrary;

public class Student
{
    public int Id { get; init; }

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

    public string GivenName { get; set; }

    public string Surname { get; set; }

    public enum _Status
    {
        New,
        Active,
        Dropout,
        Graduated
    };

    public _Status Status { get; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime GraduationDate { get; set; }

    public override string ToString()
    {
        return "Id: "
            + Id
            + ", Givenname: "
            + GivenName
            + ", Surname: "
            + Surname
            + " Status: "
            + Status
            + "Start date: "
            + StartDate
            + ", End date: "
            + EndDate
            + ", Graduation Date: "
            + GraduationDate;
    }
}
