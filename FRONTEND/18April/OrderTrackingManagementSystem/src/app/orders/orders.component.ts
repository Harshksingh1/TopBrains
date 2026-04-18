import { Component } from '@angular/core';

interface Order {
  id: number;
  orderNumber: string;
  productName: string;
  quantity: number;
  price: number;
  orderDate: Date;
  status: string;
}

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrl: './orders.component.css'
})
export class OrdersComponent {
 
   orders = [
  {
    id: 1,
    product: 'Laptop',
    price: 50000,
    date: new Date(),
    status: 'P'
  },
  {
    id: 2,
    product: 'Mobile',
    price: 20000,
    date: new Date(),
    status: 'S'
  },
  {
    id: 3,
    product: 'Headphones',
    price: 2000,
    date: new Date(),
    status: 'D'
  },
  {
    id: 4,
    product: 'Smart Watch',
    price: 8000,
    date: new Date(),
    status: 'P'
  },
  {
    id: 5,
    product: 'Tablet',
    price: 15000,
    date: new Date(),
    status: 'S'
  },
  {
    id: 6,
    product: 'Camera',
    price: 30000,
    date: new Date(),
    status: 'D'
  },
  {
    id: 7,
    product: 'Keyboard',
    price: 1500,
    date: new Date(),
    status: 'P'
  },
  {
    id: 8,
    product: 'Monitor',
    price: 12000,
    date: new Date(),
    status: 'S'
  }
];
}
