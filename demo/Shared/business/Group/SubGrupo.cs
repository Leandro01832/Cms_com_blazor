using System;
using System.Collections.Generic;

namespace business.Group
{

        public class SubGrupo : BaseModel
        {

                public string? Nome { get; set; }
            public virtual List<Pagina>? Pagina { get; set; }
            public virtual List<SubSubGrupo>? SubSubGrupo { get; set; }

                    public Int64 GrupoId { get; set; }
                    public virtual Grupo? Grupo { get; set; }
        }

}