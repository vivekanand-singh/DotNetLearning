import { Component, OnInit } from '@angular/core';
import { PaymentDetailService } from '../../shared/payment-detail.service';
import { PaymentDetail } from '../../shared/payment-detail.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-payment-detail-list',
  templateUrl: './payment-detail-list.component.html',
  styleUrls: ['./payment-detail-list.component.css']
})
export class PaymentDetailListComponent implements OnInit {

  constructor(private service: PaymentDetailService, private toastr: ToastrService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  populateForm(pd: PaymentDetail) {
    this.service.formData = pd;
  }

  onDelete(paymentID) {
    if (confirm('Do You Want to Delete'))
    this.service.deletePaymentDetail(paymentID).subscribe(
      res => {
        this.service.refreshList();
        this.toastr.warning('Deleted successfully', 'Payment Detail Register')
      },
      err => {
        this.toastr.error('Error on Deletion', 'Payment Detail Register')
        console.log(err);
      }
    )
  }
}
