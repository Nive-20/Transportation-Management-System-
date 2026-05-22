import { Component } from '@angular/core';
import { TransportComponent } from './transport/transport';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [TransportComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App {

}