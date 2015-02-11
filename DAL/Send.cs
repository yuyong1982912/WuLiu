using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Send
	/// </summary>
	public partial class Send
	{
		public Send()
		{}
		
		#region 连接到WuLiu数据库
		/// <summary>
		/// 连接到WuLiu数据库
		/// </summary>	
        /// <returns>数据库操作类</returns>
        DbHelperSQLP dbHelperSQLPWuLiu=new DbHelperSQLP(PubConstant.ConnectionString);        
		#endregion
		
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return dbHelperSQLPWuLiu.GetMaxID("SendId", "Send"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SendId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Send");
			strSql.Append(" where SendId=@SendId");
			SqlParameter[] parameters = {
					new SqlParameter("@SendId", SqlDbType.Int,4)
			};
			parameters[0].Value = SendId;

			return dbHelperSQLPWuLiu.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Send model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Send(");
			strSql.Append("CompanyName,FromName,Phone,Address)");
			strSql.Append(" values (");
			strSql.Append("@CompanyName,@FromName,@Phone,@Address)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@FromName", SqlDbType.NVarChar,20),
					new SqlParameter("@Phone", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.CompanyName;
			parameters[1].Value = model.FromName;
			parameters[2].Value = model.Phone;
			parameters[3].Value = model.Address;

			object obj = dbHelperSQLPWuLiu.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Maticsoft.Model.Send model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Send set ");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("FromName=@FromName,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Address=@Address");
			strSql.Append(" where SendId=@SendId");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,255),
					new SqlParameter("@FromName", SqlDbType.NVarChar,20),
					new SqlParameter("@Phone", SqlDbType.VarChar,20),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@SendId", SqlDbType.Int,4)};
			parameters[0].Value = model.CompanyName;
			parameters[1].Value = model.FromName;
			parameters[2].Value = model.Phone;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.SendId;

			int rows=dbHelperSQLPWuLiu.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(int SendId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Send ");
			strSql.Append(" where SendId=@SendId");
			SqlParameter[] parameters = {
					new SqlParameter("@SendId", SqlDbType.Int,4)
			};
			parameters[0].Value = SendId;

			int rows=dbHelperSQLPWuLiu.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string SendIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Send ");
			strSql.Append(" where SendId in ("+SendIdlist + ")  ");
			int rows=dbHelperSQLPWuLiu.ExecuteSql(strSql.ToString());
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
		public Maticsoft.Model.Send GetModel(int SendId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SendId,CompanyName,FromName,Phone,Address from Send ");
			strSql.Append(" where SendId=@SendId");
			SqlParameter[] parameters = {
					new SqlParameter("@SendId", SqlDbType.Int,4)
			};
			parameters[0].Value = SendId;

			Maticsoft.Model.Send model=new Maticsoft.Model.Send();
			DataSet ds=dbHelperSQLPWuLiu.Query(strSql.ToString(),parameters);
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
		public Maticsoft.Model.Send DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Send model=new Maticsoft.Model.Send();
			if (row != null)
			{
				if(row["SendId"]!=null && row["SendId"].ToString()!="")
				{
					model.SendId=int.Parse(row["SendId"].ToString());
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["FromName"]!=null)
				{
					model.FromName=row["FromName"].ToString();
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
			strSql.Append("select SendId,CompanyName,FromName,Phone,Address ");
			strSql.Append(" FROM Send ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return dbHelperSQLPWuLiu.Query(strSql.ToString());
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
			strSql.Append(" SendId,CompanyName,FromName,Phone,Address ");
			strSql.Append(" FROM Send ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbHelperSQLPWuLiu.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Send ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = dbHelperSQLPWuLiu.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.SendId desc");
			}
			strSql.Append(")AS Row, T.*  from Send T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return dbHelperSQLPWuLiu.Query(strSql.ToString());
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
			parameters[0].Value = "Send";
			parameters[1].Value = "SendId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return dbHelperSQLPWuLiu.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

