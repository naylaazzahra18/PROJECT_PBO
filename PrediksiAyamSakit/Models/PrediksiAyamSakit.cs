using System;

namespace PrediksiAyamSakit
{
    public class PrediksiAyamSakit : Prediksi
    {
        public PrediksiAyamSakit(int jumlahAyam, int ayamSakit)
            : base(jumlahAyam, ayamSakit){}
        public string Status(double sebelumnya, double sekarang)
        {
            if (sekarang > sebelumnya)
                return "Meningkat";

            if (sekarang < sebelumnya)
                return "Menurun";

            return "Stabil";
        }
    }
}
