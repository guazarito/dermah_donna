
/****** Object:  Table [dbo].[adicional]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[adicional](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](100) NOT NULL,
	[valor] [float] NOT NULL,
	[deletado] [bit] NULL DEFAULT ((0)),
	[financTpValor] [int] NULL DEFAULT ((0)),
	[financValorSalao] [float] NULL DEFAULT ((0)),
	[financValorColab] [float] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[deletado] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[despesas]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[despesas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NOT NULL,
	[valor] [float] NOT NULL,
	[data] [datetime] NOT NULL,
	[deletado] [bit] NOT NULL,
	[lastChange] [timestamp] NOT NULL
) ON [PRIMARY]

CREATE TABLE [dbo].[forma_pgto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](100) NOT NULL,
	[deletado] [bit] NULL DEFAULT ((0)),
	[naoSomaTotaisRelatorios] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[funcionario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[deletado] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[procedimento]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[procedimento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](100) NOT NULL,
	[valor] [float] NOT NULL,
	[deletado] [bit] NULL DEFAULT ((0)),
	[financTpValor] [int] NULL,
	[financValorSalao] [float] NULL,
	[financValorColab] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SENHA]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SENHA](
	[id] [int] NOT NULL,
	[senha] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[senha] [varchar](100) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[deletado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendas]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_forma_pgto] [int] NOT NULL,
	[nome_cliente] [varchar](50) NULL,
	[desconto] [float] NULL,
	[valor_total] [float] NOT NULL,
	[data] [datetime] NOT NULL,
	[cancelado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendas_itens]    Script Date: 27/09/2021 13:49:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendas_itens](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_venda] [int] NOT NULL,
	[id_procedimento] [int] NULL,
	[id_adicional] [int] NULL,
	[id_func] [int] NULL,
	[vl_total_item] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((0)) FOR [deletado]
GO
/****** Object:  StoredProcedure [dbo].[RelatorioVendasItens]    Script Date: 27/09/2021 13:49:52 ******/
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
USE [master]
GO
ALTER DATABASE [dermahdonna] SET  READ_WRITE 
GO
