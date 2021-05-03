using System;
using TestStack.White;
using TestStack.White.UIItems;
using WTF.Desktop.Common.Base;
using WTF.Desktop.Common.Contracts;

namespace WTF.Desktop.PageObjects
{
    public class GenericDialog : ControlObjectModelBase, IControlObjectModel
    {
        public GenericDialog(Application driver, string windowName, TimeSpan timeOut)
        {
            this.InitializeAsyncWebDriver(driver, windowName, timeOut);
        }

        public Button YesButton
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.YesButton) as Button;
            }
        }

        public Button NoButton
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.NoButton) as Button;
            }
        }
    }
}
