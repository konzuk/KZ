namespace Framework.Interfaces.Helper
{
    public interface IHelperObject
    {
        string Name { get; set; }
        string Code { get; set; }
        int Id { get; set; }

        IHelperObject Clone();
    }
}