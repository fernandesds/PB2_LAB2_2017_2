using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Guilherme.Models
{
    public class Participante
    {
        public int ParticipanteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Trabalho> Trabalhos { get; set; }
        public virtual Endereco Enderecos { get; set; }
    }
}