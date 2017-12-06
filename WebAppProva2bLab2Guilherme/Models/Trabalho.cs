using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Guilherme.Models
{
    public class Trabalho
    {
        public int TrabalhoId { get; set; }
        public DateTime DataSubmissao { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public virtual Categoria Categorias { get; set; }
        public ICollection<Avaliacao> Avaliacaos { get; set; }
    }
}