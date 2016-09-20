using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace PycharmTrialReset
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            
            InitializeComponent();
        }
       // Timer timer1;
        
        protected override void OnStart(string[] args)
        {
           /* timer1 = new Timer();
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            timer1.Enabled = true;
            timer1.Interval = 10000;
            Setting.Log("Start Service: " + DateTime.Now.Date.ToShortDateString());
            */
            Setting.process();
        }

        void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Setting.process();
        }

        protected override void OnStop()
        {
            Setting.Log("Stop Service: " + DateTime.Now.Date.ToShortDateString());
            //timer1.Enabled = false;
        }
    }
}
