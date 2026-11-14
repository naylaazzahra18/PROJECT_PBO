namespace PrediksiAyamSakit
{
    public class HasilPrediksi
    {
        public int Hari { get; private set; }
        public double Persentase { get; private set; }
        public string Status { get; private set; }

        public HasilPrediksi(int hari, double persentase,
            double prediksi, string status)
        {
            Hari = hari;
            Persentase = persentase;
            Status = status;
        }
    }
}
