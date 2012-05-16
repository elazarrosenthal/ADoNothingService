using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;


namespace ADoNothingService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        
        public ProjectInstaller()
        {
             this.AfterInstall += new InstallEventHandler(ServiceInstaller_AfterInstall);

            InitializeComponent();
           
        }

        void ServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
        {
            ServiceController sc = new ServiceController("ADoNothingService");
            sc.Start();
        }
    }
}
