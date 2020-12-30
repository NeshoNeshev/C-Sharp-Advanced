using System;
using System.IO;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {

            byte[] bufer = new byte[1024];
            using FileStream reader = new FileStream("C:/Users/nnesh/source/repos/StreamFiles/4. Copy Binary File/bin/Debug/netcoreapp3.1/1.jpg", FileMode.Open);
            using FileStream writer = new FileStream("../../../copied.jpg", FileMode.Create);

            while (reader.CanRead)
            {
                int bytesRead = reader.Read(bufer, 0, bufer.Length);
                if (bytesRead == 0)
                {
                    break;
                }
                writer.Write(bufer, 0, bufer.Length);
            }
        }


    }

}
