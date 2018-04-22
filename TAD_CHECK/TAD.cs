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
        string TARGET;
        int PORT;
        bool number = false;
        int ipcount = 0;
        int decimalcount = 0;
        int state = 0;
        int totallength = 0;
        int[] decimalplace = new int[4];
        byte[] bytedata;
        int[] stateorder = new int[16];
        string recieved;
        string writedio3 = "00";
        string writedio4 = "00";

        TcpClient pc = new TcpClient();

        public TAD()
        {
            InitializeComponent();
        }


        private void PortKeyDown (object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9))
                number = true;
            else if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                number = true;
            else if (e.KeyCode == Keys.Back)
                number = true;
            else
                number = false;
        }

        private void PortKeyPress(object sender, KeyPressEventArgs e)
        {
            if (number == false)
                e.Handled = true;
        }


        private void OnKeyDownHandler(object sender, KeyEventArgs e) 
        {
            state = stateorder[totallength];
            Debug.WriteLine("state: " + state);

            if (state == 0)
            {
                if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    state = 1;
                    ipcount++;
                    totallength++;
                    number = true;
                }
                else if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
                {
                    state = 2;
                    ipcount++;
                    totallength++;
                    number = true;
                }
                else
                    number = false;

                stateorder[totallength] = state;
            }

            //we have enters the 2 hundreds
            else if (state == 1)
            {
                if (((e.KeyCode == Keys.Decimal) || (e.KeyCode == Keys.OemPeriod)) && decimalcount < 3)
                {
                    //check for decimal count and length
                    number = true;
                    state = 0;
                    ipcount = 0;
                    decimalplace[decimalcount] = totallength;
                    decimalcount++;
                    totallength++;
                }

                else if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D4) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad4))
                {
                    number = true;
                    state = 2;
                    ipcount++;
                    totallength++;
                }

                else if (((e.KeyCode == Keys.D5) || (e.KeyCode == Keys.NumPad5)) && ipcount < 3)
                {
                    number = true;
                    ipcount++;
                    totallength++;
                }

                else
                    number = false;

                stateorder[totallength] = state;
            }
            else if (state == 2)
            {
                if ((e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod) && decimalcount < 3)
                {
                    //check for decimal count and length
                    number = true;
                    state = 0;
                    ipcount = 0;
                    decimalplace[decimalcount] = totallength;
                    decimalcount++;
                    totallength++;
                }

                else if (((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)) && ipcount < 3)
                {
                    number = true;
                    ipcount++;
                    totallength++;
                }

                else
                    number = false;

                stateorder[totallength] = state;
            }

            if (e.KeyCode == Keys.Back)
            {
                number = true;
                if (totallength > 0)
                    totallength--;

                if (ipcount > 0)
                    ipcount--;

                if ((decimalcount > 0) && decimalplace[decimalcount - 1] == totallength)
                {
                    decimalcount--;
                    ipcount = 3;
                }
            }
        }

        private void OnKeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (number == false)
                e.Handled = true;

            Debug.WriteLine("IP Count: " + ipcount);
            Debug.WriteLine("Decimal Count: " + decimalcount);
            Debug.WriteLine("Total Length: " + totallength);
        }

        private void OnKeyUpHandler (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                Debug.WriteLine("Total Length: " + totallength);
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string[] split;

            pc = new TcpClient();

            if (Connect.Text == "CONNECT")
            {
                if (IP_input.Text != "")
                {
                    if (Port_input.Text != "")
                    {
                        try
                        {

                            TARGET = IP_input.Text;
                            PORT = Int32.Parse(Port_input.Text);

                            split = TARGET.Split('.');
                            if (split.Length == 4)
                            {
                                XIP.Visible = false;
                                XPORT.Visible = false;
                                
                                pc.Connect(TARGET, PORT);
                                this.Size = new Size(450, 360);
                                IP_input.BackColor = Color.LightGray;
                                Port_input.BackColor = Color.LightGray;
                                IP_input.Refresh();
                                Port_input.Refresh();
                                IP_input.Enabled = false;
                                Port_input.Enabled = false;
                                UserText.Text = "";
                                Connect.Text = "DISCONNECT";
                               
                                //Test.Visible = true;
                            }


                        }
                        catch (System.Net.Sockets.SocketException)
                        {
                            UserText.Text = "INVALID IP or PORT";
                            UserText.Refresh();
                            XIP.Visible = true;
                            XPORT.Visible = true;
                            pc.Close();
                        }
                    }
                    else
                    {
                        UserText.Text = "INVALID IP or PORT";
                        XIP.Visible = true;
                        XPORT.Visible = true;
                    }
                }
                else
                {
                    UserText.Text = "Please enter IP and PORT";
                    XIP.Visible = true;
                    XPORT.Visible = true;
                }
            }
            else
            {
                pc.Close();
                Connect.Text = "CONNECT";
                UserText.Text = "";
                IP_input.Enabled = true;
                Port_input.Enabled = true;
                IP_input.BackColor = Color.White;
                Port_input.BackColor = Color.White;
                number = false;
                DIO1_icon.Visible = false;
                DIO2_icon.Visible = false;
                DIO3_icon.Visible = false;
                DIO4_icon.Visible = false;

                this.Size = new Size(240, 360);
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

        private void HILO1_Click(object sender, EventArgs e)
        {
            if (READ1.Text == "WRITE")
            {
                if (HILO1.Text == "HIGH")
                    HILO1.Text = "LOW";
                else
                    HILO1.Text = "HIGH";
            }
        }

        private void HILO2_Click(object sender, EventArgs e)
        {
            if (READ2.Text == "WRITE")
            {
                if (HILO2.Text == "HIGH")
                    HILO2.Text = "LOW";
                else
                    HILO2.Text = "HIGH";
            }
        }

        private void HILO3_Click(object sender, EventArgs e)
        {
            if (HILO3.Text == "HIGH")
                HILO3.Text = "LOW";
            else
                HILO3.Text = "HIGH";
        }

        private void HILO4_Click(object sender, EventArgs e)
        {
            if (HILO4.Text == "HIGH")
                HILO4.Text = "LOW";
            else
                HILO4.Text = "HIGH";
        }

        private void READ1_Click(object sender, EventArgs e)
        {
            if (READ1.Text == "WRITE")
            {
                READ1.Text = "READ";
                HILO1.Text = "HIGH";
            }
            else
                READ1.Text = "WRITE";
        }

        private void READ2_Click(object sender, EventArgs e)
        {
            if (READ2.Text == "WRITE")
            {
                READ2.Text = "READ";
                HILO2.Text = "HIGH";
            }
            else
                READ2.Text = "WRITE";

        }

        private void READ3_Click(object sender, EventArgs e)
        {
            if (READ3.Text == "READ")
                READ3.Text = "WRITE";
            else
                READ3.Text = "READ";
        }

        private void READ4_Click(object sender, EventArgs e)
        {
            if (READ4.Text == "READ")
                READ4.Text = "WRITE";
            else
                READ4.Text = "READ";
        }

        private void WRITE1_Click(object sender, EventArgs e)
        {
            DIO1_icon.Visible = false;
            DIO1_icon.Refresh();

            if(HILO1.Text == "HIGH")
                if(READ1.Text == "READ")
                    bytedata = new byte[] {0x01, 0x02, 0x00, 0x01, 0x00 };
                else
                    bytedata = new byte[] {0x02, 0x02, 0x00, 0x03, 0x00, 0x00, 0x01};
            else
                bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x00, 0x00, 0x00 };

            recieved = IO(bytedata);

            if (READ1.Text == "READ")
            {
                if (recieved == "1203001")
                    DIO_ICON(1, true);

                else
                    DIO_ICON(1, false);
            }
            else
            {
                for (int i =0; i < bytedata.Length; i++)
                {
                    if (bytedata[i].ToString() == recieved[i].ToString())
                        DIO_ICON(1, true);
                    else
                        DIO_ICON(1, false);
                }
            }
                
        }

        private void WRITE2_Click(object sender, EventArgs e)
        {
            DIO2_icon.Visible = false;
            DIO2_icon.Refresh();

            if (HILO2.Text == "HIGH")
                if (READ2.Text == "READ")
                    bytedata = new byte[] { 0x01, 0x02, 0x00, 0x01, 0x01 };
                else
                    bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x01, 0x00, 0x01 };
            else
                bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x01, 0x00, 0x00 };

            recieved = IO(bytedata);

            if (READ2.Text == "READ")
            {
                if (recieved == "1203101")
                    DIO_ICON(2, true);

                else
                    DIO_ICON(2, false);
            }
            else
            {
                for (int i = 0; i < bytedata.Length; i++)
                {
                    if (bytedata[i].ToString() == recieved[i].ToString())
                        DIO_ICON(2, true);
                    else
                        DIO_ICON(2, false);
                }
            }
        }

        private void WRITE3_Click(object sender, EventArgs e)
        {
            DIO3_icon.Visible = false;
            DIO3_icon.Refresh();

            if (READ3.Text == "WRITE")
            {
                if (HILO3.Text == "LOW")
                {
                    bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x02, 0x01, 0x00 };
                    writedio3 = "00";
                }

                else
                {
                    bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x02, 0x01, 0x01 };
                    writedio3 = "01";
                }
            }
            else
            {
                if (writedio3 == "00")
                    HILO3.Text = "LOW";
                else
                    HILO3.Text = "HIGH";

                bytedata = new byte[] { 0x01, 0x02, 0x00, 0x01, 0x02 };
            }

            recieved = IO(bytedata);

            if (READ3.Text == "READ")
            {
                if (recieved == "1203210")
                {
                    writedio3 = "00";
                    DIO_ICON(3, true);
                }
                else if (recieved == "1203211")
                {
                    writedio3 = "01";
                    DIO_ICON(3, true);
                }
                else
                {
                    DIO_ICON(3, false);
                }
            }
            else
            {
                for (int i = 0; i < bytedata.Length; i++)
                {
                    if (bytedata[i].ToString() == recieved[i].ToString())
                        DIO_ICON(3, true);
                    else
                        DIO_ICON(3, false);
                }
            }

        }

        private void WRITE4_Click(object sender, EventArgs e)
        {
            DIO4_icon.Visible = false;
            DIO4_icon.Refresh();

            if (READ4.Text == "WRITE")
            {
                if (HILO4.Text == "LOW")
                {
                    writedio4 = "00";
                    bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x03, 0x01, 0x00 };
                }

                else
                {
                    writedio4 = "01";
                    bytedata = new byte[] { 0x02, 0x02, 0x00, 0x03, 0x03, 0x01, 0x01 };
                }
            }

            else
            {
                if (writedio4 == "00")
                    HILO4.Text = "LOW";
                else
                    HILO4.Text = "HIGH";

                bytedata = new byte[] { 0x01, 0x02, 0x00, 0x01, 0x03 };
            }

            recieved = IO(bytedata);
            Debug.WriteLine(recieved);

            if (READ4.Text == "READ")
            {
                if (recieved == "1203310")
                {
                    writedio4 = "00";
                    DIO_ICON(4, true);
                }

                else if (recieved == "1203311")
                {
                    writedio4 = "01";
                    DIO_ICON(4, true);
                }

                else
                {
                    DIO_ICON(4, false);
                }
            }
            else
            {
                for (int i = 0; i < bytedata.Length; i++)
                {
                    if (bytedata[i].ToString() == recieved[i].ToString())
                        DIO_ICON(4, true);
                    else
                        DIO_ICON(4, false);
                }
            }

        }

        private string IO (Byte[] data)
        {
            string send = string.Empty;
            string recieve = string.Empty;

            NetworkStream datastream = pc.GetStream();

            try
            {
                string stringdata = System.Text.Encoding.UTF8.GetString(data);

                datastream.Write(data, 0, data.Length);

                for (int i = 0; i < data.Length; i++)
                    send = send + data[i];

                data = new byte[256];

                int bytes = datastream.Read(data, 0, data.Length);
                
                for (int j = 0; j < bytes; j++)
                    recieve = recieve + data[j];
                
                return recieve;
            }
            catch (System.IO.IOException)
            {
                UserText.Text = "NO CONNECTION";
                datastream.Close();
                return recieve;
            }

        }

        private void DIO_ICON (int num, bool correct)
        {
            Label label;

            if (num == 1)
                label = DIO1_icon;
            else if (num == 2)
                label = DIO2_icon;
            else if (num == 3)
                label = DIO3_icon;
            else
                label = DIO4_icon;

            if (correct == true)
            {
                label.Text = "O";
                label.ForeColor = Color.LimeGreen;
            }
            else
            {
                label.Text = "X";
                label.ForeColor = Color.Red;
            }

            label.Refresh();
            label.Visible = true;

        }
    }
}
