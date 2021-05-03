using Gauge.CSharp.Lib;
using System;
using System.Diagnostics;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using WTF.Core.Base;
using WTF.Core.Contracts;
using WTF.Desktop.Common.Contracts;
using WTF.Desktop.Common.Enums;
using WTF.Desktop.PageObjects.Enums;
using WTF.Desktop.PageObjects.WinForms;

namespace WTF.Desktop.PageObjects
{
    public class WindowFactory : UIFactoryBase<Application, IControlObjectModel, AppType, WindowType>, IUIFactory<Application, IControlObjectModel, AppType, WindowType>, IFactory
    {
        public override IControlObjectModel Create(WindowType page, Application driver, TimeSpan timeOut)
        {
            if (page == WindowType.MainWindow)
            {
                var login = new MainWindow();
                login.InitializeAsyncWebDriver(driver, ExpressMainWindowElements.WindowName.Name, timeOut);
                return login;
            }
            else
            {
                GaugeMessages.WriteMessage("ERROR: Could not load" + WindowType.MainWindow.ToString() + "!");
                return null;
            }
        }

        public override Application GetDriver(AppType type)
        {
            var info = new ProcessStartInfo
            {
                FileName = @"C:\Program Files (x86)\Carlson Wagonlit Travel\Power Express 19.7\PowerExpress.exe",
                Arguments = @"env:test testuser:u003axo"
            };
            var pBuilder = new Process
            {
                StartInfo = info
            }.Start();

            Application application;
            Process[] processes = Process.GetProcessesByName(@"PowerExpress");
            if (processes.Length == 0)
                application = Application.Launch(info);
            else
                application = Application.Attach(@"PowerExpress");

            // Wait for window to load before proceeding by looking for splash screen to finish and main window should be visible
            var mainWindow = application.GetWindow(SearchCriteria.ByAutomationId(ExpressMainWindowElements.WindowName.Name), InitializeOption.NoCache);
            mainWindow.WaitTill(() => mainWindow.Visible);

            return application;
        }
    }
}
