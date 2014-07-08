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
        public void dial(string options)
        {
            string phoneNumber = JsonHelper.Deserialize<string[]>(options)[0];
			string contactName = JsonHelper.Deserialize<string[]>(options)[1];
			PhoneCallTask phoneCallTask = new PhoneCallTask();
            phoneCallTask.PhoneNumber = phoneNumber;
			phoneCallTask.DisplayName = contactName;
            phoneCallTask.Show();
            this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK, phoneNumber));
        }
    }
}
