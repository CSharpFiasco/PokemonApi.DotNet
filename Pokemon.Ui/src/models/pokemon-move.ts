import { Move } from "./move";
import { MoveMethod } from "./move-method";
import { Pokemon } from "./pokemon";

export class PokemonMove {
  constructor(
    public PokemonId: number,
    public MoveId: number,
    public MoveMethodId: number,
    public Level: number,
    public Order: number | null,
    public Move?: Move,
    public MoveMethod?: MoveMethod,
    public Pokemon?: Pokemon,
  ) { }
}
