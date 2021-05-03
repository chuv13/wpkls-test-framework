using WTF.Core.Base;
using WTF.Core.Contracts;
using WTF.Core.Enums;

namespace WTF.Desktop.PageObjects.Elements
{
    public class GenericDialogElements : TypeSafeEnumBase, ITypeSafeEnum
    {
        public GenericDialogElements(int id, string name, SelectorType type, string value, string description) : 
            base(id, name, type, value, description)
        {

        }
    }
}
