
class address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    private string _info;

    public bool inUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else return false;
    }
    public string ShowInfo()
    {
        _info = _street + ", " + _city + ", " + _province + ", " + _country;
        return _info;
    }
    public void SetInfo(string _s, string _c, string _p, string _co)
    {
        _street = _s;
        _city = _c;
        _province = _p;
        _country = _co;
    }

}