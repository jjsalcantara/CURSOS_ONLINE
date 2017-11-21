using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CURSOS_ONLINE.Models
{
    public class Curso
    {
        public int ID { get; set; }
        public String CodigoCurso { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInscricao { get; set; }
        public DateTime DataFim { get; set; }
        public string NomeSite { get; set; }
        public String Usuario { get; set; }
        public string senha { get; set; }
    }
}