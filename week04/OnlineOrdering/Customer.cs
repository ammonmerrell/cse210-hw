
class Customer
{
    private string _name;
    private address _address;


    public bool GetLocation()
    {
        return _address.inUSA();
    }
}