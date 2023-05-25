import { Pipe, PipeTransform } from '@angular/core';
import { Employee } from '../Models/employee';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: Employee[], name: string): Employee[] {
    if(name == "")
      return value
      else{
        return value.filter((e => e.name.toLowerCase().includes(name.toLowerCase())));
      } 
  }

}
