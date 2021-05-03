using System;
using TestStack.White;
using TestStack.White.UIItems;
using WTF.Desktop.Common.Base;
using WTF.Desktop.Common.Contracts;

namespace WTF.Desktop.PageObjects
{
    public class SystemUserSettingsWindow : ControlObjectModelBase, IControlObjectModel
    {
        public SystemUserSettingsWindow(Application driver, string windowName, TimeSpan timeOut)
        {
            this.InitializeAsyncWebDriver(driver, windowName, timeOut);
        }

        public Button OkButton
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.OkButton) as Button;
            }
        }
    }
}
