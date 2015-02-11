using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:KuaiDi
	/// </summary>
	public partial class KuaiDi
	{
		public KuaiDi()
		{}
		
		#region 连接到WuLiu数据库
		/// <summary>
		/// 连接到WuLiu数据库
		/// </summary>	
        /// <returns>数据库操作类</returns>
        DbHelperSQLP dbHelperSQLPWuLiu=new DbHelperSQLP(PubConstant.ConnectionString);        
		#endregion
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KuaiDi");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,20)			};
			parameters[0].Value = Id;

			return dbHelperSQLPWuLiu.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据,及其子表数据
		/// </summary>
		public void Add(Maticsoft.Model.KuaiDi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KuaiDi(");
			strSql.Append("Id,Memo,Date,Amount,KuaidiTypeId,ReceiveId,SendId,FItemId,FSumSize,FSumGrossWeight)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Memo,@Date,@Amount,@KuaidiTypeId,@ReceiveId,@SendId,@FItemId,@FSumSize,@FSumGrossWeight)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,20),
					new SqlParameter("@Memo", SqlDbType.Text),
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@Amount", SqlDbType.Decimal,5),
					new SqlParameter("@KuaidiTypeId", SqlDbType.Int,4),
					new SqlParameter("@ReceiveId", SqlDbType.Int,4),
					new SqlParameter("@SendId", SqlDbType.Int,4),
					new SqlParameter("@FItemId", SqlDbType.Int,4),
					new SqlParameter("@FSumSize", SqlDbType.Decimal,13),
					new SqlParameter("@FSumGrossWeight", SqlDbType.Decimal,13)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Memo;
			parameters[2].Value = model.Date;
			parameters[3].Value = model.Amount;
			parameters[4].Value = model.KuaidiTypeId;
			parameters[5].Value = model.ReceiveId;
			parameters[6].Value = model.SendId;
			parameters[7].Value = model.FItemId;
			parameters[8].Value = model.FSumSize;
			parameters[9].Value = model.FSumGrossWeight;

			List<CommandInfo> sqllist = new List<CommandInfo>();
			CommandInfo cmd = new CommandInfo(strSql.ToString(), parameters);
			sqllist.Add(cmd);
			StringBuilder strSql2;
			foreach (Maticsoft.Model.KuaidiDetail models in model.KuaidiDetails)
			{
				strSql2=new StringBuilder();
				strSql2.Append("insert into KuaidiDetail(");
				strSql2.Append("FGrossWeight,FSSize,FSGrossWeight,FMemo,FKuaiDiId,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize)");
				strSql2.Append(" values (");
				strSql2.Append("@FGrossWeight,@FSSize,@FSGrossWeight,@FMemo,@FKuaiDiId,@FNumber,@FModel,@FInterID,@FOrderInterID,@FCItemID,@FQty,@FSize)");
				SqlParameter[] parameters2 = {
						new SqlParameter("@FGrossWeight", SqlDbType.Decimal,13),
						new SqlParameter("@FSSize", SqlDbType.Decimal,13),
						new SqlParameter("@FSGrossWeight", SqlDbType.Decimal,13),
						new SqlParameter("@FMemo", SqlDbType.Text),
						new SqlParameter("@FKuaiDiId", SqlDbType.NVarChar,20),
						new SqlParameter("@FNumber", SqlDbType.NVarChar,80),
						new SqlParameter("@FModel", SqlDbType.NVarChar,255),
						new SqlParameter("@FInterID", SqlDbType.NVarChar,500),
						new SqlParameter("@FOrderInterID", SqlDbType.NVarChar,500),
						new SqlParameter("@FCItemID", SqlDbType.NVarChar,255),
						new SqlParameter("@FQty", SqlDbType.Decimal,13),
						new SqlParameter("@FSize", SqlDbType.Decimal,13)};
				parameters2[0].Value = models.FGrossWeight;
				parameters2[1].Value = models.FSSize;
				parameters2[2].Value = models.FSGrossWeight;
				parameters2[3].Value = models.FMemo;
				parameters2[4].Value = models.FKuaiDiId;
				parameters2[5].Value = models.FNumber;
				parameters2[6].Value = models.FModel;
				parameters2[7].Value = models.FInterID;
				parameters2[8].Value = models.FOrderInterID;
				parameters2[9].Value = models.FCItemID;
				parameters2[10].Value = models.FQty;
				parameters2[11].Value = models.FSize;

				cmd = new CommandInfo(strSql2.ToString(), parameters2);
				sqllist.Add(cmd);
			}
			dbHelperSQLPWuLiu.ExecuteSqlTran(sqllist);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.KuaiDi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KuaiDi set ");
			strSql.Append("Memo=@Memo,");
			strSql.Append("Date=@Date,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("KuaidiTypeId=@KuaidiTypeId,");
			strSql.Append("ReceiveId=@ReceiveId,");
			strSql.Append("SendId=@SendId,");
			strSql.Append("FItemId=@FItemId,");
			strSql.Append("FSumSize=@FSumSize,");
			strSql.Append("FSumGrossWeight=@FSumGrossWeight");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,20),
					new SqlParameter("@Memo", SqlDbType.Text),
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@Amount", SqlDbType.Decimal,5),
					new SqlParameter("@KuaidiTypeId", SqlDbType.Int,4),
					new SqlParameter("@ReceiveId", SqlDbType.Int,4),
					new SqlParameter("@SendId", SqlDbType.Int,4),
					new SqlParameter("@FItemId", SqlDbType.Int,4),
					new SqlParameter("@FSumSize", SqlDbType.Decimal,13),
					new SqlParameter("@FSumGrossWeight", SqlDbType.Decimal,13)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Memo;
			parameters[2].Value = model.Date;
			parameters[3].Value = model.Amount;
			parameters[4].Value = model.KuaidiTypeId;
			parameters[5].Value = model.ReceiveId;
			parameters[6].Value = model.SendId;
			parameters[7].Value = model.FItemId;
			parameters[8].Value = model.FSumSize;
			parameters[9].Value = model.FSumGrossWeight;

			int rowsAffected=dbHelperSQLPWuLiu.ExecuteSql(strSql.ToString(),parameters);
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据，及子表所有相关数据
		/// </summary>
		public bool Delete(string Id)
		{
			List<CommandInfo> sqllist = new List<CommandInfo>();
			StringBuilder strSql2=new StringBuilder();
			strSql2.Append("delete KuaidiDetail ");
			strSql2.Append(" where FKuaiDiId=@FKuaiDiId ");
			SqlParameter[] parameters2 = {
					new SqlParameter("@FKuaiDiId", SqlDbType.NVarChar,-1)};
			parameters2[0].Value = Id;

			CommandInfo cmd = new CommandInfo(strSql2.ToString(), parameters2);
			sqllist.Add(cmd);
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete KuaiDi ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,20)			};
			parameters[0].Value = Id;

			cmd = new CommandInfo(strSql.ToString(), parameters);
			sqllist.Add(cmd);
			int rowsAffected=dbHelperSQLPWuLiu.ExecuteSqlTran(sqllist);
			if (rowsAffected > 0)
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
		public bool DeleteList(string Idlist )
		{
			List<string> sqllist = new List<string>();
			StringBuilder strSql2=new StringBuilder();
			strSql2.Append("delete from KuaidiDetail ");
			strSql2.Append(" where FKuaiDiId in ("+Idlist + ")  ");
			sqllist.Add(strSql2.ToString());
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KuaiDi ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			sqllist.Add(strSql.ToString());
			int rowsAffected=dbHelperSQLPWuLiu.ExecuteSqlTran(sqllist);
			if (rowsAffected > 0)
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
		public Maticsoft.Model.KuaiDi GetModel(string Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Memo,Date,Amount,KuaidiTypeId,ReceiveId,SendId,FItemId,FSumSize,FSumGrossWeight from KuaiDi ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,20)			};
			parameters[0].Value = Id;

			Maticsoft.Model.KuaiDi model=new Maticsoft.Model.KuaiDi();
			DataSet ds=dbHelperSQLPWuLiu.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				#region  父表信息
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=ds.Tables[0].Rows[0]["Id"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo"]!=null && ds.Tables[0].Rows[0]["Memo"].ToString()!="")
				{
					model.Memo=ds.Tables[0].Rows[0]["Memo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Date"]!=null && ds.Tables[0].Rows[0]["Date"].ToString()!="")
				{
					model.Date=DateTime.Parse(ds.Tables[0].Rows[0]["Date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Amount"]!=null && ds.Tables[0].Rows[0]["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["KuaidiTypeId"]!=null && ds.Tables[0].Rows[0]["KuaidiTypeId"].ToString()!="")
				{
					model.KuaidiTypeId=int.Parse(ds.Tables[0].Rows[0]["KuaidiTypeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ReceiveId"]!=null && ds.Tables[0].Rows[0]["ReceiveId"].ToString()!="")
				{
					model.ReceiveId=int.Parse(ds.Tables[0].Rows[0]["ReceiveId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SendId"]!=null && ds.Tables[0].Rows[0]["SendId"].ToString()!="")
				{
					model.SendId=int.Parse(ds.Tables[0].Rows[0]["SendId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FItemId"]!=null && ds.Tables[0].Rows[0]["FItemId"].ToString()!="")
				{
					model.FItemId=int.Parse(ds.Tables[0].Rows[0]["FItemId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FSumSize"]!=null && ds.Tables[0].Rows[0]["FSumSize"].ToString()!="")
				{
					model.FSumSize=decimal.Parse(ds.Tables[0].Rows[0]["FSumSize"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FSumGrossWeight"]!=null && ds.Tables[0].Rows[0]["FSumGrossWeight"].ToString()!="")
				{
					model.FSumGrossWeight=decimal.Parse(ds.Tables[0].Rows[0]["FSumGrossWeight"].ToString());
				}
				#endregion  父表信息end

				#region  子表信息
				StringBuilder strSql2=new StringBuilder();
				strSql2.Append("select Id,FGrossWeight,FSSize,FSGrossWeight,FMemo,FKuaiDiId,FNumber,FModel,FInterID,FOrderInterID,FCItemID,FQty,FSize from KuaidiDetail ");
				strSql2.Append(" where FKuaiDiId=@FKuaiDiId ");
			SqlParameter[] parameters2 = {
					new SqlParameter("@Id", SqlDbType.NVarChar,-1)};
			parameters2[0].Value = Id;

				DataSet ds2=dbHelperSQLPWuLiu.Query(strSql2.ToString(),parameters2);
				if(ds2.Tables[0].Rows.Count>0)
				{
					#region  子表字段信息
					int i = ds2.Tables[0].Rows.Count;
					List<Maticsoft.Model.KuaidiDetail> models = new List<Maticsoft.Model.KuaidiDetail>();
					Maticsoft.Model.KuaidiDetail modelt;
					for (int n = 0; n < i; n++)
					{
						modelt = new Maticsoft.Model.KuaidiDetail();
						if(ds2.Tables[0].Rows[n]["Id"]!=null && ds2.Tables[0].Rows[n]["Id"].ToString()!="")
						{
							modelt.Id=int.Parse(ds2.Tables[0].Rows[n]["Id"].ToString());
						}
						if(ds2.Tables[0].Rows[n]["FGrossWeight"]!=null && ds2.Tables[0].Rows[n]["FGrossWeight"].ToString()!="")
						{
							modelt.FGrossWeight=decimal.Parse(ds2.Tables[0].Rows[n]["FGrossWeight"].ToString());
						}
						if(ds2.Tables[0].Rows[n]["FSSize"]!=null && ds2.Tables[0].Rows[n]["FSSize"].ToString()!="")
						{
							modelt.FSSize=decimal.Parse(ds2.Tables[0].Rows[n]["FSSize"].ToString());
						}
						if(ds2.Tables[0].Rows[n]["FSGrossWeight"]!=null && ds2.Tables[0].Rows[n]["FSGrossWeight"].ToString()!="")
						{
							modelt.FSGrossWeight=decimal.Parse(ds2.Tables[0].Rows[n]["FSGrossWeight"].ToString());
						}
						if(ds2.Tables[0].Rows[n]["FMemo"]!=null && ds2.Tables[0].Rows[n]["FMemo"].ToString()!="")
						{
							modelt.FMemo=ds2.Tables[0].Rows[n]["FMemo"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FKuaiDiId"]!=null && ds2.Tables[0].Rows[n]["FKuaiDiId"].ToString()!="")
						{
							modelt.FKuaiDiId=ds2.Tables[0].Rows[n]["FKuaiDiId"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FNumber"]!=null && ds2.Tables[0].Rows[n]["FNumber"].ToString()!="")
						{
							modelt.FNumber=ds2.Tables[0].Rows[n]["FNumber"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FModel"]!=null && ds2.Tables[0].Rows[n]["FModel"].ToString()!="")
						{
							modelt.FModel=ds2.Tables[0].Rows[n]["FModel"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FInterID"]!=null && ds2.Tables[0].Rows[n]["FInterID"].ToString()!="")
						{
							modelt.FInterID=ds2.Tables[0].Rows[n]["FInterID"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FOrderInterID"]!=null && ds2.Tables[0].Rows[n]["FOrderInterID"].ToString()!="")
						{
							modelt.FOrderInterID=ds2.Tables[0].Rows[n]["FOrderInterID"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FCItemID"]!=null && ds2.Tables[0].Rows[n]["FCItemID"].ToString()!="")
						{
							modelt.FCItemID=ds2.Tables[0].Rows[n]["FCItemID"].ToString();
						}
						if(ds2.Tables[0].Rows[n]["FQty"]!=null && ds2.Tables[0].Rows[n]["FQty"].ToString()!="")
						{
							modelt.FQty=decimal.Parse(ds2.Tables[0].Rows[n]["FQty"].ToString());
						}
						if(ds2.Tables[0].Rows[n]["FSize"]!=null && ds2.Tables[0].Rows[n]["FSize"].ToString()!="")
						{
							modelt.FSize=decimal.Parse(ds2.Tables[0].Rows[n]["FSize"].ToString());
						}
						models.Add(modelt);
					}
					model.KuaidiDetails = models;
					#endregion  子表字段信息end
				}
				#endregion  子表信息end

				return model;
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.KuaiDi DataRowToModel(DataRow row)
		{
			Maticsoft.Model.KuaiDi model=new Maticsoft.Model.KuaiDi();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=row["Id"].ToString();
				}
				if(row["Memo"]!=null && row["Memo"].ToString()!="")
				{
					model.Memo=row["Memo"].ToString();
				}
				if(row["Date"]!=null && row["Date"].ToString()!="")
				{
					model.Date=DateTime.Parse(row["Date"].ToString());
				}
				if(row["Amount"]!=null && row["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(row["Amount"].ToString());
				}
				if(row["KuaidiTypeId"]!=null && row["KuaidiTypeId"].ToString()!="")
				{
					model.KuaidiTypeId=int.Parse(row["KuaidiTypeId"].ToString());
				}
				if(row["ReceiveId"]!=null && row["ReceiveId"].ToString()!="")
				{
					model.ReceiveId=int.Parse(row["ReceiveId"].ToString());
				}
				if(row["SendId"]!=null && row["SendId"].ToString()!="")
				{
					model.SendId=int.Parse(row["SendId"].ToString());
				}
				if(row["FItemId"]!=null && row["FItemId"].ToString()!="")
				{
					model.FItemId=int.Parse(row["FItemId"].ToString());
				}
				if(row["FSumSize"]!=null && row["FSumSize"].ToString()!="")
				{
					model.FSumSize=decimal.Parse(row["FSumSize"].ToString());
				}
				if(row["FSumGrossWeight"]!=null && row["FSumGrossWeight"].ToString()!="")
				{
					model.FSumGrossWeight=decimal.Parse(row["FSumGrossWeight"].ToString());
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
			strSql.Append("select Id,Memo,Date,Amount,KuaidiTypeId,ReceiveId,SendId,FItemId,FSumSize,FSumGrossWeight ");
			strSql.Append(" FROM KuaiDi ");
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
			strSql.Append(" Id,Memo,Date,Amount,KuaidiTypeId,ReceiveId,SendId,FItemId,FSumSize,FSumGrossWeight ");
			strSql.Append(" FROM KuaiDi ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbHelperSQLPWuLiu.Query(strSql.ToString());
		}


		#endregion  Method
	}
}

