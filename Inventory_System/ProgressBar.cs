using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class ProgressBar : Form
    {
        public string _UserID { get; set; }
        public string _User { get; set; }
        public string _CompanyName { get; set; }

        private login _login;
        public ProgressBar(login login, string userID, string user, string companyName)
        {
            InitializeComponent();
            _login = login;
            _UserID = userID;
            _User = user;
            _CompanyName = companyName;

            lblCompanyName.Text = _CompanyName.ToUpper();
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var ProgressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    ProgressReport.PercentComplete = index++ * totalProcess / 100;
                    progress.Report(ProgressReport);
                    Thread.Sleep(200); //used to simulate length of operation 

                }
            });
        }
        private async void ProgressBar_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 100; i++)
                list.Add(i.ToString());
            lblStatus.Text = "Working...";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = string.Format("Loading...{0}%", report.PercentComplete);
                progressBar1.Value = report.PercentComplete;
                progressBar1.Update();
            };
            await ProcessData(list, progress);
            //lblStatus.Text = "Ready";
            mainWindow main = new mainWindow(_login, _UserID, _User, _CompanyName);
            main.Show();
            this.Hide();
        }
    }
}
