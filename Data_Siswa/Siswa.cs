namespace Data_Siswa
{
    public class siswa
    {
    }

    public class Siswa
    {
        private int no;
        private string nama;
        private string kelas;
        private int nilai;
        private static int nextNomorUrut = 1;

        public int No { get => no; set => no = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public int Nilai { get => nilai; set => nilai = value; }
        public static int NextNomorUrut { get => nextNomorUrut; set => nextNomorUrut = value; }

        public void InputSiswa(int getno,string getnama, string getkelas, int getnilai)
        {
            no = getno;
            nama = getnama;
            kelas = getkelas;
            nilai = getnilai;
        }

        public void EditSiswa(int getno, string getnama, string getkelas, int getnilai)
        {
            no = getno;
            nama = getnama;
            kelas = getkelas;
            nilai = getnilai;
        }

        public Siswa()
        {
            no = NextNomorUrut++;
        }
    }
}