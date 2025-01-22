-- =============================================
-- Author:        M Tanveer
-- Create date:   12/24/24
-- Description:   Fetches active users by tenant ID with the most recent updates.
-- =============================================
CREATE PROCEDURE p_get_active_users_by_tenant_id
    @tenant_id NVARCHAR(250) -- Parameter declaration
AS
BEGIN
    -- Selecting users with the most recent updates for the given tenant_id
    SELECT     
        u.user_id, 
        u.tenant_id, 
        u.first_name, 
        u.last_name, 
        u.[status], -- Square brackets for reserved keywords
        u.created_timestamp,
        u.updated_timestamp,
        u.user_type,
        u.job_title,
        u.job_role,
        u.phone_number,
        u.employee_id,
        u.is_new_signup,
        u.membership_id,
        u.membership_name,
        u.membership_email,
        u.chamber_email,
        u.is_allow_chamber,
        u.is_leave_chamber,
        u.is_self_login_enable,
        u.is_allow_inform,
        u.is_not_allow_inform,
        u.plan_desc,
        u.subscription_id,
        u.customer_id,
        u.dt_substart,
        u.dt_subend,
        u.payment_id,
        u.is_allow_fu,
        u.date_of_birth,
        u.gender,
        u.sub_period,		
        u.payment_amount,
        u.payment_ccy,		
        u.payment_status,  
        u.is_supper_user
    FROM [user] u -- Use square brackets for table name if it is a reserved keyword
    INNER JOIN (
        SELECT tenant_id, user_id, MAX(updated_timestamp) AS updated_timestamp
        FROM [user]
        GROUP BY tenant_id, user_id
    ) b
    ON u.tenant_id = b.tenant_id
       AND u.updated_timestamp = b.updated_timestamp
       AND u.user_id = b.user_id
    WHERE u.tenant_id = @tenant_id 
      AND u.[status] = 'Active' 
      AND (u.chamber_email = '' OR u.chamber_email IS NULL); -- Use IS NULL for null comparisons
END;
