import { Move } from './move';

describe('Move', () => {
  it('should create an instance', () => {
    expect(new Move(0, '', 0, null, 0, null, 0, 0)).toBeTruthy();
  });
});
