using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>

namespace TheFancyPlayer

{

    class NotificationClientImplementation : NAudio.CoreAudioApi.Interfaces.IMMNotificationClient
    {
 
        public void OnDefaultDeviceChanged(DataFlow dataFlow, Role deviceRole, string defaultDeviceId) // When default output device changed this method will run.
        {         
            Delegate MainFormDelegate = new MainForm.deviceChangedDelegate(Program.mainForm.player.whenOutputDeviceChanged); // We use delegate because we are changing a seperate thread's form elements from this thread. 
            Program.mainForm.Invoke(MainFormDelegate);
            return;
        }

        public void OnDeviceAdded(string deviceId)
        {
     
        }

        public void OnDeviceRemoved(string deviceId)
        {
            Delegate MainFormDelegate = new MainForm.deviceChangedDelegate(Program.mainForm.player.whenOutputDeviceChanged); // We use delegate because we are changing a seperate thread's form elements from this thread. 
            Program.mainForm.Invoke(MainFormDelegate);
            return;
        }

        public void OnDeviceStateChanged(string deviceId, DeviceState newState)
        {

        }

        public NotificationClientImplementation()
        {
            //_realEnumerator.RegisterEndpointNotificationCallback();
            if (System.Environment.OSVersion.Version.Major < 6)
            {
                throw new NotSupportedException("This functionality is only supported on Windows Vista or newer.");
            }
        }

        public void OnPropertyValueChanged(string deviceId, PropertyKey propertyKey)
        {
            //Do some Work
            //fmtid & pid are changed to formatId and propertyId in the latest version NAudio
            Console.WriteLine("OnPropertyValueChanged: formatId --> {0}  propertyId --> {1}", propertyKey.formatId.ToString(), propertyKey.propertyId.ToString());
        }



    }
}
