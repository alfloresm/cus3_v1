using System;
using System.Collections.Generic;

namespace CUS03V1.Models
{
    public partial class TEstadoCon
    {
        public TEstadoCon()
        {
            TConcurso = new HashSet<TConcurso>();
        }

        public int PkIeIdEstado { get; set; }
        public string VeNombreEsta { get; set; }

        public ICollection<TConcurso> TConcurso { get; set; }
    }
}
