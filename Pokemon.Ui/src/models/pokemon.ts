import { PokemonMove } from "./pokemon-move";

export class Pokemon {
  constructor(
    public id: number,
    public Identifier: string,
    public Height: number,
    public Weight: number,
    public BaseExperience: number,
    public Order: number | null,
    public IsDefault: boolean,
    public PokemonMove?: PokemonMove[],
  ) { }
}
