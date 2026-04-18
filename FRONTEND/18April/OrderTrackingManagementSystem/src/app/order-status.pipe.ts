import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'orderStatus'
})
export class OrderStatusPipe implements PipeTransform {

    transform(value: string): string {
    switch (value) {
      case 'P':
        return 'Pending ⏳';
      case 'S':
        return 'Shipped 🚚';
      case 'D':
        return 'Delivered ✅';
      default:
        return 'Unknown';
    }
  }

}
