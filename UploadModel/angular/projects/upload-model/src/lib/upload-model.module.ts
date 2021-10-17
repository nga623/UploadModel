import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { UploadModelComponent } from './components/upload-model.component';
import { UploadModelRoutingModule } from './upload-model-routing.module';

@NgModule({
  declarations: [UploadModelComponent],
  imports: [CoreModule, ThemeSharedModule, UploadModelRoutingModule],
  exports: [UploadModelComponent],
})
export class UploadModelModule {
  static forChild(): ModuleWithProviders<UploadModelModule> {
    return {
      ngModule: UploadModelModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<UploadModelModule> {
    return new LazyModuleFactory(UploadModelModule.forChild());
  }
}
