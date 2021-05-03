using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using WTF.Desktop.Common.Base;
using WTF.Desktop.Common.Contracts;

namespace WTF.Desktop.PageObjects
{
    public class UserProfileSelectionWindow : ControlObjectModelBase, IControlObjectModel
    {
        public UserProfileSelectionWindow(Application driver, string windowName, TimeSpan timeOut)
        {
            this.InitializeAsyncWebDriver(driver, windowName, timeOut);
        }

        public ListBox UserList
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.UserList) as ListBox;
            }
        }

        public Button OkButton
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.OkButton2) as Button;
            }
        }
    }
}
