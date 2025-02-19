Create procedure dbo.spIraso_Trynimas
(
@id int
)
as
begin
delete from Adresai 
where id=@id
end