using System;
using System.Collections.Generic;

namespace business.Group
{
    public class CamadaSeis : BaseModel
    {
         public string? Nome { get; set; }

        public virtual List<Pagina>? Pagina { get; set; }
        public virtual List<CamadaSete>? CamadaSete { get; set; }

         public Int64 SubSubGrupoId { get; set; }
        public virtual SubSubGrupo? SubSubGrupo { get; set; }
    }
}