Create procedure dbo.spIraso_Pridejimas(
@param1 varchar(50),
@param2 varchar(50),
@param3 varchar(50),
@param4 varchar(50)
)
as
begin
insert into Adresai(vardas,pavarde,numeris,gimimodata)
values(@param1,@param2,@param3,@param4)
end