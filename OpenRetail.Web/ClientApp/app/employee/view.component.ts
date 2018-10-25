import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'viewemployee',
    templateUrl: './view.component.html'
})
export class ViewEmployeeComponent {
    public listEmployee: Employee[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/employee/list').subscribe(result => {
            this.listEmployee = result.json() as Employee[];
        }, error => console.error(error));
    }
}

interface Employee {
    employeeCode: string;
    employeeName: string;
    address: string;
    phone: string;
    hp: string;
    status: string;
    email: string;
    divisionName: string;
}