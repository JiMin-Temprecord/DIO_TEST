using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_CHECK
{
    public class DIO
    {
        public int number;
        public string state;
        public string io;
        public bool toggled;
        public bool isfirstread;
        public byte[] expectedcmd;

        public DIO(int Number, string State, string IO, bool Toggled, bool isFirst, byte[] expectedCmd)
        {
            number = Number;
            state = State;
            io = IO;
            toggled = Toggled;
            isfirstread = isFirst;
            expectedcmd = expectedCmd;
        }
    }
}
