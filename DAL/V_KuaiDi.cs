using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:V_KuaiDi
	/// </summary>
	public partial class V_KuaiDi
	{
		public V_KuaiDi()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from V_KuaiDi");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.V_KuaiDi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into V_KuaiDi(");
			strSql.Append("Id,FKuaiDiId,Name,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo,Date,CompanyName,ToName,Phone,Address)");
			strSql.Append(" values (");
			strSql.Append("@Id,@FKuaiDiId,@Name,@FNumber,@FModel,@FInterID,@FOrderInterID,@FCItemID,@FQty,@FSize,@FGrossWeight,@FSSize,@FSGrossWeight,@FMemo,@Date,@CompanyName,@ToName,@Phone,@Address)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@FKuaiDiId", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,20),
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
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@ToName", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,255),
					new SqlParameter("@Address", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.FKuaiDiId;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.FNumber;
			parameters[4].Value = model.FModel;
			parameters[5].Value = model.FInterID;
			parameters[6].Value = model.FOrderInterID;
			parameters[7].Value = model.FCItemID;
			parameters[8].Value = model.FQty;
			parameters[9].Value = model.FSize;
			parameters[10].Value = model.FGrossWeight;
			parameters[11].Value = model.FSSize;
			parameters[12].Value = model.FSGrossWeight;
			parameters[13].Value = model.FMemo;
			parameters[14].Value = model.Date;
			parameters[15].Value = model.CompanyName;
			parameters[16].Value = model.ToName;
			parameters[17].Value = model.Phone;
			parameters[18].Value = model.Address;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.V_KuaiDi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update V_KuaiDi set ");
			strSql.Append("Id=@Id,");
			strSql.Append("FKuaiDiId=@FKuaiDiId,");
			strSql.Append("Name=@Name,");
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
			strSql.Append("FMemo=@FMemo,");
			strSql.Append("Date=@Date,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("ToName=@ToName,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Address=@Address");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@FKuaiDiId", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,20),
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
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@ToName", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,255),
					new SqlParameter("@Address", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.FKuaiDiId;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.FNumber;
			parameters[4].Value = model.FModel;
			parameters[5].Value = model.FInterID;
			parameters[6].Value = model.FOrderInterID;
			parameters[7].Value = model.FCItemID;
			parameters[8].Value = model.FQty;
			parameters[9].Value = model.FSize;
			parameters[10].Value = model.FGrossWeight;
			parameters[11].Value = model.FSSize;
			parameters[12].Value = model.FSGrossWeight;
			parameters[13].Value = model.FMemo;
			parameters[14].Value = model.Date;
			parameters[15].Value = model.CompanyName;
			parameters[16].Value = model.ToName;
			parameters[17].Value = model.Phone;
			parameters[18].Value = model.Address;

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
			strSql.Append("delete from V_KuaiDi ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
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
			strSql.Append("delete from V_KuaiDi ");
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
		public Maticsoft.Model.V_KuaiDi GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,FKuaiDiId,Name,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo,Date,CompanyName,ToName,Phone,Address from V_KuaiDi ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Maticsoft.Model.V_KuaiDi model=new Maticsoft.Model.V_KuaiDi();
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
		public Maticsoft.Model.V_KuaiDi DataRowToModel(DataRow row)
		{
			Maticsoft.Model.V_KuaiDi model=new Maticsoft.Model.V_KuaiDi();
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
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
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
				if(row["Date"]!=null && row["Date"].ToString()!="")
				{
					model.Date=DateTime.Parse(row["Date"].ToString());
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["ToName"]!=null)
				{
					model.ToName=row["ToName"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
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
			strSql.Append("select Id,FKuaiDiId,Name,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo,Date,CompanyName,ToName,Phone,Address ");
			strSql.Append(" FROM V_KuaiDi ");
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
			strSql.Append(" Id,FKuaiDiId,Name,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize,FGrossWeight,FSSize,FSGrossWeight,FMemo,Date,CompanyName,ToName,Phone,Address ");
			strSql.Append(" FROM V_KuaiDi ");
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
			strSql.Append("select count(1) FROM V_KuaiDi ");
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
			strSql.Append(")AS Row, T.*  from V_KuaiDi T ");
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
			parameters[0].Value = "V_KuaiDi";
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

