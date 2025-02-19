Create procedure dbo.spGet_all_Records
as
begin
set nocount on;
select id,vardas,pavarde,numeris,gimimodata
from dbo.Adresai
end