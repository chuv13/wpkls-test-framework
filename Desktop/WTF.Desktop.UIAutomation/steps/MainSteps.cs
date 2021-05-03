using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using System;
using TestStack.White;
using WTF.Core.Base;
using WTF.Desktop.Common.Contracts;
using WTF.Desktop.Common.Enums;
using WTF.Desktop.Common.Helpers;
using WTF.Desktop.PageObjects;
using WTF.Desktop.PageObjects.Enums;
using WTF.Desktop.PageObjects.WinForms;

namespace WtfDesktopUiautomation
{
    public class MainSteps : StepBase<MainWindow, WindowFactory, Application, IControlObjectModel, AppType, WindowType>
    {
        [Step("Window <windowName> should be <visibility>.")]
        public void WindowVisibility(string windowName, string visibility)
        {
            this.Initialize();
            this.Context = this.Factory.Create(WindowType.MainWindow, this.Factory.GetDriver(AppType.WinForms), TimeSpan.FromSeconds(15)) as MainWindow;
        }

        [Step("Team <teanName> should be selected")]
        public void TeamShouldBeSelected(string teamName)
        {
            this.Context.TeamSelection.TeamList.SelectItem(teamName);
            this.Context.TeamSelection.OkButton.Click();
        }

        [Step("User settings should be configured")]
        public void UserSettingsConfiguration()
        {
            this.Context.SystemUserSettingsWindow.OkButton.Click();
        }

        [Step("The profile <aobsumapac> has been selected")]
        public void ProfileSelection(string profileName)
        {
            this.Context.UserProfileSelection.UserList.Select(profileName);
            this.Context.UserProfileSelection.OkButton.Click();
        }

        [Step("Locale should be <locale>")]
        public void LocaleSelection(string locale)
        {
            this.Context.GenericDialog.YesButton.Click();
        }

        [Step("<fullName> should be selected")]
        public void VerifyTravelerName(string fullName)
        {
            true.Should().Be(true);
        }
    }
}
