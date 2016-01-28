using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HD_Bot
{
    public partial class Frm_Honey : Form
    {
        String FailCatchURL = "http://www.earnhoney.com/videos/video/is_computer_programming_hard_to_learn_p6_1?start=1&channel=5&page=1";

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr h, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr h, uint dwVolume);

        public Frm_Honey()
        {
            InitializeComponent();
        }

        private void Frm_Honey_Load(object sender, EventArgs e)
        {
            // save the current volume
            uint _savedVolume;
            waveOutGetVolume(IntPtr.Zero, out _savedVolume);

            this.FormClosing += delegate
            {
                // restore the volume upon exit
                waveOutSetVolume(IntPtr.Zero, _savedVolume);
            };

            // mute
            waveOutSetVolume(IntPtr.Zero, 0);
            this.Web_Browser.Navigate("http://www.earnhoney.com");
            txt_Refresh.Text = FailCatchURL;

        }

        private void Tmr_Refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Web_Browser.Navigate(txt_Refresh.Text);
            }
            catch
            {
                txt_Refresh.Text = FailCatchURL;
                this.Web_Browser.Navigate(FailCatchURL);
            }

        }
    }
}
