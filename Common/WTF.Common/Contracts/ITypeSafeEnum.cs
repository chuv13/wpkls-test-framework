using WTF.Core.Enums;

namespace WTF.Core.Contracts
{
    public interface ITypeSafeEnum
    {
        int Id { get; }
        string Name { get; }
        SelectorType Type { get; }
        string Value { get; }

        string Description { get; }
    }
}
