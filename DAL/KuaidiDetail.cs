using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:KuaidiDetail
	/// </summary>
	public partial class KuaidiDetail
	{
		public KuaidiDetail()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KuaidiDetail");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.KuaidiDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KuaidiDetail(");
			strSql.Append("FKuaiDiId,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo)");
			strSql.Append(" values (");
			strSql.Append("@FKuaiDiId,@FNumber,@FModel,@FInterID,@FOrderInterID,@FCItemID,@FQty,@FSize,@FGrossWeight,@FSSize,@FSGrossWeight,@FMemo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FKuaiDiId", SqlDbType.NVarChar,20),
					new SqlParameter("@FNumber", SqlDbType.NVarChar,80),
					new SqlParameter("@FModel", SqlDbType.NVarChar,255),
					new SqlParameter("@FInterID", SqlDbType.NVarChar,500),
					new SqlParameter("@FOrderInterID", SqlDbType.NVarChar,500),
					new SqlParameter("@FCItemID", SqlDbType.NVarChar,255),
					new SqlParameter("@FQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSize", SqlDbType.Decimal,13),
					new SqlParameter("@FGrossWeight", SqlDbType.Decimal,13),
					new SqlParameter("@FSSize", SqlDbType.Decimal,13),
					new SqlParameter("@FSGrossWeight", SqlDbType.Decimal,13),
					new SqlParameter("@FMemo", SqlDbType.Text)};
			parameters[0].Value = model.FKuaiDiId;
			parameters[1].Value = model.FNumber;
			parameters[2].Value = model.FModel;
			parameters[3].Value = model.FInterID;
			parameters[4].Value = model.FOrderInterID;
			parameters[5].Value = model.FCItemID;
			parameters[6].Value = model.FQty;
			parameters[7].Value = model.FSize;
			parameters[8].Value = model.FGrossWeight;
			parameters[9].Value = model.FSSize;
			parameters[10].Value = model.FSGrossWeight;
			parameters[11].Value = model.FMemo;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.KuaidiDetail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KuaidiDetail set ");
			strSql.Append("FKuaiDiId=@FKuaiDiId,");
			strSql.Append("FNumber=@FNumber,");
			strSql.Append("FModel=@FModel,");
			strSql.Append("FInterID=@FInterID,");
			strSql.Append("FOrderInterID=@FOrderInterID,");
			strSql.Append("FCItemID=@FCItemID,");
			strSql.Append("FQty=@FQty,");
			strSql.Append("FSize=@FSize,");
			strSql.Append("FGrossWeight=@FGrossWeight,");
			strSql.Append("FSSize=@FSSize,");
			strSql.Append("FSGrossWeight=@FSGrossWeight,");
			strSql.Append("FMemo=@FMemo");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@FKuaiDiId", SqlDbType.NVarChar,20),
					new SqlParameter("@FNumber", SqlDbType.NVarChar,80),
					new SqlParameter("@FModel", SqlDbType.NVarChar,255),
					new SqlParameter("@FInterID", SqlDbType.NVarChar,500),
					new SqlParameter("@FOrderInterID", SqlDbType.NVarChar,500),
					new SqlParameter("@FCItemID", SqlDbType.NVarChar,255),
					new SqlParameter("@FQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSize", SqlDbType.Decimal,13),
					new SqlParameter("@FGrossWeight", SqlDbType.Decimal,13),
					new SqlParameter("@FSSize", SqlDbType.Decimal,13),
					new SqlParameter("@FSGrossWeight", SqlDbType.Decimal,13),
					new SqlParameter("@FMemo", SqlDbType.Text),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.FKuaiDiId;
			parameters[1].Value = model.FNumber;
			parameters[2].Value = model.FModel;
			parameters[3].Value = model.FInterID;
			parameters[4].Value = model.FOrderInterID;
			parameters[5].Value = model.FCItemID;
			parameters[6].Value = model.FQty;
			parameters[7].Value = model.FSize;
			parameters[8].Value = model.FGrossWeight;
			parameters[9].Value = model.FSSize;
			parameters[10].Value = model.FSGrossWeight;
			parameters[11].Value = model.FMemo;
			parameters[12].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KuaidiDetail ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KuaidiDetail ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.KuaidiDetail GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,FKuaiDiId,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo from KuaidiDetail ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Maticsoft.Model.KuaidiDetail model=new Maticsoft.Model.KuaidiDetail();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.KuaidiDetail DataRowToModel(DataRow row)
		{
			Maticsoft.Model.KuaidiDetail model=new Maticsoft.Model.KuaidiDetail();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["FKuaiDiId"]!=null)
				{
					model.FKuaiDiId=row["FKuaiDiId"].ToString();
				}
				if(row["FNumber"]!=null)
				{
					model.FNumber=row["FNumber"].ToString();
				}
				if(row["FModel"]!=null)
				{
					model.FModel=row["FModel"].ToString();
				}
				if(row["FInterID"]!=null)
				{
					model.FInterID=row["FInterID"].ToString();
				}
				if(row["FOrderInterID"]!=null)
				{
					model.FOrderInterID=row["FOrderInterID"].ToString();
				}
				if(row["FCItemID"]!=null)
				{
					model.FCItemID=row["FCItemID"].ToString();
				}
				if(row["FQty"]!=null && row["FQty"].ToString()!="")
				{
					model.FQty=decimal.Parse(row["FQty"].ToString());
				}
				if(row["FSize"]!=null && row["FSize"].ToString()!="")
				{
					model.FSize=decimal.Parse(row["FSize"].ToString());
				}
				if(row["FGrossWeight"]!=null && row["FGrossWeight"].ToString()!="")
				{
					model.FGrossWeight=decimal.Parse(row["FGrossWeight"].ToString());
				}
				if(row["FSSize"]!=null && row["FSSize"].ToString()!="")
				{
					model.FSSize=decimal.Parse(row["FSSize"].ToString());
				}
				if(row["FSGrossWeight"]!=null && row["FSGrossWeight"].ToString()!="")
				{
					model.FSGrossWeight=decimal.Parse(row["FSGrossWeight"].ToString());
				}
				if(row["FMemo"]!=null)
				{
					model.FMemo=row["FMemo"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,FKuaiDiId,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo ");
			strSql.Append(" FROM KuaidiDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,FKuaiDiId,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo ");
			strSql.Append(" FROM KuaidiDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM KuaidiDetail ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from KuaidiDetail T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "KuaidiDetail";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

