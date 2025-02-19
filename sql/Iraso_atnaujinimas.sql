Create procedure dbo.spIrasu_Atnaujinimas
(
@param1 varchar(50),
@param2 varchar(50),
@param3 varchar(50),
@param4 varchar(50),
@salyga int

)
as
begin
Update Adresai
set vardas=@param1,pavarde=@param2,numeris=@param3,gimimodata=@param4
where id=@salyga

end