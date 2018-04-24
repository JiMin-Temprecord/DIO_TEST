using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Timers; 

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

        System.Timers.Timer timer;
        int loop = 0;

        public TAD()
        {
            InitializeComponent();
            
            timer = new System.Timers.Timer();
            timer.Interval = 2000;
            timer.AutoReset = true;
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
                        userPromptSetting("", false);
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
                this.Size = new Size(225, 360);
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

        private void DIO0_READ_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;

            if ((loop < 5))
            {
                wrtcmd = DIO.getCmd(0);
                rcvcmd = IO(wrtcmd);
                isvalid = DIO.isValid(0, rcvcmd);

                ReadPrompt(0, rcvcmd, HILO0);
                loop++;
            }
            else
            {
                loop = 0;
                timer.Enabled = false;
            }

        }

        private void DIO1_READ_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(1);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(1, rcvcmd);

            ReadPrompt(1, rcvcmd, HILO1);
        }

        private void DIO2_READ_Click(object sender, EventArgs e)
        {
            wrtcmd = DIO.getCmd(2);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(2, rcvcmd);

            ReadPrompt(2, rcvcmd, HILO2);
        }

        private void DIO3_READ_Click(object sender, EventArgs e)
        {
            timer.Elapsed += DIO3_READ;
            timer.Enabled = true;
        }

        public void DIO3_READ(object sender, ElapsedEventArgs e)
        {
            if (loop < 5)
            {
                wrtcmd = DIO.getCmd(3);
                rcvcmd = IO(wrtcmd);
                isvalid = DIO.isValid(3, rcvcmd);
                ReadPrompt(3, rcvcmd, HILO3);

                loop++;
            }
            else
            {
                loop = 0;
                timer.Dispose();
            }
        }

        public void ReadPrompt (int dio, byte[] rcvcmd, Button HILO)
        {
            string message = "[DIO" + dio + "] ";
            string error = "[DIO" + dio + "] ";

            if (rcvcmd[5] == 0)
                message = message + "[INPUT] ";
            else
                message = message + "[OUTPUT] ";

            if (rcvcmd[6] == 0)
                message = message + "[LOW]";
            else
                message = message + "[HIGH]";
            
            if (dio < 2)
                error = error + "[INPUT] ";
            else
                error = error + "[OUTPUT] ";

            if(HILO.Text == "HIGH")
                error = error + "[HIGH]";
            else
                error = error + "[LOW]";

            if (message != error)
                Read_Prompt.ForeColor = Color.Red;
            else
                Read_Prompt.ForeColor = Color.White;

           
            Read_Prompt.Text = "RECIEVED : " + message;
            Error_Prompt.Text = "EXPECTED : " + error;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HILO0_Click(object sender, EventArgs e)
        {
            HILO_STATE(HILO0);
        }

        private void HILO1_Click(object sender, EventArgs e)
        {
            HILO_STATE(HILO1);
        }

        private void HILO2_Click(object sender, EventArgs e)
        {
            HILO_STATE(HILO2);
        }

        private void HILO3_Click(object sender, EventArgs e)
        {
            HILO_STATE(HILO3);
        }

        private void HILO_STATE (Button HILO)
        {
            if (HILO.Text == "HIGH")
                HILO.Text = "LOW";
            else
                HILO.Text = "HIGH";
        }

    }
}
