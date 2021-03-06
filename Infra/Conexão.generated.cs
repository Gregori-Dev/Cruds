//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Linq;
using Crud.Domain;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;

namespace CrudModel
{
    /// <summary>
    /// Database       : Crud
    /// Data Source    : INVENT006
    /// Server Version : 15.00.2000
    /// </summary>
    public partial class CrudDB : LinqToDB.Data.DataConnection
	{
		public ITable<DadosUsuario> dadosUsuarios { get { return this.GetTable<DadosUsuario>(); } }

		public CrudDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public CrudDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public CrudDB(LinqToDbConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public CrudDB(LinqToDbConnectionOptions<CrudDB> options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}


	public static partial class CrudDBStoredProcedures
	{
		#region SpAlterdiagram

		public static int SpAlterdiagram(this CrudDB dataConnection, string @diagramname, int? @owner_id, int? @version, byte[] @definition)
		{
			return dataConnection.ExecuteProc("[dbo].[sp_alterdiagram]",
				new DataParameter("@diagramname", @diagramname, LinqToDB.DataType.NVarChar),
				new DataParameter("@owner_id",    @owner_id,    LinqToDB.DataType.Int32),
				new DataParameter("@version",     @version,     LinqToDB.DataType.Int32),
				new DataParameter("@definition",  @definition,  LinqToDB.DataType.VarBinary));
		}

		#endregion

		#region SpCreatediagram

		public static int SpCreatediagram(this CrudDB dataConnection, string @diagramname, int? @owner_id, int? @version, byte[] @definition)
		{
			return dataConnection.ExecuteProc("[dbo].[sp_creatediagram]",
				new DataParameter("@diagramname", @diagramname, LinqToDB.DataType.NVarChar),
				new DataParameter("@owner_id",    @owner_id,    LinqToDB.DataType.Int32),
				new DataParameter("@version",     @version,     LinqToDB.DataType.Int32),
				new DataParameter("@definition",  @definition,  LinqToDB.DataType.VarBinary));
		}

		#endregion

		#region SpDropdiagram

		public static int SpDropdiagram(this CrudDB dataConnection, string @diagramname, int? @owner_id)
		{
			return dataConnection.ExecuteProc("[dbo].[sp_dropdiagram]",
				new DataParameter("@diagramname", @diagramname, LinqToDB.DataType.NVarChar),
				new DataParameter("@owner_id",    @owner_id,    LinqToDB.DataType.Int32));
		}

		#endregion

		#region SpHelpdiagramdefinition

		public static IEnumerable<SpHelpdiagramdefinitionResult> SpHelpdiagramdefinition(this CrudDB dataConnection, string @diagramname, int? @owner_id)
		{
			return dataConnection.QueryProc<SpHelpdiagramdefinitionResult>("[dbo].[sp_helpdiagramdefinition]",
				new DataParameter("@diagramname", @diagramname, LinqToDB.DataType.NVarChar),
				new DataParameter("@owner_id",    @owner_id,    LinqToDB.DataType.Int32));
		}

		public partial class SpHelpdiagramdefinitionResult
		{
			public int?   version    { get; set; }
			public byte[] definition { get; set; }
		}

		#endregion

		#region SpHelpdiagrams

		public static IEnumerable<SpHelpdiagramsResult> SpHelpdiagrams(this CrudDB dataConnection, string @diagramname, int? @owner_id)
		{
			return dataConnection.QueryProc<SpHelpdiagramsResult>("[dbo].[sp_helpdiagrams]",
				new DataParameter("@diagramname", @diagramname, LinqToDB.DataType.NVarChar),
				new DataParameter("@owner_id",    @owner_id,    LinqToDB.DataType.Int32));
		}

		public partial class SpHelpdiagramsResult
		{
			public string Database { get; set; }
			public string Name     { get; set; }
			public int    ID       { get; set; }
			public string Owner    { get; set; }
			public int    OwnerID  { get; set; }
		}

		#endregion

		#region SpRenamediagram

		public static int SpRenamediagram(this CrudDB dataConnection, string @diagramname, int? @owner_id, string @new_diagramname)
		{
			return dataConnection.ExecuteProc("[dbo].[sp_renamediagram]",
				new DataParameter("@diagramname",     @diagramname,     LinqToDB.DataType.NVarChar),
				new DataParameter("@owner_id",        @owner_id,        LinqToDB.DataType.Int32),
				new DataParameter("@new_diagramname", @new_diagramname, LinqToDB.DataType.NVarChar));
		}

		#endregion
	}

	public static partial class SqlFunctions
	{
		#region FnDiagramobjects

		[Sql.Function(Name="dbo.fn_diagramobjects", ServerSideOnly=true)]
		public static int? FnDiagramobjects()
		{
			throw new InvalidOperationException();
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static DadosUsuario Find(this ITable<DadosUsuario> table, int IdClientes)
		{
			return table.FirstOrDefault(t =>
				t.IdClientes == IdClientes);
		}
	}
}

#pragma warning restore 1591
