using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WindowsFormsApplication8
{
    static class sound
    {
        static SoundPlayer sound_fail = new SoundPlayer(Properties.Resources.sound_fail);
        static SoundPlayer sound_key = new SoundPlayer(Properties.Resources.key);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources._4fa);
        static SoundPlayer sound_youwin = new SoundPlayer(Properties.Resources._12);
        static SoundPlayer sound_level3 = new SoundPlayer(Properties.Resources._3);
        static SoundPlayer sound_level4 = new SoundPlayer(Properties.Resources._4);
        static SoundPlayer sound_level5 = new SoundPlayer(Properties.Resources._5);
        static SoundPlayer sound_level6 = new SoundPlayer(Properties.Resources._6);
        static bool sound_enabled = true;

        public static void sound_on()
        {
            sound_enabled = true;
        }

        public static void sound_off ()
        {
            sound_enabled = false;
        }

        public static void play_fail()
        {
            if(sound_enabled)
            sound_fail.Play();
        }
        public static void play_key()
        {
            if(sound_enabled)
            sound_key.Play();
        }
        public static void play_start()
        {
            if (sound_enabled)
            sound_start.Play();
        }
        public static void play_youwin()
        {
            if (sound_enabled)
            sound_youwin.Play();
        }

        public static void play_level3()
        {
            if (sound_enabled)
                sound_level3.Play();
        }

        public static void play_level4()
        {
            if (sound_enabled)
                sound_level4.Play();
        }

        public static void play_level5()
        {
            if (sound_enabled)
                sound_level5.Play();
        }

        public static void play_level6()
        {
            if (sound_enabled)
                sound_level6.Play();
        }
    }
}
