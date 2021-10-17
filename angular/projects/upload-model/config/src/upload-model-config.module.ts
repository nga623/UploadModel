import { ModuleWithProviders, NgModule } from '@angular/core';
import { UPLOAD_MODEL_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class UploadModelConfigModule {
  static forRoot(): ModuleWithProviders<UploadModelConfigModule> {
    return {
      ngModule: UploadModelConfigModule,
      providers: [UPLOAD_MODEL_ROUTE_PROVIDERS],
    };
  }
}
