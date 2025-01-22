-- =============================================
-- Author:        M Tanveer
-- Create date:   12/24/24
-- Description:   Deletes a tenant and associated data based on the given user ID.
-- =============================================
CREATE PROCEDURE p_DeleteTenantByUserId (
    @user_Id VARCHAR(75)
)
AS
BEGIN
    DECLARE @tenantId VARCHAR(75);

    -- Check if the tenant exists for the given user ID
    IF EXISTS (SELECT tenant_id FROM [edge_auth_db_dev].[user] WHERE user_id = @user_Id)
    BEGIN
        -- Retrieve the tenant ID
        SELECT @tenantId = tenant_id
        FROM [edge_auth_db_dev].[user]
        WHERE user_id = @user_Id;

        -- Delete tenant and related data
        DELETE FROM [edge_auth_db_dev].[tenant] WHERE tenant_id = @tenantId;
        DELETE FROM [edge_auth_db_dev].[tenant_subscription] WHERE tenant_id = @tenantId;
        DELETE FROM [edge_auth_db_dev].[user] WHERE tenant_id = @tenantId;
        DELETE FROM [edge_auth_db_dev].[user_role] WHERE user_id = @user_Id;
        DELETE FROM [edge_auth_db_dev].[user_password] WHERE user_id = @user_Id;
    END
END;
