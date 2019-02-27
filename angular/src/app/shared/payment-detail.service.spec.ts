import { TestBed } from '@angular/core/testing';

import { PaymentDetailService } from './payment-detail.service';

describe('PaymentDetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PaymentDetailService = TestBed.get(PaymentDetailService);
    expect(service).toBeTruthy();
  });
});
