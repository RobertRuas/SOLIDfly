using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Endereco
    {
        public int ID { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string TipoLogr { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string GeoLoc { get; set; }
        public int IDUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
