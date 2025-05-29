
class Customer
{
    private string _name;
    private address _address;
    private string _loc;


    public bool GetLocation()
    {
        return _address.inUSA();
    }
    public void SetName(string _n)
    {
        _name = _n;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        _address.ShowInfo();
        return _loc;
    }
}