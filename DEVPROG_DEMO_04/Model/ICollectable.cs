namespace DEVPROG_DEMO_04.Model
{
    /// <summary>
    /// interface to determine collectable items, 
    /// such as wine or comic books
    /// </summary>
    public interface ICollectable
    {
        int YearOfOrigin { get; set; }
    }
}
