using System;

namespace First_Proj
{
    class Program{
        
        bool check_file(string file_loc,bool mode){
            try{
                FileStream fstream = new FileStream("./test.text",FileMode.Open);
                
                System.Console.WriteLine("File Di Temukan");

                fstream.Close();
                return true;
            } catch (Exception){
                System.Console.WriteLine("File Tidak Ditemukan");

                FileStream fstream = new FileStream("./test.text",FileMode.Create);

                fstream.Close();
                return false;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}