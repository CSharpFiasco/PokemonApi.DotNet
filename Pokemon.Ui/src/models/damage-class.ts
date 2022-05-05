import { Move } from "./move";

export class DamageClass {
  constructor(
    public Id: number,
    public Identifier: string,
    public Move?: Move[]
  ) { }
}
