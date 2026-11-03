using System;

namespace TugasXRPL
{
    class Home
    {
        public static void Main(string[] args)
        {
            bool ulang = true;
            while (ulang)
            {
                Console.WriteLine("Selamat Datang di Program X RPL!");
                Console.WriteLine("Silakan pilih opsi berikut:");
                Console.WriteLine("1. Pengulangan For");
                Console.WriteLine("2. Pengulangan While");
                Console.WriteLine("3. Pengulangan Do-While");
                Console.WriteLine("4. Pengulangan Foreach");
                Console.WriteLine("5. Array");
                Console.WriteLine("6. List");
                Console.WriteLine("7. Keluar");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                if (pilihan == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Pilih opsi pengulangan for.");
                    Console.WriteLine("1.Menampilkan angka dari 1-10");
                    Console.WriteLine("2.Menampilkan bilangan genap dari 2-20");
                    Console.WriteLine("3.Menampilkan angka dari 10-1");
                    Console.WriteLine("4.Menampilkan tabel perkalian 5");
                    Console.WriteLine("5.Menghitung total penjumlahan angka 1 sampai 5");
                    int pilihan2 = Convert.ToInt32(Console.ReadLine());

                    if (pilihan2 == 1)
                    {
                        Console.Clear();
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write(i + ",");
                        }
                    }
                    else if (pilihan2 == 2)
                    {
                        Console.Clear();

                        for (int i = 2; i <= 20; i += 2)
                        {
                            Console.Write(i + ",");
                        }
                    }
                    else if (pilihan2 == 3)
                    {
                        Console.Clear();

                        for (int i = 10; i >= 1; i--)
                        {
                            Console.Write(i+",");
                        }
                    }
                    else if (pilihan2 == 4)
                    {
                        Console.Clear();

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("5 x " + i + " = " + (5 * i));
                        }
                    }
                    else if (pilihan2 == 5)
                    {
                        Console.Clear();
                        
                        int total = 0;
                        for (int i = 1; i <= 5; i++)
                        {
                            total += i;
                        }
                        Console.WriteLine("Total penjumlahan angka dari 1 sampai 5 adalah: " + total);
                    }

                }
                else if (pilihan == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Pilih opsi pengulangan while:");
                    Console.WriteLine("1. Menampilkan kelipatan 3 kurang dari 15");
                    Console.WriteLine("2. Menghitung mundur dari 10 ke 1");
                    Console.WriteLine("3. Menampilkan karakter bintang (*) 5 kali");
                    Console.WriteLine("4. Menjumlahkan angka 1 sampai 4");
                    Console.WriteLine("5. Simulasi pembagian angka 32 dibagi 2 terus menerus");
                    int pilihan2 = Convert.ToInt32(Console.ReadLine());

                    if (pilihan2 == 1)
                    {
                        Console.Clear();
                        int i = 3;
                        while (i < 15)
                        {
                            Console.Write(i + ",");
                            i += 3;
                        }
                    }
                    else if (pilihan2 == 2)
                    {
                        Console.Clear();
                        int i = 10;
                        while (i >= 1)
                        {
                            Console.Write(i + ",");
                            i--;
                        }
                    }
                    else if (pilihan2 == 3)
                    {
                        Console.Clear();
                        int i = 0;
                        while (i < 5)
                        {
                            Console.Write("*");
                            i++;
                        }
                    }
                    else if (pilihan2 == 4)
                    {
                        Console.Clear();
                        int total = 0;
                        int i = 1;
                        while (i <= 4)
                        {
                            total += i;
                            i++;
                        }
                        Console.WriteLine("Total penjumlahan angka dari 1 sampai 4 adalah: " + total);
                    }
                    else if (pilihan2 == 5)
                    {
                        Console.Clear();
                        int angka = 32;
                        while (angka > 1)
                        {
                            angka /= 2;
                            Console.WriteLine("Hasil pembagian: " + angka);
                        }
                    }
                }
                else if (pilihan == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Pilih opsi pengulangan do while:");
                    Console.WriteLine("1. Menampilkan pesan minimal 1 kali");
                    Console.WriteLine("2. Menampilkan angka ganjil dari 1 sampai 9");
                    Console.WriteLine("3. Simulasi percobaan login (maksimal 3 kali)");
                    Console.WriteLine("4. Menampilkan abjad A sampai E");
                    Console.WriteLine("5. Mengalikan angka 5 dengan 2 hingga mencapai 50");

                    int pilihan2 = Convert.ToInt32(Console.ReadLine());

                    if (pilihan2 == 1)
                    {
                        Console.Clear();
                        int i = 0;
                        do
                        {
                            Console.WriteLine("Pesan ini akan ditampilkan minimal 1 kali.");
                            i++;
                        } while (i < 1);
                    }
                    else if (pilihan2 == 2)
                    {
                        Console.Clear();
                        int i = 1;
                        do
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(i + ",");
                            }
                            i++;
                        } while (i <= 9);
                    }
                    else if (pilihan2 == 3)
                    {
                        Console.Clear();
                        int percobaan = 0;
                        string password = "1234";
                        string input;
                        do
                        {
                            Console.Write("Masukkan password: ");
                            input = Console.ReadLine();
                            percobaan++;
                            if (input == password)
                            {
                                Console.WriteLine("Login berhasil!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Password salah. Percobaan ke-" + percobaan);
                            }
                        } while (percobaan < 3);
                        if (percobaan == 3 && input != password)
                        {
                            Console.WriteLine("Percobaan login habis. Akses ditolak.");
                        }
                    }
                    else if (pilihan2 == 4)
                    {
                        Console.Clear();
                        char huruf = 'A';
                        do
                        {
                            Console.Write(huruf + ",");
                            huruf++;
                        } while (huruf <= 'E');
                    }
                    else if (pilihan2 == 5)
                    {
                        Console.Clear();
                        int angka = 5;
                        do
                        {
                            Console.WriteLine("Hasil perkalian: " + angka);
                            angka *= 2;
                        } while (angka <= 50);
                    }
                }
                else if (pilihan == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Pilih opsi perulangan foreach:");
                    Console.WriteLine("1. Menampilkan daftar nama buah");
                    Console.WriteLine("2. Menghitung total nilai siswa dari array");
                    Console.WriteLine("3. Menampilkan tiap karakter dari teks");
                    Console.WriteLine("4. Menampilkan daftar harga produk");
                    Console.WriteLine("5. Menampilkan status kelulusan dari list boolean");

                    int pilihan2 = Convert.ToInt32(Console.ReadLine());

                    if (pilihan2 == 1)
                    {
                        Console.Clear();
                        string[] buah = { "Apel", "Pisang", "Jeruk", "Mangga" };
                        foreach (string b in buah)
                        {
                            Console.WriteLine(b);
                        }
                    }
                    else if (pilihan2 == 2)
                    {
                        Console.Clear();
                        int[] nilaiSiswa = { 80, 90, 75, 85 };
                        int total = 0;
                        foreach (int nilai in nilaiSiswa)
                        {
                            total += nilai;
                        }
                        Console.WriteLine("Total nilai siswa: " + total);
                    }
                    else if (pilihan2 == 3)
                    {
                        Console.Clear();
                        string teks = "Hello";
                        foreach (char c in teks)
                        {
                            Console.WriteLine(c);
                        }
                    }
                    else if (pilihan2 == 4)
                    {
                        Console.Clear();
                        int[] hargaProduk = { 10000, 20000, 15000 };
                        foreach (int harga in hargaProduk)
                        {
                            Console.WriteLine("Harga produk: Rp" + harga);
                        }
                    }
                    else if (pilihan2 == 5)
                    {
                        Console.Clear();
                        bool[] statusKelulusan = { true, false, true, true };
                        foreach (bool status in statusKelulusan)
                        {
                            string kelulusan = status ? "Lulus" : "Tidak Lulus";
                            Console.WriteLine(kelulusan);
                        }
                    }
                }
                else if (pilihan == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Pilih opsi manipulasi array:");
                    Console.WriteLine("1. Menampilkan daftar mata pelajaran");
                    Console.WriteLine("2. Menentukan angka terbesar dalam array");
                    Console.WriteLine("3. Mengubah isi elemen array nama hari");
                    Console.WriteLine("4. Menghitung rata-rata nilai dalam array");
                    Console.WriteLine("5. Menampilkan elemen array karakter vokal");

                    int pilihan2 = Convert.ToInt32(Console.ReadLine());

                    if (pilihan2 == 1)
                    {
                        Console.Clear();
                        string[] mataPelajaran = { "Matematika", "Bahasa Indonesia", "IPA", "IPS" };
                        foreach (string pelajaran in mataPelajaran)
                        {
                            Console.WriteLine(pelajaran);
                        }
                    }
                    else if (pilihan2 == 2)
                    {
                        Console.Clear();
                        int[] angka = { 5, 10, 3, 8, 15 };
                        int terbesar = angka[0];
                        foreach (int a in angka)
                        {
                            if (a > terbesar)
                            {
                                terbesar = a;
                            }
                        }
                        Console.WriteLine("Angka terbesar dalam array: " + terbesar);
                    }
                    else if (pilihan2 == 3)
                    {
                        Console.Clear();
                        string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat" };
                        hari[2] = "Minggu"; // Mengubah Rabu menjadi Minggu
                        foreach (string h in hari)
                        {
                            Console.WriteLine(h);
                        }
                    }
                    else if (pilihan2 == 4)
                    {
                        Console.Clear();
                        int[] nilai = { 80, 90, 75, 85 };
                        int total = 0;
                        foreach (int n in nilai)
                        {
                            total += n;
                        }
                        double rataRata = (double)total / nilai.Length;
                        Console.WriteLine("Rata-rata nilai: " + rataRata);
                    }
                    else if (pilihan2 == 5)
                    {
                        Console.Clear();
                        char[] vokal = { 'a', 'e', 'i', 'o', 'u' };
                        foreach (char v in vokal)
                        {
                            Console.WriteLine(v);
                        }
                    }
                }
                else if (pilihan == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Pilih opsi manipulasi list:");
                    Console.WriteLine("1. Menambah dan menampilkan daftar siswa");
                    Console.WriteLine("2. Menhapus elemen kota dari list");
                    Console.WriteLine("3. Menhitung jumlah total elemen dalam list");
                    Console.WriteLine("4. Mengecek keberadaan data game dalam list");
                    Console.WriteLine("5. Mengosongkan seluruh isi list angka");

                    int pilihan2 = Convert.ToInt32(Console.ReadLine());

                    if (pilihan2 == 1)
                    {
                        Console.Clear();
                        List<string> siswa = new List<string>();
                        siswa.Add("Andi");
                        siswa.Add("Budi");
                        siswa.Add("Citra");
                        Console.WriteLine("Daftar siswa:");
                        foreach (string s in siswa)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    else if (pilihan2 == 2)
                    {
                        Console.Clear();
                        List<string> kota = new List<string> { "Jakarta", "Bandung", "Surabaya" };
                        kota.Remove("Bandung");
                        Console.WriteLine("Daftar kota setelah penghapusan:");
                        foreach (string k in kota)
                        {
                            Console.WriteLine(k);
                        }
                    }
                    else if (pilihan2 == 3)
                    {
                        Console.Clear();
                        List<int> angka = new List<int> { 1, 2, 3, 4, 5 };
                        int jumlah = angka.Count;
                        Console.WriteLine("Jumlah total elemen dalam list: " + jumlah);
                    }
                    else if (pilihan2 == 4)
                    {
                        Console.Clear();
                        List<string> game = new List<string> { "Minecraft", "Fortnite", "Among Us" };
                        bool adaGame = game.Contains("Fortnite");
                        string pesan = adaGame ? "Game ditemukan dalam list." : "Game tidak ditemukan dalam list.";
                        Console.WriteLine(pesan);
                    }
                    else if (pilihan2 == 5)
                    {
                        Console.Clear();
                        List<int> angka = new List<int> { 10, 20, 30, 40 };
                        angka.Clear();
                        Console.WriteLine("Seluruh isi list angka telah dikosongkan.");
                    }
                }
                else if (pilihan == 7)
                {
                    Console.WriteLine("Terima kasih telah menggunakan program ini!");
                    return;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    
                }
                Console.WriteLine();
                Console.WriteLine("Apakah anda ingin mencoba lagi?");
                Console.WriteLine("1. Ya");
                Console.WriteLine("2. Tidak");
                int pilihan3 = Convert.ToInt32(Console.ReadLine());
                if (pilihan3 == 1)
                {
                    Console.Clear();
                    ulang = true;
                }
                else if (pilihan3 == 2)
                {
                    Console.WriteLine("Terima kasih telah menggunakan program ini!");
                    ulang = false;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    ulang = false;
                }
            }
           
        }
    }
}
    