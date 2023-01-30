using System.Collections.Generic;
using System.Diagnostics;
using Apps;

class App{
    List<Siswa> Datas = new List<Siswa>();
    
    public Siswa Make_Buffer(string nama,kelas kelas,int absen,int umur,gender jk){
        Siswa buffer;

        buffer._nama = nama;
        buffer._kelas = kelas;
        buffer._absen = absen;
        buffer._umur = umur;
        buffer._jk = jk;
        
        return buffer;
    }
    public void Add_Data(Siswa buffer){

        if (!check_exist_data(buffer)){
            root._say(message_info.info,"Data Has Been Store to List");
            Datas.Add(buffer);
        } else {
            root._say(message_info.error,"Data Is Exist In List");
        }
        
    }

    bool check_exist_data(Siswa buff){
        foreach (Siswa item in Datas)
        {
            if (item.Equals(buff)){
                return true;
            }
        }
        return false;
    }

    public void Remove_Data(int position = -1){
        if (position == -1){
            Datas.RemoveAt(Datas.Count - 1);
            root._say(message_info.info,$"Data Has been Removed at last Position by default");
        } else {
            Datas.RemoveAt(position);
            root._say(message_info.info,$"Data Has been Removed at Position : {position}");
        }
    }

    public void Update_Data(int position,Siswa buff){
        Datas[position] = buff;
    }

    public void Show_Data(){
        System.Console.WriteLine("\n\n");
        System.Console.WriteLine("Size : " + Datas.Count);
        System.Console.WriteLine("Nama\tKelas\tAbsen\tGender");
        
        foreach (Siswa item in Datas)
        {
            (string _nama,kelas _kelas,int _absen,int _umur,gender _jk) = item;
            System.Console.WriteLine($"{_nama}\t{_kelas}\t{_absen}\t{_jk}");
        }
    }

}

class Core{
    static void Main(string[] args)
    {
        App apps = new App();
        
        apps.Add_Data(apps.Make_Buffer("Udin",kelas.SIJA,2,14,gender.cewe));
        apps.Add_Data(apps.Make_Buffer("Udin",kelas.SIJA,2,14,gender.cowo));
        apps.Add_Data(apps.Make_Buffer("Ucup",kelas.TKR,6,12,gender.cowo));

        apps.Remove_Data();

        apps.Show_Data();               
    }
}