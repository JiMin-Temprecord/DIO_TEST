using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;

namespace TAD_CHECK
{
    public partial class TAD : Form
    {
        TcpClient pc;
        DIO DIO = new DIO();

        string TARGET;
        string PORT;

        byte[] wrtcmd;
        byte[] rcvcmd;
        bool isvalid;

        public TAD()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (Connect.Text == "CONNECT")
            {
                pc = new TcpClient();
                TARGET = IP_input.Text; 
                PORT = Port_input.Text;

                if ((IPisValid(TARGET)) && (PortisValid(PORT)))
                {
                    try
                    {
                        pc.Connect(TARGET, Int32.Parse(PORT));
                        this.Size = new Size(475, 350);
                        inputFieldSetting(Color.LightGray, "DISCONNECT", false);
                    }
                    catch (System.Net.Sockets.SocketException)
                    {
                        userPromptSetting("INVALID IP or PORT", true);
                        pc.Close();
                    }
                }
                else
                    userPromptSetting("INVALID IP or PORT", true);
            }
            else
            {
                pc.Close();
                this.Size = new Size(240, 360);
                inputFieldSetting(Color.White, "CONNECT", true);

                Read_Prompt.Text = "[DIO#] [INPUT/OUTPUT] [LOW/HIGH]";
                Error_Prompt.Text = "";
            }  
        }

        private bool IPisValid(string ip)
        {
            string[] segmentip = new string[4];

            segmentip = ip.Split('.');

            if (segmentip.Length == 4)
            {
                for (int i = 0; i < segmentip.Length; i++)
                {
                    if (isDigitOnly(segmentip[i]))
                    {
                        if (Convert.ToInt32(segmentip[i]) > 256)
                            return false;
                    }
                    else
                        return false;
                }
            }

            return true;
        }

        private bool PortisValid(string port)
        {
            if (isDigitOnly(port))
            {
                if(Int32.Parse(port)<65535)
                    return true;
            }

            return false;
        }

        private bool isDigitOnly(string str)
        {
            foreach( char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void inputFieldSetting (Color color, String connect, bool enable)
        {
            IP_input.BackColor = color;
            IP_input.Enabled = enable;
            IP_input.Refresh();

            Port_input.BackColor = color;
            Port_input.Enabled = enable;
            Port_input.Refresh();

            Connect.Text = connect;
        }

        private void userPromptSetting (String userprompt, bool isvisible)
        {
            UserText.Text = userprompt;
            XIP.Visible = isvisible;
            XPORT.Visible = isvisible;
        }

        private byte[] IO(Byte[] data)
        {
            NetworkStream datastream = pc.GetStream();
            byte[] recieve = { };

            try
            {
                datastream.Write(data, 0, data.Length);
                data = new byte[7];
                datastream.Read(data, 0, data.Length);
                recieve = data;

                return recieve;
            }
            catch (System.IO.IOException)
            {
                UserText.Text = "NO CONNECTION";
                datastream.Close();
                return recieve;
            }

        }

        private void HILO3_Click(object sender, EventArgs e)
        {
            if (HILO2.Text == "LOW")
                HILO2.Text = "HIGH";
            else
                HILO2.Text = "LOW";
        }

        private void HILO4_Click(object sender, EventArgs e)
        {
            if (HILO3.Text == "LOW")
                HILO3.Text = "HIGH";
            else
                HILO3.Text = "LOW";
        }

        private void DIO2_WRITE_CLICK(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(2, DIO2_WRITE.Text, HILO2.Text);
            rcvcmd = IO(wrtcmd);
            DIO.isValid(2, rcvcmd, DIO2_WRITE.Text, HILO2.Text);
        }

        private void DIO3_WRITE_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(3, DIO3_WRITE.Text, HILO3.Text);
            rcvcmd = IO(wrtcmd);
            DIO.isValid(3, rcvcmd, DIO3_WRITE.Text, HILO3.Text);
        }

        private void DIO0_READ_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(0);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(0, rcvcmd);

            ReadPrompt(0, isvalid, rcvcmd);
        }

        private void DIO1_READ_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(1);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(1, rcvcmd);

            ReadPrompt(1, isvalid, rcvcmd);
        }

        private void DIO2_READ_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(2);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(2, rcvcmd);

            ReadPrompt(2, isvalid, rcvcmd);
        }

        private void DIO3_READ_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(3);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(3, rcvcmd);

            ReadPrompt(3, isvalid, rcvcmd);
        }

        private void ReadPrompt (int dio, bool isValid, byte[] rcvcmd)
        {
            Read_Prompt.Text = "";
            Error_Prompt.Text = "";

            string message = "RECIEVED : [DIO" + dio + "] ";
            string error = "EXPECTED : [DIO" + dio + "] ";

            if (rcvcmd[5] == 0)
                message = message + "[INPUT] ";
            else
                message = message + "[OUTPUT] ";

            if (rcvcmd[6] == 0)
                message = message + "[LOW]";
            else
                message = message + "[HIGH]";

            Read_Prompt.Text = message;

            if(isvalid != true)
            {
                if (dio < 2)
                    error = error + "[INPUT] [HIGH] ";
                else if (dio == 2)
                {
                    error = error + "[OUTPUT] ";
                    if (DIO.StateDIO2 == 0)
                        error = error + "[LOW]";
                    else
                        error = error + "[HIGH]";
                }
                else
                {
                    error = error + "[OUTPUT] ";

                    if (DIO.StateDIO3 == 0)
                        error = error + "[LOW]";
                    else
                        error = error + "[HIGH]";
                }

                Error_Prompt.Text = error;
            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            pc.Close();
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
