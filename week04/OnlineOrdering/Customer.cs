
using System.Net.Sockets;
using System.Collections.Generic;
class Customer
{
    private string _name;
    private Address _address;
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
    public void SetAddress(string _s,string _ci, string _p, string _c)
    {
        Address address1 = new Address();
        address1.SetInfo( _s, _ci, _p, _c);
        
    }
    public string GetAddress()
    {
        _address.ShowInfo();
        return _loc;
    }
}