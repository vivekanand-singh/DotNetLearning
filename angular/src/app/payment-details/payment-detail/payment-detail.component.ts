import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { PaymentDetailService } from '../../shared/payment-detail.service';

@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styleUrls: ['./payment-detail.component.css']
})
export class PaymentDetailComponent implements OnInit {
    
  constructor(private service: PaymentDetailService) { }
  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      paymentId: 0,
      cardOwner: '',
      cardNumber: '',
      expiryDate: '',
      cvv:''
    }
  }

  onSubmit(form: NgForm) {
    this.service.postPaymentDetail(form.value).subscribe(
      res => { },
      err => {
        console.log(err);
      }
    )
  }
}
