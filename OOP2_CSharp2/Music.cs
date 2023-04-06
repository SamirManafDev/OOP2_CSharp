using System;

namespace OOP2_CSharp
{
    internal interface Music
    {
        void Play();
    }
    class MP3 : Music
    {
        public void Play()
        {
            Console.WriteLine("MP3");
        }
    }
    class WAV : Music
    {
        public void Play()
        {
            Console.WriteLine("WAV");
        }
    }
    class OGG : Music
    {
        public void Play()
        {
            Console.WriteLine("OGG");
        }
    }
}
