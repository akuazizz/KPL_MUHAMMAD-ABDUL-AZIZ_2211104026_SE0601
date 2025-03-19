using System;
using System.IO;
using Newtonsoft.Json;

public class Nama
{
    public string Depan { get; set; }
    public string Belakang { get; set; }
}

public class DataMahasiswa2211104026
{
    public Nama Nama { get; set; }
    public string NIM { get; set; }
    public string Fakultas { get; set; }

    public static void ReadJSON()
    {
        string path = @"E:\KPL\tpmodul7_2211104026\tpmodul7_2211104026\tp7_1_2211104026.json";
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            var mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa2211104026>(jsonData);

            Console.WriteLine($"Nama {mahasiswa.Nama.Depan} {mahasiswa.Nama.Belakang} dengan NIM {mahasiswa.NIM} dari fakultas {mahasiswa.Fakultas}");
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan!");
        }
    }
}
