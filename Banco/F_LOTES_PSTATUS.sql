
drop function F_LOTES_PSTATUS
go
create function F_LOTES_PSTATUS
(	
	-- Add the parameters for the function here
@IdStatus int

)
RETURNS TABLE 
AS
RETURN 
(
select * from
(
SELECT 
      [LTU_IdUsuario]
      ,[LTU_CodigoPassagem]
      ,MAX([LTU_IdStatusLote])[LTU_IdStatusLote]
      ,MAX([LTU_Data])[LTU_Data]
      ,[LTU_Observacao]
      ,[LTU_PathImagens]
  FROM [GEDPES_OI_PRD].[dbo].[GEDLotesXUsuarios]
  where [LTU_IdStatusLote] = @IdStatus
  group by 
	   [LTU_IdUsuario]
      ,[LTU_CodigoPassagem]
      ,[LTU_Observacao]	
      ,[LTU_PathImagens]
)A
join GEDStatusLote on LTU_IdStatusLote = STL_Id
)