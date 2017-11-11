// ======================================
// Author: Ebenezer Monney
// Email:  info@ebenmonney.com
// Copyright (c) 2017 www.ebenmonney.com
// 
// ==> Gun4Hire: contact@ebenmonney.com
// ======================================

import { Component, OnInit } from '@angular/core';
import { fadeInOut } from '../../services/animations';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'products',
    templateUrl: './products.component.html',
    styleUrls: ['./products.component.css'],
    animations: [fadeInOut]
})
export class ProductsComponent implements OnInit{
    results: string[];

    // Inject HttpClient into your component or service.
    constructor(private http: HttpClient) {}

    ngOnInit(): void {
        // Make the HTTP request:
        this.http.get('/api/Doctor/GetAllCustomers').subscribe(data => {
            // Read the result field from the JSON response.
            console.log(data);
            //this.results = data['results'];
        });
    }
}
