using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class HelperObject : IHelperObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Id { get; set; }

        public IHelperObject Clone()
        {
            return MemberwiseClone() as IHelperObject;
        }
    }
}