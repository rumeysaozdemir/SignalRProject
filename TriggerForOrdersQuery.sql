---Artýrmak Ýçin Oluþturulan Trigger---
Create Trigger IncreaseOrderTotalPrice On OrderDetails After Insert 
As
Declare @OrderId int
Declare @OrderPrice decimal
Select @OrderId = OrderId From inserted
Select @OrderPrice = TotalPrice from inserted 
Update Orders Set TotalPrice = TotalPrice + @OrderPrice Where OrderId = @OrderId

