using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezinjectv1
{

    public partial class main : Form
    {

        string fname = Path.GetTempPath() + "githubdemo.dll";
        string libname = Path.GetTempPath() + "ezinject.dll";

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public main()
        {
            InitializeComponent();

            Directory.SetCurrentDirectory(Path.GetTempPath());

            if (!File.Exists(libname))
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ezinject.Resources.ezinject.dll");
                FileStream fileStream = new FileStream(libname, FileMode.CreateNew);
                for (int i = 0; i < stream.Length; i++)
                    fileStream.WriteByte((byte)stream.ReadByte());
                fileStream.Close();
            }

        }

        [DllImport("ezinject.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int mainFunction(string szDllFile);

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void topmenu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void inject_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fname))
            {
                Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ezinject.Resources.demo.dll");
                FileStream fileStream = new FileStream(fname, FileMode.CreateNew);
                for (int i = 0; i < stream.Length; i++)
                    fileStream.WriteByte((byte)stream.ReadByte());
                fileStream.Close();
            }

            Process[] pname = Process.GetProcessesByName("csgo");
            if (pname.Length == 0)
            {
                DialogResult result = MessageBox.Show("CS:GO is not started. Do you want to start CS:GO?", "info", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var url = "steam://rungameid/730";
                    var psi = new ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = url;
                    Process.Start(psi);
                }
            }
            else
            {
                mainFunction(fname);
                MessageBox.Show("successfully injected. have fun. presented by zocheat.me", "info");

            }
        }

        private void youtube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCo_u0CNc5NxnoEbfOR1QUMg");
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start("http://zocheat.me");
        }
    }
}
