using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordKooLearn
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonBeginRecord_Click(object sender, EventArgs e)
        {
            string dur = textBoxTimeDur.Text;
            string exe = "\"C:\\Program Files\\TechSmith\\Camtasia 9\\CamRecorder.exe\"";
            string arg = @"/record";
            string[] args = { exe, arg };
            StartProcess("cmd.exe", args);
            int min = int.Parse(dur) + 1;
            int sec = min * 60;
            int mileSec = sec * 1000;
            timer1.Interval = mileSec;
            timer1.Start();
        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            stop_record();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {

        }

        public bool StartProcess(string filename, string[] args)
        {
            try
            {
                string s = @" ";
                foreach (string arg in args)
                {
                    s = s   + arg + " ";
                }
                s = s.Trim();

                Process.Start(@"cmd", @"/c " + s);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动应用程序时出错！原因：" + ex.Message);
            }
            return false;
        }

        public void executeCmd(string filename, string[] args)
        {
            Process p = new Process();

            p.StartInfo.FileName = "cmd.exe";           //設定程序名
            p.StartInfo.Arguments = @"/c " + filename;    //設定程式執行參數
            p.StartInfo.UseShellExecute = true;        //關閉Shell的使用
            p.StartInfo.RedirectStandardInput = true;   //重定向標準輸入
            p.StartInfo.RedirectStandardOutput = true;  //重定向標準輸出
            p.StartInfo.RedirectStandardError = true;   //重定向錯誤輸出
            p.StartInfo.CreateNoWindow = true;          //設置不顯示窗口
            p.Start();   //啟動
        }

        private void stop_record()
        {
            string exe = @"C:\Program Files\TechSmith\Camtasia 9\CamtasiaStudio.exe";
            string arg = @"/stop";
            string[] args = { exe, arg };
            StartProcess("cmd.exe", args);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stop_record();
            timer1.Stop();
        }
    }
}
