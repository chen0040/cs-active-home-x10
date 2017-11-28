using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ActiveHomeX10.ActiveHomeController;

namespace ActiveHomeX10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveHomeController.Instance.RecvAction += (sender, e) =>
            {
                String strMsg = "";
                ActiveHomeRecvResult result = e.Result;
                string strAction = result.ResultActionType;
                

                if (strAction.ToUpper() == "RECVPLC")
                    strMsg += "Recieved Powerline Command:";

                strMsg += " " + result.Address.ToUpper();
                strMsg += " " + result.Command.ToUpper();

                if (result.Reserved1.Length > 0)
                    strMsg += " " + result.Reserved1.ToUpper();

                if (result.Reserved2.Length > 0)
                    strMsg += " " + result.Reserved2.ToUpper();

                if (result.Reserved3.Length > 0)
                    strMsg += " " + result.Reserved3.ToUpper();
                

                StatusTextBox.AppendText(strMsg + "\r\n");
            };
        }

        private void btnTurnOnLamp_Click(object sender, EventArgs e)
        {
            string status = ActiveHomeController.Instance.TurnOn_PLC(txtLampAddress.Text);
            StatusTextBox.AppendText(status + "\r\n");
        }

        private void btnTurnOffLamp_Click(object sender, EventArgs e)
        {
            string status = ActiveHomeController.Instance.TurnOff_PLC(txtLampAddress.Text);
            StatusTextBox.AppendText(status + "\r\n");
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            
            string address = txtLampAddress.Text;
            ActiveHomeDeviceStatus status_code = ActiveHomeController.Instance.Query_PLC(address);

            if (status_code == ActiveHomeDeviceStatus.OFF)
            {
                StatusTextBox.AppendText(address + " is OFF\r\n");
            }
            else if (status_code == ActiveHomeDeviceStatus.ON)
            {
                StatusTextBox.AppendText(address + " is ON\r\n");
            }
        }
    }
}
