﻿using WTF.Core.Base;
using WTF.Core.Contracts;
using WTF.Core.Enums;

namespace WTF.Desktop.PageObjects.Elements
{
    public class UserProfileSelectionWindowElements : TypeSafeEnumBase, ITypeSafeEnum
    {
        public UserProfileSelectionWindowElements(int id, string name, SelectorType type, string value, string description) : 
            base(id, name, type, value, description)
        {
        }
    }
}
