using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cool.App.Migrations
{
    /// <inheritdoc />
    public partial class AddingSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CoolApp");

            migrationBuilder.RenameTable(
                name: "OpenIddictTokens",
                newName: "OpenIddictTokens",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "OpenIddictScopes",
                newName: "OpenIddictScopes",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "OpenIddictAuthorizations",
                newName: "OpenIddictAuthorizations",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "OpenIddictApplications",
                newName: "OpenIddictApplications",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "AbpUserTokens",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "AbpUsers",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "AbpUserRoles",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "AbpUserOrganizationUnits",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "AbpUserLogins",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUserDelegations",
                newName: "AbpUserDelegations",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "AbpUserClaims",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "AbpTenants",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpTenantConnectionStrings",
                newName: "AbpTenantConnectionStrings",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "AbpSettings",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpSettingDefinitions",
                newName: "AbpSettingDefinitions",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpSecurityLogs",
                newName: "AbpSecurityLogs",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "AbpRoles",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "AbpRoleClaims",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "AbpPermissions",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpPermissionGroups",
                newName: "AbpPermissionGroups",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpPermissionGrants",
                newName: "AbpPermissionGrants",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "AbpOrganizationUnits",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnitRoles",
                newName: "AbpOrganizationUnitRoles",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpLinkUsers",
                newName: "AbpLinkUsers",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpFeatureValues",
                newName: "AbpFeatureValues",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                newName: "AbpFeatures",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpFeatureGroups",
                newName: "AbpFeatureGroups",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                newName: "AbpEntityPropertyChanges",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                newName: "AbpEntityChanges",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpClaimTypes",
                newName: "AbpClaimTypes",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "AbpBackgroundJobs",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "AbpAuditLogs",
                newSchema: "CoolApp");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogActions",
                newName: "AbpAuditLogActions",
                newSchema: "CoolApp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "OpenIddictTokens",
                schema: "CoolApp",
                newName: "OpenIddictTokens");

            migrationBuilder.RenameTable(
                name: "OpenIddictScopes",
                schema: "CoolApp",
                newName: "OpenIddictScopes");

            migrationBuilder.RenameTable(
                name: "OpenIddictAuthorizations",
                schema: "CoolApp",
                newName: "OpenIddictAuthorizations");

            migrationBuilder.RenameTable(
                name: "OpenIddictApplications",
                schema: "CoolApp",
                newName: "OpenIddictApplications");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                schema: "CoolApp",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                schema: "CoolApp",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                schema: "CoolApp",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                schema: "CoolApp",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                schema: "CoolApp",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "AbpUserDelegations",
                schema: "CoolApp",
                newName: "AbpUserDelegations");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                schema: "CoolApp",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                schema: "CoolApp",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "AbpTenantConnectionStrings",
                schema: "CoolApp",
                newName: "AbpTenantConnectionStrings");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                schema: "CoolApp",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "AbpSettingDefinitions",
                schema: "CoolApp",
                newName: "AbpSettingDefinitions");

            migrationBuilder.RenameTable(
                name: "AbpSecurityLogs",
                schema: "CoolApp",
                newName: "AbpSecurityLogs");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                schema: "CoolApp",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                schema: "CoolApp",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                schema: "CoolApp",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "AbpPermissionGroups",
                schema: "CoolApp",
                newName: "AbpPermissionGroups");

            migrationBuilder.RenameTable(
                name: "AbpPermissionGrants",
                schema: "CoolApp",
                newName: "AbpPermissionGrants");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                schema: "CoolApp",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnitRoles",
                schema: "CoolApp",
                newName: "AbpOrganizationUnitRoles");

            migrationBuilder.RenameTable(
                name: "AbpLinkUsers",
                schema: "CoolApp",
                newName: "AbpLinkUsers");

            migrationBuilder.RenameTable(
                name: "AbpFeatureValues",
                schema: "CoolApp",
                newName: "AbpFeatureValues");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                schema: "CoolApp",
                newName: "AbpFeatures");

            migrationBuilder.RenameTable(
                name: "AbpFeatureGroups",
                schema: "CoolApp",
                newName: "AbpFeatureGroups");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                schema: "CoolApp",
                newName: "AbpEntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                schema: "CoolApp",
                newName: "AbpEntityChanges");

            migrationBuilder.RenameTable(
                name: "AbpClaimTypes",
                schema: "CoolApp",
                newName: "AbpClaimTypes");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                schema: "CoolApp",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                schema: "CoolApp",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogActions",
                schema: "CoolApp",
                newName: "AbpAuditLogActions");
        }
    }
}
