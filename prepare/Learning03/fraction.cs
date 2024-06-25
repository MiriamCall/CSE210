public class fraction
{
    private int _top;
    private int _bottom;

    public fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public fraction(wholeNumber : int)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public fraction(typeof : int, bottom : int)
    {
        _top = typeof;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(typeof : int)
    {
        _top = typeof;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(bottom : int)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}
