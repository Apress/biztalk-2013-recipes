if exists(select * from sysobjects where name = 'CustomerToBizTalk' and type = 'P')
    drop proc CustomerToBizTalk
go
CREATE procedure CustomerToBizTalk
AS
/*
**
** Object: CustomerToBizTalk
**
** Description: Retrieves records from the Customer table for the SQL receive
**                adapter recipe
**
**
*/
BEGIN
    /*Populate temp table with records that will be returned to caller*/
    Select top 1 CustomerID
        , CustomerName
        , Address
        , City
        , Region
        , PostalCode
        , RecordStatus
    Into    #TempCustomer
    From    Customer
    Where    RecordStatus = 1

    /*Update Status of retrieved record from the Customer table*/
    Update    Customer
    Set        RecordStatus = 0
    Where    CustomerID = (select CustomerID from #TempCustomer)

    /*Return records to caller*/
    Select CustomerID
        , CustomerName
        , Address
        , City
        , Region
        , PostalCode
        , RecordStatus
    from     #TempCustomer as Customer FOR XML AUTO, XMLData, Elements

    /*Clean up temp table*/
    drop table #TempCustomer
END

go
grant execute on dbo.CustomerToBizTalk to public
go
