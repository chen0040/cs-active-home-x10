using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveHomeX10
{
    public class ActiveHomeRecvArgs : EventArgs
    {
        protected ActiveHomeRecvResult mResult;
        public ActiveHomeRecvArgs(string action_type, string address, string command, string reserved1, string reserved2, string reserved3, string reserved4, string description)
        {
            mResult=new ActiveHomeRecvResult(action_type, address, command, reserved1, reserved2, reserved3, reserved4);
            mResult.Description=description;
        }

        public ActiveHomeRecvResult Result
        {
            get { return mResult; }
        }
    }
}
