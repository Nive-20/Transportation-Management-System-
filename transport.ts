import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TransportationService } from '../transportation';

@Component({
  selector: 'app-transport',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './transport.html',
  styleUrl: './transport.css'
})

export class TransportComponent implements OnInit {

  transports: any[] = [];

  constructor(private service: TransportationService) { }

  ngOnInit(): void {

    this.service.getTransport().subscribe((data: any) => {

      this.transports = data;

      console.log(data);

    });

  }

}