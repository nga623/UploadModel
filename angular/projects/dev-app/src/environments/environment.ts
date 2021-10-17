import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
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
    scope: 'offline_access UploadModel role email openid profile',
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
