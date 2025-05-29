

using System.Runtime.CompilerServices;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _totalCost;
    private bool _isUSA;
    private string _id;
    private string _name;
    private string _packingLabel;

    private string _shipingLabel;

    public int TotalCost()
    {
        if (_isUSA)
        {
            _totalCost = 5;
            return _totalCost;
        }
        else _totalCost = 35;
        return _totalCost;
    }
    private string PackingLabel()
    {
        foreach (Product i in _products)
        {
            _name = i._name;
            _id = i._id;
            _packingLabel = _name + " " + _id;
        }
        return _packingLabel;
    }
    private string ShipingLabel()
    {
        _shipingLabel += Customer.name;
        _shipingLabel += Customer.address;
        return _shipingLabel;

    }
}