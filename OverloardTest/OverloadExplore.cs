namespace OverloadExplore;

public class OverloadExplore
{
    public bool Method(string x)
    {
        return true;
    }
    public bool Method<T>(T x)
    {
        return false;
    }
}
