import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'QMS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:7000',
    redirectUri: baseUrl,
    clientId: 'QMS_App',
    responseType: 'code',
    scope: 'offline_access IdentityService AdministrationService SaaSService role email openid profile',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:7500',
      rootNamespace: 'QMS',
    },
  },
} as Environment;
