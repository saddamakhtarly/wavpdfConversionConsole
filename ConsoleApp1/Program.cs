using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serilization
            //string path = @"C:\Users\Saddam Akhtar\Desktop\WAV\saddam.wav";
            ////Student s = new Student(1, "saddam");
            //Student s = new Student(2, "Zain");
            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, s);
            //stream.Close();
            //Console.ForegroundColor = System.ConsoleColor.Red;
            //Console.WriteLine("File saved in " + path);
            //Console.ReadLine();
            #endregion


            #region Deserilization
            //string path = @"C:\Users\Saddam Akhtar\Desktop\WAV\saddam.wav";
            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //Student s = (Student)formatter.Deserialize(stream);
            //Console.ForegroundColor = System.ConsoleColor.Green;
            //Console.WriteLine("Id :" + s.id);
            //Console.WriteLine("Name :" + s.name);
            //Console.ReadLine();
            #endregion


            #region Deserilization
            //string path = @"D:\Brain\Task Wav\Documents\WavFile.wav";
            //FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            //BinaryFormatter formatter = new BinaryFormatter();
            //WaveFileFormat s = (WaveFileFormat)formatter.Deserialize(stream);
            //Console.ForegroundColor = System.ConsoleColor.Green;

            //Console.WriteLine("Id :" + s.ChunkID);
            //Console.WriteLine("Name :" + s.ChunkSize);
            //Console.WriteLine("Name :" + s.Format);

            //Console.WriteLine("Id :" + s.SubChunk1ID);
            //Console.WriteLine("Name :" + s.SubChunk1Size);
            //Console.WriteLine("Name :" + s.AudioFormat);
            //Console.WriteLine("Id :" + s.NumChannels);
            //Console.WriteLine("Name :" + s.SampleRate);
            //Console.WriteLine("Name :" + s.ByteRate);
            //Console.WriteLine("Name :" + s.BlockAlign);
            //Console.WriteLine("Name :" + s.BitPerSample);

            //Console.WriteLine("Name :" + s.SubChunk2Id);
            //Console.WriteLine("Name :" + s.SubChunk2Size);

            //Console.ReadLine();
            #endregion

            #region Deserilization
            //string path = @"C:\Users\Saddam Akhtar\Desktop\WAV\saddam.wav";
            string path = @"C:\Users\Saddam Akhtar\Desktop\WAV\Console-App\WavFile1";
            string v = "WavFile1.wav";
            WavFile wavFile = new WavFile(v);
            double[] L=new double[1];
            double[] R = new double[44];

            wavFile.readData(ref L,ref R);
            


            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine("Id :" + s.id);
            Console.WriteLine("Name :" + s.name);
            Console.ReadLine();
            #endregion

        }
    }
}
