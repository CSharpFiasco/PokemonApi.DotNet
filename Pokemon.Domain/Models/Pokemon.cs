﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Pokemon.Domain.Models
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            PokemonMove = new HashSet<PokemonMove>();
        }

        public int Id { get; set; }
        public string Identifier { get; set; }
        public short Height { get; set; }
        public short Weight { get; set; }
        public short BaseExperience { get; set; }
        public short? Order { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<PokemonMove> PokemonMove { get; set; }
    }
}