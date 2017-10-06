using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLoginWindow
{
    public class OwnerCenteredForm : Form
    {
        /// <summary>
        /// Call this method in derived classes to fire events and move forms to center of their owners.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CenterToOwner();
        }

        /// <summary>
        /// Moves the form to center of its owner
        /// </summary>
        private void CenterToOwner()
        {
            if (Owner != null)
            {
                Location = Owner.Location + new Size((Owner.Size.Width - Size.Width) / 2,
                                                     (Owner.Size.Height - Size.Height) / 2);
            }
            else
            {
                CenterToScreen();
            }
        }
    }
}
