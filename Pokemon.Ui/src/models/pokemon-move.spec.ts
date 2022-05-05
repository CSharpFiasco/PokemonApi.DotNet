import { PokemonMove } from './pokemon-move';

describe('PokemonMove', () => {
  it('should create an instance', () => {
    expect(new PokemonMove(0, 0, 0, 0, null)).toBeTruthy();
  });
});
