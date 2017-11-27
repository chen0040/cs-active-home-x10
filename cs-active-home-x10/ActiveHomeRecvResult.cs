using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActiveHomeX10
{
    public class ActiveHomeRecvResult
    {
        protected string mResultActionType = "NA";
        public string ResultActionType
        {
            get { return mResultActionType; }
        }

        protected string mDescription = "";
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        protected string mAddress;
        public string Address
        {
            get { return mAddress; }
        }

        protected string mCommand;
        public string Command
        {
            get { return mCommand; }
        }

        protected string mReserved1;
        public string Reserved1
        {
            get { return mReserved1; }
        }

        protected string mReserved2;
        public string Reserved2
        {
            get { return mReserved2; }
        }

        protected string mReserved3;
        public string Reserved3
        {
            get { return mReserved3; }
        }

        protected string mReserved4;
        public string Reserved4
        {
            get { return mReserved4; }
        }

        public ActiveHomeRecvResult(string action_type, string address, string command, string reserved1, string reserved2, string reserved3, string reserved4)
        {
            mResultActionType = action_type;
            mAddress = address;
            mCommand = command;
            mReserved1 = reserved1;
            mReserved2 = reserved2;
            mReserved3 = reserved3;
            mReserved4 = reserved4;
        }

        
    }
}
