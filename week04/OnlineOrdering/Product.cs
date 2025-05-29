
class Product
{
    private string _name;
    private string _id;
    private int _quantity;
    private int _price;

    private int _cost;

    public int GetCost()
    {
        _cost = _price * _quantity;
        return _cost;
    }
    public void SetName(string _n)
    {
        _name = _n;
    }
    public void SetId(string _i)
    {
        _id = _i;
    }
    public void SetQuan(int _q)
    {
        _quantity = _q;
    }
    public void SetPrice(int _p)
    {
        _price = _p;
    }
}