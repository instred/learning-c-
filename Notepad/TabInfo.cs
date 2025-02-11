using System;
using System.Windows.Forms;


namespace Notepad
{
    public class TabInfo
    {
        public TabPage TabPage { get; set; }
        public bool IsSaved { get; set; }
        public int UntitledNumber { get; set; }
    }
}
