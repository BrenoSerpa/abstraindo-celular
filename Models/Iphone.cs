namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    class Iphone : Smartphone
    {
        
        public new string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine ($"Instalando {nomeApp} no dispositivo Iphone.");
        }
    }
}