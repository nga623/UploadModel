import { Component, OnInit } from '@angular/core';
import { UploadModelService } from '../services/upload-model.service';

@Component({
  selector: 'lib-upload-model',
  template: ` <p>upload-model works!</p> `,
  styles: [],
})
export class UploadModelComponent implements OnInit {
  constructor(private service: UploadModelService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
