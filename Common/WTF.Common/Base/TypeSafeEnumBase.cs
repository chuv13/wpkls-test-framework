using WTF.Core.Enums;

namespace WTF.Core.Base
{
    public abstract class TypeSafeEnumBase
    {
        public int Id { get; }
        public string Name { get; }
        public SelectorType Type { get; }
        public string Value { get; }
        public string Description { get; }

        public TypeSafeEnumBase(int id, string name, SelectorType type, string value, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Value = value;
            Description = description;
        }
    }
}
