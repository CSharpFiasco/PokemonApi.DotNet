export class ODataResponse<T> {
  public value: T[];
  constructor(response: any) {
    console.log("test constructor");
    if (response["value"] == null) {
      throw new TypeError();
    }

    this.value = response["value"];
  }
}
