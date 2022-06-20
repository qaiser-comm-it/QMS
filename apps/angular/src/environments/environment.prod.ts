import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'QaisMicroservice',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44308',
    redirectUri: baseUrl,
    clientId: 'QaisMicroservice_App',
    responseType: 'code',
    scope: 'offline_access QaisMicroservice',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44381',
      rootNamespace: 'QaisMicroservice',
    },
  },
} as Environment;
