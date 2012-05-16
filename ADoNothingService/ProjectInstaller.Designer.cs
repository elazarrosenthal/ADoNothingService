namespace ADoNothingService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ServiceProcess.ServiceInstaller ADoNothingServiceINstaller;
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            ADoNothingServiceINstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ADoNothingServiceINstaller
            // 
            ADoNothingServiceINstaller.Description = "Used for testing service start stop ...";
            ADoNothingServiceINstaller.DisplayName = "ADoNothingService";
            ADoNothingServiceINstaller.ServiceName = "ADoNothingService";
            ADoNothingServiceINstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.serviceProcessInstaller1.Installers.AddRange(new System.Configuration.Install.Installer[] {
            ADoNothingServiceINstaller});
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
    }
}