namespace API_B;
    public class Folha
    {
        public int Id { get; set; }
        public int HorasTrabalhadas { get; set; }
        public decimal ValorHora { get; set; }

        public decimal SalarioBruto
        {
            get { return HorasTrabalhadas * ValorHora; }
        }

        public decimal SalarioLiquido
        {
            get { return SalarioBruto - (SalarioBruto * 0.1m); } 
        }
    }
