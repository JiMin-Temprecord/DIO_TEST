using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TAD_CHECK
{
    public partial class TAD : Form
    {
        TcpClient pc;
        DIO DIO = new DIO();
        System.Windows.Forms.Timer timer;

        string TARGET;
        string PORT;

        byte[] wrtcmd;
        byte[] rcvcmd;
        bool isvalid;

        int initX = 0;
        int initY = 0;

        int mouseX = 0;
        int mouseY = 0;

        bool mouseDown = false;
        bool toggled = false;

        public TAD()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;
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
            timer.Tick += new EventHandler(DIO0_READ);
            timer.Enabled = true;
            reading_panel.Visible = true;
            DIO0_.Text = "";
        }

        private void DIO0_READ(object sender, EventArgs e)
        {
            while (toggled == false)
            {
                wrtcmd = DIO.getCmd(0);
                rcvcmd = IO(wrtcmd);
                isvalid = DIO.isValid(0, rcvcmd);

                ReadPrompt(0, rcvcmd, HILO0);
            }

            timer.Dispose();
            reading_panel.Visible = false;
            timer.Tick -= new EventHandler(DIO0_READ);
        }

        private void DIO1_READ_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(DIO1_READ);
            timer.Enabled = true;
            reading_panel.Visible = true;
            DIO1_.Text = "";
        }

        private void DIO1_READ(object sender, EventArgs e)
        {
            while (toggled == false)
            {
                wrtcmd = DIO.getCmd(1);
                rcvcmd = IO(wrtcmd);
                isvalid = DIO.isValid(1, rcvcmd);

                ReadPrompt(1, rcvcmd, HILO1);
            }

            timer.Dispose();
            reading_panel.Visible = false;
            timer.Tick -= new EventHandler(DIO1_READ);

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
            wrtcmd = DIO.getCmd(3);
            rcvcmd = IO(wrtcmd);
            isvalid = DIO.isValid(3, rcvcmd);

            ReadPrompt(3, rcvcmd, HILO3);
        }

        public void ReadPrompt (int dio, byte[] rcvcmd, Button HILO)
        {
            string message = "[DIO" + dio + "] ";
            string error = "[DIO" + dio + "] ";

            message = message + (rcvcmd[5] == 0 ? "[INPUT] " : "[OUTPUT] ");
            message = message + (rcvcmd[6] == 0 ? "[LOW]" : "[HIGH]");

            error = error + (dio < 2 ? "[INPUT] " : "[OUTPUT] ");
            error = error + "[" + HILO.Text + "]";

            if (message != error)
            {
                Read_Prompt.ForeColor = Color.Red;

                if (dio == 0)
                    DIO0_.Text = DIO0_.Text + "X";
                else if (dio == 1)
                    DIO1_.Text = DIO1_.Text + "X";

                toggled = true;
            }
            else
            {
                Read_Prompt.ForeColor = Color.White;
                toggled =  false;
            }

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

        private void IP_input_Enter(object sender, EventArgs e)
        {
                Connect_Click(sender, e);
        }

        private void IP_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Connect_Click(sender, e);
        }

        private void Port_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Connect_Click(sender, e);
        }

        private void TAD_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown= true;
            initX = e.X;
            initY = e.Y;
        }

        private void TAD_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - initX;
                mouseY = MousePosition.Y - initY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void TAD_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
