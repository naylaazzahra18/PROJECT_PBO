using System;
using System.Collections.Generic;
using System.Text;

namespace PrediksiAyamSakit
{
    public class Prediksi
    {
        public int JumlahAyam { get; private set; }
        public int AyamSakit { get; private set; }

        public Prediksi(int jumlahAyam, int ayamSakit)
        {
            JumlahAyam = jumlahAyam;
            AyamSakit = ayamSakit;
        }

        public virtual double HitungPersentase()
        {
            return (double)AyamSakit / JumlahAyam * 100;
        }
    }
}
