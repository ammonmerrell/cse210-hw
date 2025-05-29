

using System.Runtime.CompilerServices;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _count =0;
    private int _totalCost;
    private bool _isUSA;
    private string _id;
    private string _name;

    private string _packingLabel;

    private string _shipingLabel;
    public void AddProduct(string _n, string _i, int _q, int _p)
    {
        if (_count == 0)
        {
            Product product1 = new Product();
            product1.SetName(_n);
            product1.SetId(_i);
            product1.SetQuan(_q);
            product1.SetPrice(_p);
            _count = 1;
        }
        else if (_count == 1)
        {
            Product product2 = new Product();
            product2.SetName(_n);
            product2.SetId(_i);
            product2.SetQuan(_q);
            product2.SetPrice(_p);
        }
        

    }
    public void AddCustomer(string _na)
    {
        Customer _customer = new Customer();
        _customer.SetName(_na);
    }
    public void SetAddres(string _s, string _ci, string _p, string _c)
    {
        Customer _customer = new Customer();
        _customer.SetAddress(_s, _ci, _p, _c);
    }

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

    public string PackingLabel()
    {
        foreach (Product i in _products)
        {
            i.SetName(_name);
            i.SetId(_id);
            _packingLabel = _name + " " + _id;
        }
        return _packingLabel;
    }
    public string ShipingLabel()
    {
        _shipingLabel += _customer.GetName();
        _shipingLabel += _customer.GetAddress();
        return _shipingLabel;

    }
}