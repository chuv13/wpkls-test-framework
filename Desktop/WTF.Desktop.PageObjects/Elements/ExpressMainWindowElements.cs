using WTF.Core.Base;
using WTF.Core.Contracts;
using WTF.Core.Enums;

namespace WTF.Desktop.PageObjects
{
    public class ExpressMainWindowElements : TypeSafeEnumBase, ITypeSafeEnum
    {
        public static ExpressMainWindowElements ChangeTeamButton { get; } = new ExpressMainWindowElements(0, "SystemUserSettings", SelectorType.ClassName, "Change Team", "The User Settings Window");
        public static ExpressMainWindowElements OkButton { get; } = new ExpressMainWindowElements(1, "OkButton", SelectorType.AutomationId, "btnOK", "The User Settings Window");
        public static ExpressMainWindowElements OkButton2 { get; } = new ExpressMainWindowElements(2, "OkButton", SelectorType.AutomationId, "OKButton", "The User Settings Window");

        public static ExpressMainWindowElements UserList { get; } = new ExpressMainWindowElements(3, "UserList", SelectorType.AutomationId, "lbSystemUserList", "The User Settings Window");
        public static ExpressMainWindowElements YesButton { get; } = new ExpressMainWindowElements(4, "YesButton", SelectorType.AutomationId, "YesBtn", "The User Settings Window");
        public static ExpressMainWindowElements NoButton { get; } = new ExpressMainWindowElements(5, "NoButton", SelectorType.AutomationId, "NoBtn", "The User Settings Window");
        public static ExpressMainWindowElements TeamList { get; } = new ExpressMainWindowElements(6, "TeamList", SelectorType.AutomationId, "chklistTeam", "The User Settings Window");
        public static ExpressMainWindowElements ClientList { get; } = new ExpressMainWindowElements(7, "ClientList", SelectorType.AutomationId, "ccboCompany", "The User Settings Window");
        public static ExpressMainWindowElements TravellerLastName { get; } = new ExpressMainWindowElements(8, "TravellerLastName", SelectorType.AutomationId, "ctxtPortraitTravellerLastName", "The User Settings Window");
        public static ExpressMainWindowElements WindowName { get; } = new ExpressMainWindowElements(9, "frmMain", SelectorType.AutomationId, "Main Window", "Power Express!");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        public ExpressMainWindowElements(int id, string name, SelectorType type, string value, string description) : base(id, name, type, value, description)
        {
        }
    }
}
