using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using Microsoft.Phone.Tasks;

namespace Cordova.Extension.Commands
{
    public class Dialer : BaseCommand
    {
        public class DialerParameters
        {
            public string number { get; set; }
        }
        public void dial(string options)
        {
            DialerParameters phoneNumber = options;//JsonHelper.Deserialize<DialerParameters>(options);
            PhoneCallTask phoneCallTask = new PhoneCallTask();
            phoneCallTask.PhoneNumber = phoneNumber.number;
            phoneCallTask.Show();
            this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK, phoneNumber.number));
        }
    }
}
