public class Money(int v = 100)
{
    public int Value { get; private set; } = v;
    public Money? Next { get; set; } = null;

    public override string ToString()
    {
        return $"[{Value.ToString()}]";
    }


}