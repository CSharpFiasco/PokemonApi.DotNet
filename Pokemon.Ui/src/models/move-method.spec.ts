import { TestBed } from '@angular/core/testing';
import { MoveMethod } from './move-method';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { HttpClient } from '@angular/common/http';

describe('MoveMethod', () => {
  it('should create an instance', () => {
    expect(new MoveMethod(0, '')).toBeTruthy();
  });
});
