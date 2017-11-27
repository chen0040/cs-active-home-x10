using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ActiveHomeScriptLib;

namespace ActiveHomeX10
{
    public class ActiveHomeController
    {
        private static ActiveHomeController mInstance = null;
        private static object mSyncLock = new object();

        public EventHandler<ActiveHomeRecvArgs> RecvAction;
        private ActiveHomeClass mActiveHome;

        public static ActiveHomeController Instance
        {
            get
            {
                if (mInstance == null)
                {
                    lock (mSyncLock)
                    {
                        mInstance = new ActiveHomeController();
                    }
                }
                return mInstance;
            }
        }

        public void TurnOn_RF(string address)
        {
            if(string.IsNullOrEmpty(address)) return;

            try
            {
                string strAction = "SENDRF";
                string command = "On";
                string strData = address + " " + command;

                object Code = mActiveHome.SendAction(strAction, strData, null, null);
            }
            catch
            {

            }
        }

        public void TurnOff_RF(string address)
        {
            if (string.IsNullOrEmpty(address)) return;

            string strAction = "SENDRF";
            string command = "Off";
            string strData = address + " " + command;

            object Code = mActiveHome.SendAction(strAction, strData, null, null);
        }

        public void TurnOn_PLC(string address)
        {
            if (string.IsNullOrEmpty(address)) return;
            try
            {
                string strAction = "SENDPLC";
                string command = "On";
                string strData = address + " " + command;

                object Code = mActiveHome.SendAction(strAction, strData, null, null);
            }
            catch
            {
            }
        }

        public enum ActiveHomeDeviceStatus
        {
            ON,
            OFF,
            DISCONNECTED
        }

        public ActiveHomeDeviceStatus Query_PLC(string address)
        {
            if (string.IsNullOrEmpty(address)) return ActiveHomeDeviceStatus.DISCONNECTED;

            ActiveHomeDeviceStatus status = ActiveHomeDeviceStatus.DISCONNECTED;
            try
            {
                string strAction = "QUERYPLC";
                string command = "On";
                string strData = address + " " + command;

                object Code = mActiveHome.SendAction(strAction, strData, null, null);
                int status_code = (int)Code;
                if (status_code == 0)
                {
                    status = ActiveHomeDeviceStatus.OFF;
                }
                else if (status_code == 1)
                {
                    status = ActiveHomeDeviceStatus.ON;
                }
            }
            catch
            {
            }
            return status;
        }

        public void TurnOff_PLC(string address)
        {
            if (string.IsNullOrEmpty(address)) return;
            try
            {
                string strAction = "SENDPLC";
                string command = "Off";
                string strData = address + " " + command;

                object Code = mActiveHome.SendAction(strAction, strData, null, null);
            }
            catch
            {

            }
        }

        public void TurnOn_PLC(string address, string data)
        {
            if (string.IsNullOrEmpty(address)) return;

            try
            {
                string strAction = "SENDPLC";
                string command = "On";
                string strData = address + " " + command;
                if (data.Length > 0)
                    strData += " " + data;

                object Code = mActiveHome.SendAction(strAction, strData, null, null);
            }
            catch
            {

            }
        }

        public void TurnOff_PLC(string address, string data)
        {
            if (string.IsNullOrEmpty(address)) return;

            try
            {
                string strAction = "SENDPLC";
                string command = "Off";
                string strData = address + " " + command;
                if (data.Length > 0)
                    strData += " " + data;

                object Code = mActiveHome.SendAction(strAction, strData, null, null);
            }
            catch
            {

            }
        }


        private static string getDataPath(string relativePath)
        {
            string dataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(dataDir, relativePath);
        }

        public static string GetAppRoot(out string error)
        {
            error = null;
            try
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
            }
            catch (IOException e)
            {
                error = "Can't get app root directory\n" + e.StackTrace;
            }
            return null;
        }

        public static string GetProgramFilePath(string relative_path, out string error)
        {
            string app_root = GetAppRoot(out error);
            return app_root + "\\" + relative_path;
        }

        public static string GetProgramFilePath(string relative_path)
        {
            string error;
            string app_root = GetAppRoot(out error);
            return app_root + "\\" + relative_path;
        }

        private ActiveHomeController()
        {
            string error;
            String ahScriptPath = GetProgramFilePath("ahscript.dll", out error);
            if (!System.IO.File.Exists(ahScriptPath))
            {
                File.WriteAllBytes(ahScriptPath, Properties.Resources.ahscript);
            }
            mActiveHome = new ActiveHomeClass();
            mActiveHome.RecvAction += new _DIActiveHomeEvents_RecvActionEventHandler(OnActiveHomeRecv);
        }

        private void OnActiveHomeRecv(object strAction, object Address, object Command, object Reserved1, object Reserved2, object Reserved3, object Reserved4)
        {
            string action = ((String)strAction);

            string description = "";
            if (((String)strAction).ToUpper() == "RECVPLC")
                description = "Recieved Powerline Command:";

            string address = Address.ToString().ToUpper();
            string command = Command.ToString().ToUpper();

            string reserved1 = "";
            string reserved2 = "";
            string reserved3 = "";
            string reserved4 = "";

            if (Reserved1.ToString().Length > 0)
                reserved1 = " " + Reserved1.ToString().ToUpper();

            if (Reserved2.ToString().Length > 0)
                reserved2 = " " + Reserved2.ToString().ToUpper();

            if (Reserved3.ToString().Length > 0)
                reserved3 = " " + Reserved3.ToString().ToUpper();

            if (Reserved3 != null && Reserved3.ToString().Length > 0)
                reserved4 = " " + Reserved3.ToString().ToUpper();

            if (RecvAction != null)
            {
                RecvAction(this, new ActiveHomeRecvArgs(action, address, command, reserved1, reserved2, reserved3,reserved4,description));
            }
        }
    }
}
