-- =============================================
-- Author:        M Tanveer
-- Create date:   12/24/24
-- Description:   Updates product statuses according to their perishable dates.
-- =============================================
CREATE PROCEDURE p_delete_api_token
    @tenant_id NVARCHAR(125),
    @api_type NVARCHAR(45)
AS
BEGIN
    DELETE FROM tenant_api_subscription
    WHERE tenant_id = @tenant_id 
      AND api_type = @api_type;
END;
