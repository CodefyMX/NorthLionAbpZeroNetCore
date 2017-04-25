import { NgModule } from '@angular/core';

import * as ApiServiceProxies from './service-proxies';

@NgModule({
    providers: [
        ApiServiceProxies.RoleServiceProxy,
        ApiServiceProxies.SessionServiceProxy,
        ApiServiceProxies.TenantServiceProxy,
        ApiServiceProxies.UserServiceProxy,
        ApiServiceProxies.TokenAuthServiceProxy,
        ApiServiceProxies.AccountServiceProxy,
        ApiServiceProxies.AuditLogServiceProxy,
        ApiServiceProxies.RoleServiceProxy,
        ApiServiceProxies.LanguageServiceProxy,
        ApiServiceProxies.OrganizationUnitsServiceProxy
    ]
})
export class ServiceProxyModule { }