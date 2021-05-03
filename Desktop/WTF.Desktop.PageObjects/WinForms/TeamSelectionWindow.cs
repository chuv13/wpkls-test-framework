using System;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using WTF.Desktop.Common.Base;
using WTF.Desktop.Common.Contracts;

namespace WTF.Desktop.PageObjects
{
    public class TeamSelectionWindow : ControlObjectModelBase, IControlObjectModel
    {
        public ListBox TeamList
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.TeamList) as ListBox;
            }
        }

        public Button OkButton
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.OkButton) as Button;
            }
        }

        public TeamSelectionWindow(Application driver, string windowName, TimeSpan timeOut)
        {
            this.InitializeAsyncWebDriver(driver, windowName, timeOut);
        }


    }
}
