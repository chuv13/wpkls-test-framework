using Gauge.CSharp.Lib;
using System;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using WTF.Core.Base;
using WTF.Core.Contracts;
using WTF.Core.Enums;
using WTF.Desktop.Common.Contracts;

namespace WTF.Desktop.Common.Base
{
    public class ControlObjectModelBase : ObjectModelBase<Application, IUIItem>, IControlObjectModel
    {
        public Window Window { get; private set; }


        public override void InitializeDriver(Application driver)
        {
            this.Driver = driver;
        }

        // refactor
        public void InitializeAsyncWebDriver(Application driver, string windowName, TimeSpan timeOut)
        {
            this.InitializeDriver(driver);

            this.Window = this.Driver.GetWindow(SearchCriteria.ByAutomationId(windowName), InitializeOption.NoCache);
        }

        public override IUIItem FindElement(ITypeSafeEnum query)
        {
            IUIItem element = null;

            try
            {
                if (query.Type == SelectorType.Id)
                    element = this.Window.Get(SearchCriteria.ByAutomationId(query.Value));
                else if (query.Type == SelectorType.AutomationId)
                    element = this.Window.Get(SearchCriteria.ByAutomationId(query.Value));
                else if (query.Type == SelectorType.ClassName)
                    element = this.Window.Get(SearchCriteria.ByClassName(query.Value));
                else if (query.Type == SelectorType.Css)
                    element = this.Window.Get(SearchCriteria.ByClassName(query.Value));
                else if (query.Type == SelectorType.XPath)
                    element = this.Window.Get(SearchCriteria.ByAutomationId(query.Value));
                else
                    element = null;

                this.Window.WaitTill(() => { return element.Visible; });

                GaugeMessages.WriteMessage("Successfully Loaded '" + element.Id + "'!");
            }
            catch (Exception ex)
            {
                GaugeMessages.WriteMessage("Failed to resolve '" + query.Id + "' element!");
                GaugeMessages.WriteMessage("Details:" + ex);
            }

            return element;
        }

    }
}
