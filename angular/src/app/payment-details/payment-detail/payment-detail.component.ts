import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { PaymentDetailService } from '../../shared/payment-detail.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-payment-detail',
  templateUrl: './payment-detail.component.html',
  styleUrls: ['./payment-detail.component.css']
})
export class PaymentDetailComponent implements OnInit {
    
  constructor(private service: PaymentDetailService, private toastr: ToastrService) { }
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
    if (this.service.formData.paymentId == 0) {
      this.insertRecord(form);
    }
    else {
      this.updateRecord(form);
    }
  }

  insertRecord(form: NgForm) {
    this.service.postPaymentDetail().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Submitted successfully', 'Payment Detail Register')
        this.service.refreshList();
      },
      err => {
        console.log(err);
        this.toastr.error('Error on insert', 'Payment Detail Register')
      }
    )
  }

  updateRecord(form: NgForm) {
    this.service.putPaymentDetail().subscribe(
      res => {
        this.resetForm(form);
        this.toastr.success('Updated successfully', 'Payment Detail Register')
        this.service.refreshList();
      },
      err => {
        console.log(err);
        this.toastr.error('Error on update', 'Payment Detail Register')
      }
    )
  }
}
