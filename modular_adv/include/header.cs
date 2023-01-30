namespace Apps
{
    public struct Siswa
    {
        public string _nama;
        public kelas _kelas;
        public int _absen;
        public int _umur;
        public gender _jk;

            public void Deconstruct(out string nama, out kelas kelas, out int absen, out int umur, out gender jk)
            {
                nama = _nama;
                kelas = _kelas;
                absen = _absen;
                umur = _umur;
                jk = _jk;
            }
    }
    
    public enum kelas{
        SIJA,
        TPL,
        TKR,
        DPIB,
        TLFM
    }

    public enum gender{
        cewe = 0,
        cowo = 1,
        perempuan = 0,
        laki = 1
    }

    public enum message_info{
        info,
        error,
        warning
    }

    static class root{
        public static void _say(message_info inf,string Message){
            switch (inf)
            {
                case message_info.info:
                    System.Console.WriteLine($"\x1b[32m [SYSTEM][INFO]    : {Message} \x1b[0m");
                    break;
                case message_info.error:
                    System.Console.WriteLine($"\x1b[31m [SYSTEM][ERROR]   : {Message} \x1b[0m");
                    break;
                case message_info.warning:
                    System.Console.WriteLine($"\x1b[33m [SYSTEM][WARNING] : {Message} \x1b[0m");
                    break;
            }
        }
    }
}