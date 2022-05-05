import { ODataResponse } from './odata-response';

describe('ODataResponse', () => {
  it('should create an instance', () => {
    const response = { value: []};
    expect(new ODataResponse(response)).toBeTruthy();
  });
});
