using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:vwICBill
	/// </summary>
	public partial class vwICBill
	{
		public vwICBill()
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
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from vwICBill_8");
			strSql.Append(" where FInterID=@FInterID and FNumber=@FNumber and Fmodel=@Fmodel and FSourceTranType=@FSourceTranType and FSourceBillNo=@FSourceBillNo and Fauxqty=@Fauxqty and FEntryID=@FEntryID and Fdate=@Fdate and FbillNo=@FbillNo and FSupplyID=@FSupplyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FNumber", SqlDbType.VarChar,80),
					new SqlParameter("@Fmodel", SqlDbType.VarChar,255),
					new SqlParameter("@FSourceTranType", SqlDbType.Int,4),
					new SqlParameter("@FSourceBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@Fauxqty", SqlDbType.Decimal,13),
					new SqlParameter("@FEntryID", SqlDbType.Int,4),
					new SqlParameter("@Fdate", SqlDbType.DateTime),
					new SqlParameter("@FbillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSupplyID", SqlDbType.VarChar,80)			};
			parameters[0].Value = FInterID;
			parameters[1].Value = FNumber;
			parameters[2].Value = Fmodel;
			parameters[3].Value = FSourceTranType;
			parameters[4].Value = FSourceBillNo;
			parameters[5].Value = Fauxqty;
			parameters[6].Value = FEntryID;
			parameters[7].Value = Fdate;
			parameters[8].Value = FbillNo;
			parameters[9].Value = FSupplyID;

			return dbHelperSQLPK3.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.vwICBill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into vwICBill_8(");
			strSql.Append("FInterID,FEntryID,Fdate,FbillNo,FSupplyID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty)");
			strSql.Append(" values (");
			strSql.Append("@FInterID,@FEntryID,@Fdate,@FbillNo,@FSupplyID,@FNumber,@Fmodel,@FSourceTranType,@FSourceBillNo,@Fauxqty)");
			SqlParameter[] parameters = {
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FEntryID", SqlDbType.Int,4),
					new SqlParameter("@Fdate", SqlDbType.DateTime),
					new SqlParameter("@FbillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSupplyID", SqlDbType.VarChar,80),
					new SqlParameter("@FNumber", SqlDbType.VarChar,80),
					new SqlParameter("@Fmodel", SqlDbType.VarChar,255),
					new SqlParameter("@FSourceTranType", SqlDbType.Int,4),
					new SqlParameter("@FSourceBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@Fauxqty", SqlDbType.Decimal,13)};
			parameters[0].Value = model.FInterID;
			parameters[1].Value = model.FEntryID;
			parameters[2].Value = model.Fdate;
			parameters[3].Value = model.FbillNo;
			parameters[4].Value = model.FSupplyID;
			parameters[5].Value = model.FNumber;
			parameters[6].Value = model.Fmodel;
			parameters[7].Value = model.FSourceTranType;
			parameters[8].Value = model.FSourceBillNo;
			parameters[9].Value = model.Fauxqty;

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
		public bool Update(Maticsoft.Model.vwICBill model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update vwICBill_8 set ");
			strSql.Append("FInterID=@FInterID,");
			strSql.Append("FEntryID=@FEntryID,");
			strSql.Append("Fdate=@Fdate,");
			strSql.Append("FbillNo=@FbillNo,");
			strSql.Append("FSupplyID=@FSupplyID,");
			strSql.Append("FNumber=@FNumber,");
			strSql.Append("Fmodel=@Fmodel,");
			strSql.Append("FSourceTranType=@FSourceTranType,");
			strSql.Append("FSourceBillNo=@FSourceBillNo,");
			strSql.Append("Fauxqty=@Fauxqty");
			strSql.Append(" where FInterID=@FInterID and FNumber=@FNumber and Fmodel=@Fmodel and FSourceTranType=@FSourceTranType and FSourceBillNo=@FSourceBillNo and Fauxqty=@Fauxqty and FEntryID=@FEntryID and Fdate=@Fdate and FbillNo=@FbillNo and FSupplyID=@FSupplyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FEntryID", SqlDbType.Int,4),
					new SqlParameter("@Fdate", SqlDbType.DateTime),
					new SqlParameter("@FbillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSupplyID", SqlDbType.VarChar,80),
					new SqlParameter("@FNumber", SqlDbType.VarChar,80),
					new SqlParameter("@Fmodel", SqlDbType.VarChar,255),
					new SqlParameter("@FSourceTranType", SqlDbType.Int,4),
					new SqlParameter("@FSourceBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@Fauxqty", SqlDbType.Decimal,13)};
			parameters[0].Value = model.FInterID;
			parameters[1].Value = model.FEntryID;
			parameters[2].Value = model.Fdate;
			parameters[3].Value = model.FbillNo;
			parameters[4].Value = model.FSupplyID;
			parameters[5].Value = model.FNumber;
			parameters[6].Value = model.Fmodel;
			parameters[7].Value = model.FSourceTranType;
			parameters[8].Value = model.FSourceBillNo;
			parameters[9].Value = model.Fauxqty;

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
		public bool Delete(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from vwICBill_8 ");
			strSql.Append(" where FInterID=@FInterID and FNumber=@FNumber and Fmodel=@Fmodel and FSourceTranType=@FSourceTranType and FSourceBillNo=@FSourceBillNo and Fauxqty=@Fauxqty and FEntryID=@FEntryID and Fdate=@Fdate and FbillNo=@FbillNo and FSupplyID=@FSupplyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FNumber", SqlDbType.VarChar,80),
					new SqlParameter("@Fmodel", SqlDbType.VarChar,255),
					new SqlParameter("@FSourceTranType", SqlDbType.Int,4),
					new SqlParameter("@FSourceBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@Fauxqty", SqlDbType.Decimal,13),
					new SqlParameter("@FEntryID", SqlDbType.Int,4),
					new SqlParameter("@Fdate", SqlDbType.DateTime),
					new SqlParameter("@FbillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSupplyID", SqlDbType.VarChar,80)			};
			parameters[0].Value = FInterID;
			parameters[1].Value = FNumber;
			parameters[2].Value = Fmodel;
			parameters[3].Value = FSourceTranType;
			parameters[4].Value = FSourceBillNo;
			parameters[5].Value = Fauxqty;
			parameters[6].Value = FEntryID;
			parameters[7].Value = Fdate;
			parameters[8].Value = FbillNo;
			parameters[9].Value = FSupplyID;

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
		public Maticsoft.Model.vwICBill GetModel(int FInterID,string FNumber,string Fmodel,int FSourceTranType,string FSourceBillNo,decimal Fauxqty,int FEntryID,DateTime Fdate,string FbillNo,string FSupplyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FInterID,FEntryID,Fdate,FbillNo,FSupplyID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty from vwICBill_8 ");
			strSql.Append(" where FInterID=@FInterID and FNumber=@FNumber and Fmodel=@Fmodel and FSourceTranType=@FSourceTranType and FSourceBillNo=@FSourceBillNo and Fauxqty=@Fauxqty and FEntryID=@FEntryID and Fdate=@Fdate and FbillNo=@FbillNo and FSupplyID=@FSupplyID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FNumber", SqlDbType.VarChar,80),
					new SqlParameter("@Fmodel", SqlDbType.VarChar,255),
					new SqlParameter("@FSourceTranType", SqlDbType.Int,4),
					new SqlParameter("@FSourceBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@Fauxqty", SqlDbType.Decimal,13),
					new SqlParameter("@FEntryID", SqlDbType.Int,4),
					new SqlParameter("@Fdate", SqlDbType.DateTime),
					new SqlParameter("@FbillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSupplyID", SqlDbType.VarChar,80)			};
			parameters[0].Value = FInterID;
			parameters[1].Value = FNumber;
			parameters[2].Value = Fmodel;
			parameters[3].Value = FSourceTranType;
			parameters[4].Value = FSourceBillNo;
			parameters[5].Value = Fauxqty;
			parameters[6].Value = FEntryID;
			parameters[7].Value = Fdate;
			parameters[8].Value = FbillNo;
			parameters[9].Value = FSupplyID;

			Maticsoft.Model.vwICBill model=new Maticsoft.Model.vwICBill();
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
		public Maticsoft.Model.vwICBill DataRowToModel(DataRow row)
		{
			Maticsoft.Model.vwICBill model=new Maticsoft.Model.vwICBill();
			if (row != null)
			{
				if(row["FInterID"]!=null && row["FInterID"].ToString()!="")
				{
					model.FInterID=int.Parse(row["FInterID"].ToString());
				}
				if(row["FEntryID"]!=null && row["FEntryID"].ToString()!="")
				{
					model.FEntryID=int.Parse(row["FEntryID"].ToString());
				}
				if(row["Fdate"]!=null && row["Fdate"].ToString()!="")
				{
					model.Fdate=DateTime.Parse(row["Fdate"].ToString());
				}
				if(row["FbillNo"]!=null)
				{
					model.FbillNo=row["FbillNo"].ToString();
				}
				if(row["FSupplyID"]!=null)
				{
					model.FSupplyID=row["FSupplyID"].ToString();
				}
				if(row["FNumber"]!=null)
				{
					model.FNumber=row["FNumber"].ToString();
				}
				if(row["Fmodel"]!=null)
				{
					model.Fmodel=row["Fmodel"].ToString();
				}
				if(row["FSourceTranType"]!=null && row["FSourceTranType"].ToString()!="")
				{
					model.FSourceTranType=int.Parse(row["FSourceTranType"].ToString());
				}
				if(row["FSourceBillNo"]!=null)
				{
					model.FSourceBillNo=row["FSourceBillNo"].ToString();
				}
				if(row["Fauxqty"]!=null && row["Fauxqty"].ToString()!="")
				{
					model.Fauxqty=decimal.Parse(row["Fauxqty"].ToString());
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
			strSql.Append("select a.FInterID,a.FEntryID,a.Fdate,a.FbillNo,a.FSupplyID,a.FNumber,a.Fmodel,a.FSourceTranType,a.FSourceBillNo,a.Fauxqty,b.FSize,b.FGrossWeight ");
			strSql.Append(" FROM vwICBill_8 a Left Join t_ICItem b on a.FNumber=b.FNumber ");
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
			strSql.Append(" FInterID,FEntryID,Fdate,FbillNo,FSupplyID,FNumber,Fmodel,FSourceTranType,FSourceBillNo,Fauxqty ");
			strSql.Append(" FROM vwICBill_8 ");
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
			strSql.Append("select count(1) FROM vwICBill_8 ");
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
				strSql.Append("order by T.FSupplyID desc");
			}
			strSql.Append(")AS Row, T.*  from vwICBill_8 T ");
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
			parameters[0].Value = "vwICBill_8";
			parameters[1].Value = "FSupplyID";
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

