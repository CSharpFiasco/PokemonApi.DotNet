import { Pokemon } from './pokemon';

describe('Pokemon', () => {
  it('should create an instance', () => {
    expect(new Pokemon(0, '', 0, 0, 0, null, false)).toBeTruthy();
  });
});
