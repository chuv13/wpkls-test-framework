using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using WTF.Desktop.Common.Base;
using WTF.Desktop.Common.Contracts;

namespace WTF.Desktop.PageObjects.WinForms
{
    public class MainWindow : ControlObjectModelBase, IControlObjectModel
    {
        private UserProfileSelectionWindow _userProfileSelection = null;
        private SystemUserSettingsWindow _systemUserSettingsWindow = null;
        private GenericDialog _genericDialog = null;
        private TeamSelectionWindow _teamSelection = null;

        public SystemUserSettingsWindow SystemUserSettingsWindow
        {
            get
            {
                if (this._systemUserSettingsWindow == null)
                    this._systemUserSettingsWindow = new SystemUserSettingsWindow(this.Driver, "SelectUserDialog", TimeSpan.FromSeconds(15));
                return this._systemUserSettingsWindow;
            }
        }
        public UserProfileSelectionWindow UserProfileSelection
        {
            get
            {
                if (this._userProfileSelection == null)
                    this._userProfileSelection = new UserProfileSelectionWindow(this.Driver, "SystemUserSelection", TimeSpan.FromSeconds(15));
                return this._userProfileSelection;
            }
        }

        public GenericDialog GenericDialog
        {
            get
            {
                if (this._genericDialog == null)
                    this._genericDialog = new GenericDialog(this.Driver, "SyExDialog", TimeSpan.FromSeconds(15));
                return this._genericDialog;
            }
        }

        public TeamSelectionWindow TeamSelection
        {
            get
            {
                if (this._teamSelection == null)
                    this._teamSelection = new TeamSelectionWindow(this.Driver, "frmTeamSelection", TimeSpan.FromSeconds(15));
                return this._teamSelection;
            }
        }


        public ComboBox ClientList
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.ClientList) as ComboBox;
            }
        }

        public TextBox TravelerLastName
        {
            get
            {
                return this.FindElement(ExpressMainWindowElements.TravellerLastName) as TextBox;
            }
        }
    }
}
