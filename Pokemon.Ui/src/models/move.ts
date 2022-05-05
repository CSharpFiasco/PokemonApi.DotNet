import { DamageClass } from "./damage-class";
import { Type } from "./type";
import { PokemonMove } from "./pokemon-move";

export class Move {
  constructor(
    public Id: number,
    public Identifier: string,
    public TypeId: number,
    public Power: number | null,
    public PP: number,
    public Accuracy: number | null,
    public Priority: number,
    public DamageClassId: number,
    public DamageClass?: DamageClass,
    public Type?: Type,
    public PokemonMove?: PokemonMove[],
  ) { }
}
