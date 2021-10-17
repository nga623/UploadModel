import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'UploadModel',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44319',
    redirectUri: baseUrl,
    clientId: 'UploadModel_App',
    responseType: 'code',
    scope: 'offline_access UploadModel',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44319',
      rootNamespace: 'UploadModel',
    },
    UploadModel: {
      url: 'https://localhost:44361',
      rootNamespace: 'UploadModel',
    },
  },
} as Environment;
