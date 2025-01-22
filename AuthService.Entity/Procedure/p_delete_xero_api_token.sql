-- =============================================
-- Author:        M Tanveer
-- Create date:   12/24/24
-- Description:   Deletes Xero API tokens for a specific tenant and API type.
-- =============================================
CREATE DEFINER=`edge`@`%` PROCEDURE `p_delete_xero_api_token`(
    _tenant_id VARCHAR(125),
    _api_type VARCHAR(45)
)
BEGIN
    DELETE FROM xero_api_token 
    WHERE tenant_id = _tenant_id 
      AND api_type = _api_type;
END;
