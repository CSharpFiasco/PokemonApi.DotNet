import { PokemonMove } from "./pokemon-move";

export class MoveMethod {
  constructor(
    public Id: number,
    public Identifier: string,
    public PokemonMove?: PokemonMove[],
  ) { }
}
