﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Pokemon.Domain.Models
{
    public partial class Move
    {
        public Move()
        {
            PokemonMove = new HashSet<PokemonMove>();
        }

        public int Id { get; set; }
        public string Identifier { get; set; }
        public byte TypeId { get; set; }
        public short? Power { get; set; }
        public short PP { get; set; }
        public byte? Accuracy { get; set; }
        public short Priority { get; set; }
        public byte DamageClassId { get; set; }

        public virtual DamageClass DamageClass { get; set; }
        public virtual Type Type { get; set; }
        public virtual ICollection<PokemonMove> PokemonMove { get; set; }
    }
}