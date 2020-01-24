using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JRaidGui
{
    public class Dragger
    {
        // Token: 0x0600000A RID: 10
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        // Token: 0x0600000B RID: 11
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        // Token: 0x0600000C RID: 12 RVA: 0x000022F6 File Offset: 0x000004F6
        public Dragger(Form form)
        {
            this.handle = form.Handle;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x0000230A File Offset: 0x0000050A
        public void Add(Control panel)
        {
            panel.MouseDown += this.WindowDrag;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000231E File Offset: 0x0000051E
        private void WindowDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragger.ReleaseCapture();
                Dragger.SendMessage(this.handle, 161, new IntPtr(2), IntPtr.Zero);
            }
        }

        // Token: 0x04000005 RID: 5
        private IntPtr handle;
    }
}
