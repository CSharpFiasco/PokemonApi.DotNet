import { Move } from "./move";

export class Type {
  constructor(
    public Id: number,
    public Identifier: string,
    public Move?: Move[],
  ) { }
}
