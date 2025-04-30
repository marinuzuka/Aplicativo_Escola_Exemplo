using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Escola_Exemplo.DTOs
{
    public class SalasDTO
    {
        public int idSala;
        public int idProfessor;
        public int idCurso;

        public SalasDTO(int idSala, int idProfessor, int idCurso)
        {
            this.idSala = idSala;
            this.idProfessor = idProfessor;
            this.idCurso = idCurso;
        }

        public SalasDTO(int idSala)
        {
            this.idSala = idSala;
        }
    }
}
