using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;


namespace max_payne_loader
{
    public partial class Form1 : Form
    {
        SoundPlayer backsound = new SoundPlayer(Properties.Resources.music);
        Process Payne = new Process();
        String key = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            backsound.PlayLooping();
        }


        private void btn_loader_Click(object sender, EventArgs e)
        {
            backsound.Stop();
            key = "";
            if (chbx_nodlg.Checked)
            {
                key += " -nodialog ";
            }
            if (chbx_asdeveloper.Checked)
            {
                key += " -developer ";
            }
            if (chbx_skipstrtup.Checked)
            {
                key += " -skipstartup ";
            }
            if (chbx_screenshot.Checked)
            {
                key += " -screenshot ";
            }
            if (chbx_runinwindow.Checked)
            {
                key += " -window ";
            }
            if (chbx_no3d.Checked)
            {
                key += " -disable3dpreloads ";
            }
            Payne.StartInfo.Arguments = key;
            //MessageBox.Show(key);
            Payne.StartInfo.FileName = "MaxPayne.exe";
            try
            {
                Payne.Start();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(" The Max Payne™ Loader could not find the file 'MaxPayne.exe'! Please specify the path to yourself.", "File not found...", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
                DialogResult res = ofdpain.ShowDialog();
                if (res == DialogResult.OK)
                {
                    try
                    {
                        Payne.StartInfo.FileName = ofdpain.FileName;
                        Payne.Start();
                    }
                    catch (System.Exception exs)
                    {
                        MessageBox.Show(exs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Max Payne™ is not installed on your PC! At first, You must install the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nfo_Click(object sender, EventArgs e)
        {
            about2 form2 = new about2();
            form2.ShowDialog();
        }

        private void btn_howtouse_Click(object sender, EventArgs e)
        {
            frm_howtouse form3 = new frm_howtouse();
            form3.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }

        private void pct_logo_MouseDown(object sender, MouseEventArgs e)
        {
             
        }

        private void pct_logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.rockstargames.com/maxpayne/");
        }

        private void ofdpain_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

      
    }
}
