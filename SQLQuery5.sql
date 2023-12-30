Create Trigger SumMoneyCases
On Orders
After Update
AS
Declare @Description Nvarchar(Max)
Declare @TotalPrice Decimal(18,2)
Select @Description = Description From inserted
Select @TotalPrice = TotalPrice From inserted

if(@Description = 'Hesap Kapatýldý')
Begin
Update MoneyCases Set TotalAmount = TotalAmount + @TotalPrice
End