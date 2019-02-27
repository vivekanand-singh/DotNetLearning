import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {
  formData: PaymentDetail
  constructor(private http: HttpClient) { }
  rootUrl = 'https://localhost:44338/api';
  postPaymentDetail(formData: PaymentDetail) {
    return this.http.post(this.rootUrl + '/PaymentDetails', formData);
  }
}
