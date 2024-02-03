namespace Task1;

public class Student : Person
{
    string _program;
    int _year;
    double _fee;
    public Student(string name, string address, string program, int year, double fee) : base(name,address)
    {
        _program = program;
        _year = year;
        _fee = fee;        
    }
    public string getProgram()
    {
        return _program;
    }
    public void setProgram(string program)
    {
        _program = program;
    }
    public int getYear()
    {
        return _year;
    }
    public void setYear(int year)
    {
        _year = year;
    }
    public double getFee()
    {
        return _fee;
    }
    public void setFee(double fee)
    {
        _fee = fee;
    }
    public string toString()
    {
        return $"Student name =  {getName()}  address = {getAddress()}, program = {getProgram()}, year = {getYear()} fee = {getFee()}";
    }
}
