using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace くうのちんこ爆破サービス
{
    public partial class くうのちんこ : ServiceBase
    {
        public くうのちんこ()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            eventLog.WriteEntry("サービスが起動しました(´・ω・｀)");
        }

        protected override void OnStop()
        {
            eventLog.WriteEntry("サービスが停止しました(´・ω・｀)");
        }

        private void eventLog_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }
    }
}
