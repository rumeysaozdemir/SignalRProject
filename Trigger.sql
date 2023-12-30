---Azaltmak Ýçin Oluþturulan Trigger---
After Trigger DecreaseOrderTotalPrice 
On OrderDetails 
After Delete
As
Declare @OrderId int
Declare @OrderPrice decimal
Select @OrderId = OrderId From deleted
Select @OrderPrice = TotalPrice from deleted 
Update Orders Set TotalPrice = TotalPrice - @OrderPrice Where OrderId = @OrderId