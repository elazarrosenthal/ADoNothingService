using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace ADoNothingService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            this.AutoLog = true;
            this.EventLog.BeginInit();
            this.EventLog.WriteEntry("Created Service");
            this.ServiceName = "ADoNothingService";
        }

        protected override void OnStart(string[] args)
        {
            this.EventLog.WriteEntry("Started Service 1234");
        }

        protected override void OnStop()
        {
            this.EventLog.WriteEntry("Stoped Service");
        }
    }
}
