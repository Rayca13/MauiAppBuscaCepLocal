using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBuscaCepLocal.Model
{
    public class Endereco
    {
        public int Id_logradouro { get; set; }
        public int Id_cidade { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
        public string descricao_sem_nome { get; set; }
        public object rows { get; set; }
        public int CEP{ get; set; }
        public string UF { get; set; }
    }
}
