
class address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public bool inUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else return false;
    }
}