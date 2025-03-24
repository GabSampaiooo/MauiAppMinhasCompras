using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        string _descricao;

        [PrimaryKey, AutoIncrement]
        public string Id {
            get => _descricao;
            set
            {
                if (value == null)
                {
                    throw new Exception("Por favor, preencha a descrição");
                }

                _descricao = value;
            }
        }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Preco {  get; set; }

        public double Total { get => Quantidade * Preco; }
    }
}
