using TestStack.White.UIItems.ListBoxItems;

namespace WTF.Desktop.Common.Helpers
{
    public static class ListHelper
    {
        public static void SelectItem(this ListBox control, string query)
        {
            for (var i = 0; i < control.Items.Count; i++)
            {
                if (control.Items[i].Text == query)
                    control.Items[i].Click();
            }
        }
    }
}
