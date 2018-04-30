using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TAD_CHECK
{
    public partial class TAD : Form
    {
        TcpClient pc;
        bytecmd bytecmd = new bytecmd();
        System.Windows.Forms.Timer timer;

        string TARGET;
        string PORT;

        byte[] wrtcmd;
        byte[] rcvcmd;

        int initX = 0;
        int initY = 0;

        int mouseX = 0;
        int mouseY = 0;

        bool mouseDown = false;
        bool stopped = false;

        DIO dio0;
        DIO dio1;
        DIO dio2;
        DIO dio3;

        public TAD()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500;

            dio0 = new DIO(0, "LOW", "INPUT", false, true, bytecmd.StateDIO0);
            dio1 = new DIO(1, "LOW", "INPUT", false, true, bytecmd.StateDIO1);
            dio2 = new DIO(2, "LOW", "OUTPUT", false, true, bytecmd.StateDIO2);
            dio3 = new DIO(3, "LOW", "OUTPUT", false, true, bytecmd.StateDIO3);
        }
        
        private void DIO0_READ_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(DIO0_READ);
            timer.Enabled = true;
            reading_panel.Visible = true;
            DIO0_.Text = "INPUT 1: ";
            DIO0_.Visible = false;

        }

        private void DIO0_READ(object sender, EventArgs e)
        {
            if (!stopped)
            {
                wrtcmd = bytecmd.getCmd(dio0.expectedcmd);
                rcvcmd = IO(wrtcmd);

                if (dio0.isfirst)
                {
                    dio0.expectedcmd = rcvcmd;
                    dio0.isfirst = false;
                    dio0.state = (dio0.expectedcmd[6] == 0) ? "LOW" : "HIGH";
                }

                ReadPrompt(dio0, rcvcmd);
            }

            else
            {
                timer.Dispose();
                reading_panel.Visible = false;
                timer.Tick -= new EventHandler(DIO0_READ);
            }
        }

        private void DIO1_READ_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(DIO1_READ);
            timer.Enabled = true;
            reading_panel.Visible = true;
            DIO1_.Text = "INPUT 2: ";
            DIO1_.Visible = false;
            stopped = false;
        }

        private void DIO1_READ(object sender, EventArgs e)
        {
            if (!stopped)
            {
                wrtcmd = bytecmd.getCmd(dio1.expectedcmd);
                rcvcmd = IO(wrtcmd);

                if (dio1.isfirst)
                {
                    dio1.expectedcmd = rcvcmd;
                    dio1.isfirst = false;
                    dio1.state = (dio1.expectedcmd[6] == 0) ? "LOW" : "HIGH";
                }

                ReadPrompt(dio1, rcvcmd);
            }

            else
            {
                timer.Dispose();
                reading_panel.Visible = false;
                timer.Tick -= new EventHandler(DIO1_READ);
            }
        }

        private void READ_BOTH_Click(object sender, EventArgs e)
        {
            DIO0_READ_Click(sender, e);
            DIO1_READ_Click(sender, e);
        }

        private void HILO2_Click(object sender, EventArgs e)
        {
            if (HILO2.Text == "HIGH")
                HILO2.Text = "LOW";
            else
                HILO2.Text = "HIGH";
        }

        private void HILO3_Click(object sender, EventArgs e)
        {
            if (HILO3.Text == "HIGH")
                HILO3.Text = "LOW";
            else
                HILO3.Text = "HIGH";
        }

        private void WRITE2_Click(object sender, EventArgs e)
        {
            if(HILO2.Text == "HIGH")
            {
                dio2.state = "HIGH";
                dio2.expectedcmd[6] = 0x01;
            }
            else
            {
                dio2.state = "LOW";
                dio2.expectedcmd[6] = 0x00;
            }


            wrtcmd = bytecmd.getCmd(dio2.expectedcmd);
            IO(wrtcmd);
        }

        private void WRITE3_Click(object sender, EventArgs e)
        {
            if (HILO3.Text == "HIGH")
            {
                dio3.state = "HIGH";
                dio3.expectedcmd[6] = 0x01;
            }
            else
            {
                dio3.state = "LOW";
                dio3.expectedcmd[6] = 0x00;
            }

            wrtcmd = bytecmd.getCmd(dio3.expectedcmd);
            IO(wrtcmd);
        }
        
        public void ReadPrompt (DIO dio, byte[] rcvcmd)
        {
            string message = "[DIO" + dio.number + "] ";
            string error = "[DIO" + dio.number + "] ";

            message = message + (rcvcmd[5] == 0 ? "[INPUT] " : "[OUTPUT] ");
            message = message + (rcvcmd[6] == 0 ? "[LOW]" : "[HIGH]");

            error = error + "[" + dio.io + "] ";
            error = error + "[" + dio.state + "]";

            if (message != error)
                dio.toggled = true;
            else
            {
                if(dio.toggled == true)
                {
                    Read_Prompt.ForeColor = Color.Red;

                    if (dio.number == 0)
                    {
                        DIO0_.Text = DIO0_.Text + "X";
                        DIO0_.Visible = true;
                    }

                    else if (dio.number == 1)
                    {
                        DIO1_.Text = DIO1_.Text + "X";
                        DIO1_.Visible = true;
                    }

                    dio.toggled = false;
                }
                else
                    Read_Prompt.ForeColor = Color.White;
            }

            Read_Prompt.Text = "RECIEVED : " + message;
            Error_Prompt.Text = "EXPECTED : " + error;

            Console.WriteLine(Read_Prompt.Text);
            Console.WriteLine(Error_Prompt.Text);
            Console.WriteLine("TOGGLED: " + dio.toggled);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                this.Size = new Size(225, 350);
                inputFieldSetting(Color.White, "CONNECT", true);

                Read_Prompt.Text = "[DIO#] [INPUT/OUTPUT] [LOW/HIGH]";
                Error_Prompt.Text = "";
            }
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            stopped = true;
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
                if (Int32.Parse(port) < 65535)
                    return true;
            }

            return false;
        }

        private bool isDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void inputFieldSetting(Color color, String connect, bool enable)
        {
            IP_input.BackColor = color;
            IP_input.Enabled = enable;
            IP_input.Refresh();

            Port_input.BackColor = color;
            Port_input.Enabled = enable;
            Port_input.Refresh();

            Connect.Text = connect;
        }

        private void userPromptSetting(String userprompt, bool isvisible)
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
