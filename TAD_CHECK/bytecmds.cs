using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_CHECK
{
    public class DIO
    {
        /*
         * [0] - [0]: Read, [1]:Write
         * [1] - [2]: Fixed 
         * [2] - [0][1][2][3][4][5][6][0XFF]: Command status, error code
         * [3] - [3]: Fixed
         * [4] - [0][1][2][3] : DIO#
         * [5] - [0]: Input, [1]: Output 
         * [6] - [0]: Low, [1]: High
        */

        private byte[] _cmdread = { 0x01, 0x02, 0x00, 0x01, 0x00 };                 // Default for read DIO0 
        private byte[] _cmdwrite = { 0x02, 0x02, 0x00, 0x03, 0x00, 0x00, 0x00 };     // Default for Write DIO0
        private byte[] _expected = { 0x01, 0x02, 0x00, 0x03, 0x00, 0x00, 0x00 };     // Deafault reply for [DIO0][INPUT]

        private bool firstread2 = false;
        private bool firstread3 = false;

        private byte _stateDIO2 = 0x00;
        private byte _stateDIO3 = 0x00;

        public DIO() { }

        public byte[] getCmd(int dio, string RDWR = "READ", string HILO = "HIGH")
        {
            if (RDWR == "READ")
            {
                _cmdread[4] = byte.Parse(dio.ToString());
                return _cmdread;
            }
            else
            {
                _cmdwrite[4] = byte.Parse(dio.ToString());

                if (dio < 2)
                {
                    _cmdwrite[5] = 0x00;
                    _cmdwrite[6] = 0x01;
                }

                else if (dio == 2)
                {
                    if (HILO == "HIGH")
                    {
                        _cmdwrite[5] = 0x01;
                        _cmdwrite[6] = 0x01;
                        _stateDIO2 = _cmdwrite[6];
                    }
                    else
                    {
                        _cmdwrite[5] = 0x01;
                        _cmdwrite[6] = 0x00;
                        _stateDIO2 = _cmdwrite[6];
                    }
                }

                else
                {
                    if (HILO == "HIGH")
                    {
                        _cmdwrite[5] = 0x01;
                        _cmdwrite[6] = 0x01;
                        _stateDIO3 = _cmdwrite[6];
                    }
                    else
                    {
                        _cmdwrite[5] = 0x01;
                        _cmdwrite[6] = 0x00;
                        _stateDIO3 = _cmdwrite[6];
                    }
                }

                return _cmdwrite;
            }
        }

        public bool isValid(int dio, byte[] recieved, string RDWR = "READ", string HILO = "HIGH")
        {
            _expected[4] = byte.Parse(dio.ToString());

            if (dio < 2)
            {
                _expected[5] = 0x00;
                _expected[6] = 0x01;
            }

            else if (dio == 2)
            {
                _expected[5] = 0x01;

                if (firstread2 == false)
                {
                    _stateDIO2 = recieved[6];
                    firstread2 = true;
                }
                _expected[6] = _stateDIO2;
            }
            else if (dio == 3)
            {
                _expected[5] = 0x01;

                if (firstread3 == false)
                {
                    _stateDIO3 = recieved[6];
                    firstread3 = true;
                }

                _expected[6] = _stateDIO3;
            }

            else
            {
                _cmdwrite[6] = 0x00;
                _expected[6] = 0x00;
            }

            Console.WriteLine("RECIEVED: " + BitConverter.ToString(recieved));
            Console.WriteLine("EXPECTED: " + BitConverter.ToString(_expected));

            if (RDWR == "READ")
            {
                if (_expected.SequenceEqual(recieved))
                    return true;
                else
                    return false;
            }
            else
            {
                if (_cmdwrite.SequenceEqual(recieved))
                    return true;
                else
                    return false;
            }
        }

        public byte StateDIO2
        {
            get { return _stateDIO2; }
            set { _stateDIO2 = value; }
        }

        public byte StateDIO3
        {
            get { return _stateDIO3; }
            set { _stateDIO3 = value; }


        }
    }
}
