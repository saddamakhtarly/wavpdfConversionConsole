using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    [Serializable]
  public  class WaveFileFormat
    {
        public string ChunkID { get; set; }
        public int ChunkSize { get; set; }
        public string Format { get; set; }

        public string SubChunk1ID { get; set; }
        public int SubChunk1Size { get; set; }
        public short AudioFormat { get; set; }
        public short NumChannels { get; set; }
        public int SampleRate { get; set; }
        public int ByteRate { get; set; }
        public short BlockAlign { get; set; }
        public short BitPerSample { get; set; }

        public string SubChunk2Id { get; set; }
        public int SubChunk2Size { get; set; }
    }
}
