﻿namespace Academico.Models
{
    public class Instituicao
    {
        public long Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereço { get; set; }
        public virtual ICollection<Departamento>? Departamentos { get; set; }
    }
}
