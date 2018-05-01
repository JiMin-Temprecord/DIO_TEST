using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_CHECK
{
    public class bytecmd
    {
        /*
         * [0] - [1]: Read, [2]:Write
         * [1] - [2]: Fixed 
         * [2] - [0][1][2][3][4][5][6][0XFF]: Command status, error code
         * [3] - [3]: Fixed
         * [4] - [0][1][2][3] : DIO#
         * [5] - [0]: Input, [1]: Output 
         * [6] - [0]: Low, [1]: High
        */

        private byte[] _cmdread = { 0x01, 0x02, 0x00, 0x01, 0x00 };                 // Default for read DIO0 
        private byte[] _cmdwrite = { 0x02, 0x02, 0x00, 0x03, 0x00, 0x00, 0x00 };     // Default for Write DIO0

        private byte[] _stateDIO0 = { 0x01, 0x02, 0x00, 0x03, 0x00, 0x00, 0x00 };
        private byte[] _stateDIO1 = { 0x01, 0x02, 0x00, 0x03, 0x01, 0x00, 0x00 };
        private byte[] _stateDIO2 = { 0x02, 0x02, 0x00, 0x03, 0x02, 0x01, 0x00 };
        private byte[] _stateDIO3 = { 0x02, 0x02, 0x00, 0x03, 0x03, 0x01, 0x00 };

        public bytecmd() { }
        public byte[] getCmd(byte[] dio)
        {
            if (dio[0] == 0x01)
            {
                _cmdread[4] = dio[4];
                return _cmdread;
            }
            else
            {
                _cmdwrite[4] = dio[4];
                _cmdwrite[5] = dio[5];
                _cmdwrite[6] = dio[6];

                return _cmdwrite;
            }
        }
        public byte[] StateDIO0
        {
            get { return _stateDIO0; }
            set { _stateDIO0 = value; }
        }
        public byte[] StateDIO1
        {
            get { return _stateDIO1; }
            set { _stateDIO1 = value; }
        }
        public byte[] StateDIO2
        {
            get { return _stateDIO2; }
            set { _stateDIO2 = value; }
        }
        public byte[] StateDIO3
        {
            get { return _stateDIO3; }
            set { _stateDIO3 = value; }


        }
        public string errormessage(byte[] recieved)
        {
            string errormsg = "";

            if (recieved[2] != 0)
            {
                if (recieved[2] == 1)
                    errormsg = "Command Error";
                else if (recieved[2] == 2)
                    errormsg = "Version Error";
                else if (recieved[2] == 3)
                    errormsg = "Length Error";
                else if (recieved[2] == 4)
                    errormsg = "Operation Error";
                else if (recieved[2] == 5)
                    errormsg = "Packet too short";
                else if (recieved[2] == 6)
                    errormsg = "DIO number error";
                else
                    errormsg = "Unknown Error";
            }

            return errormsg;
        }
    }
}
