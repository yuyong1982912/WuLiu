<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.KuaidiDetail.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FKuaiDiId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFKuaiDiId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FItemID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFItemID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FInterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFInterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FOrderInterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFOrderInterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FCItemID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFCItemID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FQty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFQty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FGrossWeight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFGrossWeight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FSSize
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFSSize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FSGrossWeight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFSGrossWeight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FMemo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFMemo" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




