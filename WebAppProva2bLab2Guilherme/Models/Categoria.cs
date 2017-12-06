using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Guilherme.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Trabalho> Trabalhos { get; set; }
        public virtual ICollection<Avaliacao> Avaliacaos { get; set; }
    }
}