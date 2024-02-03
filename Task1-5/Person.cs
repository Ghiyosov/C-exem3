namespace Task1;

public class Person
{
    string _name;
    string _address;
    public Person(string name , string address)
    {
        _name = name;
        _address = address;
    }
    public string getName()
    {
        return _name;
    }
    public string getAddress()
    {
        return _address;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public void setAddress(string address)
    {
        _address = address;
    }
    public string toString()
    {
        return $"{_name} ({_address})";
    }

}
