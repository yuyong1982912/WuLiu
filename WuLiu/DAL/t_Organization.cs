using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:t_Organization
	/// </summary>
	public partial class t_Organization
	{
		public t_Organization()
		{}

        #region 连接到金蝶数据库
        /// <summary>
        /// 连接到K3数据库
        /// </summary>	
        /// <returns>数据库操作类</returns>
        DbHelperSQLP dbHelperSQLPK3 = new DbHelperSQLP(PubConstant.ConnectionString1);
        #endregion

		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return dbHelperSQLPK3.GetMaxID("FItemID", "t_Organization"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FItemID,int FParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_Organization");
			strSql.Append(" where FItemID=@FItemID and FParentID=@FParentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FItemID", SqlDbType.Int,4),
					new SqlParameter("@FParentID", SqlDbType.Int,4)			};
			parameters[0].Value = FItemID;
			parameters[1].Value = FParentID;

			return dbHelperSQLPK3.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.t_Organization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_Organization(");
			strSql.Append("FItemID,FName)");
			strSql.Append(" values (");
			strSql.Append("@FItemID,@FName)");
			SqlParameter[] parameters = {
					new SqlParameter("@FItemID", SqlDbType.Int,4),
					new SqlParameter("@FName", SqlDbType.VarChar,255)};
			parameters[0].Value = model.FItemID;
			parameters[1].Value = model.FName;

			int rows=dbHelperSQLPK3.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.t_Organization model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_Organization set ");
			strSql.Append("FName=@FName");
			strSql.Append(" where FItemID=@FItemID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FItemID", SqlDbType.Int,4),
					new SqlParameter("@FName", SqlDbType.VarChar,255)};
			parameters[0].Value = model.FItemID;
			parameters[1].Value = model.FName;

			int rows=dbHelperSQLPK3.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int FItemID,int FParentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_Organization ");
			strSql.Append(" where FItemID=@FItemID and FParentID=@FParentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FItemID", SqlDbType.Int,4),
					new SqlParameter("@FParentID", SqlDbType.Int,4)			};
			parameters[0].Value = FItemID;
			parameters[1].Value = FParentID;

			int rows=dbHelperSQLPK3.ExecuteSql(strSql.ToString(),parameters);
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
		public Maticsoft.Model.t_Organization GetModel(int FItemID,int FParentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FItemID,FName from t_Organization ");
			strSql.Append(" where FItemID=@FItemID and FParentID=@FParentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FItemID", SqlDbType.Int,4),
					new SqlParameter("@FParentID", SqlDbType.Int,4)			};
			parameters[0].Value = FItemID;
			parameters[1].Value = FParentID;

			Maticsoft.Model.t_Organization model=new Maticsoft.Model.t_Organization();
			DataSet ds=dbHelperSQLPK3.Query(strSql.ToString(),parameters);
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
		public Maticsoft.Model.t_Organization DataRowToModel(DataRow row)
		{
			Maticsoft.Model.t_Organization model=new Maticsoft.Model.t_Organization();
			if (row != null)
			{
				if(row["FItemID"]!=null && row["FItemID"].ToString()!="")
				{
					model.FItemID=int.Parse(row["FItemID"].ToString());
				}
				if(row["FName"]!=null)
				{
					model.FName=row["FName"].ToString();
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
			strSql.Append("select FItemID,FName ");
			strSql.Append(" FROM t_Organization ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return dbHelperSQLPK3.Query(strSql.ToString());
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
			strSql.Append(" FItemID,FName ");
			strSql.Append(" FROM t_Organization ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbHelperSQLPK3.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM t_Organization ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = dbHelperSQLPK3.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.FParentID desc");
			}
			strSql.Append(")AS Row, T.*  from t_Organization T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return dbHelperSQLPK3.Query(strSql.ToString());
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
			parameters[0].Value = "t_Organization";
			parameters[1].Value = "FParentID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return dbHelperSQLPK3.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

