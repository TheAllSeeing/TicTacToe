using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class card
    {
        private Button CardButton;
        private int x;
        private int y;
        public string content;
        public card(int x, int y, Button button)
        {
            this.x = x;
            this.y = y;
            CardButton = button;
            content = null;
            button.Text = "";
        }

    }
}
