if exists  (select * from sysobjects where name = 'BizTalkToCustomerInsert'
and type = 'P')
    drop proc BizTalkToCustomerInsert
go
CREATE procedure BizTalkToCustomerInsert
                    @CustomerName nvarchar(60)
                    , @Address nvarchar(120)
                    , @City nvarchar(60)
                    , @Region nvarchar(60)
                    , @PostalCode nvarchar(60)
AS
/*
**
** Object: BizTalkToCustomerInsert
**
** Description: Inserts records into the Customer table for the SQL adapter
** stored procedure recipe
**
**
*/
BEGIN
    Declare @intReturnCode int
    select    @intReturnCode = 0

    /*Insert records that will be returned to caller*/
    Insert Customer (CustomerName, Address, City, Region, PostalCode)
    Values (@CustomerName, @Address, @City, @Region, @PostalCode)

    /* Set the outbound return code */
    select    @intReturnCode = @@error

    /* return the return code */
    return @intReturnCode
END

go
grant execute on dbo.BizTalkToCustomerInsert to public
go
