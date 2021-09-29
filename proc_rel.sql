USE [dermahdonna]
GO

/****** Object:  StoredProcedure [dbo].[RelatorioVendasItens]    Script Date: 27/09/2021 20:05:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RelatorioVendasItens] @DtInicial nvarchar(30), @DtFinal nvarchar(30)
AS
		CREATE TABLE #TempRelItens(
			id VARCHAR(20),
			cliente varchar (255),
			data varchar (50),
			descricao varchar(100),
			valor varchar(40)
		)


		DECLARE @id_venda int
		DECLARE @desconto float
		DECLARE @cliente varchar(100)

		DECLARE cr CURSOR FOR     
		SELECT id FROM vendas 
		where isnull(cancelado,0)<>1 and convert(date,data,103) >= @DtInicial and convert(date,data,103) <= @DtFinal    
  
		OPEN cr    
  
		FETCH NEXT FROM cr INTO @id_venda   
  
	    WHILE @@FETCH_STATUS = 0    
		BEGIN    
			INSERT INTO #TempRelItens (id, cliente, data, descricao, valor) 
			select right('00000' + cast(vi.id_venda as nvarchar),6),
			v.nome_cliente, convert(varchar(11), v.data,103), 
			(select case when vi.id_adicional is null then p.descricao else 'adicional: ' + a.descricao end),
			format(vi.vl_total_item, 'c', 'pt-br')
			from vendas_itens vi 
			left outer join vendas v on vi.id_venda=v.id 
			left outer join procedimento p on p.id=vi.id_procedimento 
			left outer join adicional a on a.id=vi.id_adicional 
			where vi.id_venda = @id_venda
   
			SELECT @desconto = ISNULL(DESCONTO,0), @cliente = nome_cliente  FROM vendas WHERE id = @id_venda

			IF (@desconto >0)
			BEGIN
				INSERT INTO #TempRelItens (id, cliente, data, descricao, valor) 
					values (right('00000' + cast(@id_venda as nvarchar),6),@cliente,(select convert(varchar(11),data,103) from vendas where id = @id_venda),'Desconto',  '- ' + format(@desconto, 'c', 'pt-br') )
			END
			FETCH NEXT FROM cr INTO @id_venda
		END     
		CLOSE cr;    
		DEALLOCATE cr;

		SELECT ROW_NUMBER() over(order by id) as ' Item', 
		id as 'Núm. da Venda', 
		cliente as '   Cliente', 
		data as '    Data', 
		descricao as '    Descrição', 
		valor as 'Valor Ítem'
		FROM #TempRelItens

GO

