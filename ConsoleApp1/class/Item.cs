public abstract class Item
{
    protected long invNumber;
    protected bool is_taken = false;

    public Item(long invNumber)
    {
        this.invNumber = invNumber;
    }

    public Item() {}
    
    public void Show()
    {
        Console.WriteLine($"State:\nInventory number: {invNumber}   Was taken: {!IsAvialable()}");
    }

    public void TakeItem()
    {
        if(IsAvialable()) Take();
    }

    public long GetInvNumber()
    {
        return invNumber;
    }

    public bool IsAvialable()
    {
        return is_taken ? false : true;
    }

    private void Take()
    {
        is_taken = true;
    }

    abstract public void Return();
}
