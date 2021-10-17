import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class UploadModelService {
  apiName = 'UploadModel';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/UploadModel/sample' },
      { apiName: this.apiName }
    );
  }
}
