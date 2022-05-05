import { DamageClass } from './damage-class';

describe('DamageClass', () => {
  it('should create an instance', () => {
    expect(new DamageClass(0, '')).toBeTruthy();
  });
});
