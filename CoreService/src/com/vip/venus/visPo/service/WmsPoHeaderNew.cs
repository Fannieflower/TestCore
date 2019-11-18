using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class WmsPoHeaderNew {
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// po采购单号
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private System.DateTime? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private System.DateTime? updateTime_;
		
		///<summary>
		/// 供应商编号
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 供应商地点
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 城市
		///</summary>
		
		private string city_;
		
		///<summary>
		/// vis称省 wms称州
		///</summary>
		
		private string province_;
		
		///<summary>
		/// 国家
		///</summary>
		
		private string country_;
		
		///<summary>
		/// 联络人电话
		///</summary>
		
		private string contacterTelephone_;
		
		///<summary>
		/// 联络人名称
		///</summary>
		
		private string contacter_;
		
		///<summary>
		/// 邮箱地址
		///</summary>
		
		private string email_;
		
		///<summary>
		/// vis称合作模式 wms称采购单类型
		///</summary>
		
		private string purchaseTypeName_;
		
		///<summary>
		/// 负责采购人员
		///</summary>
		
		private string buyerName_;
		
		///<summary>
		/// 状态：po新增/po取消 1新增/0取消
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 销售区域
		///</summary>
		
		private string sellArea_;
		
		///<summary>
		/// vis称采购员工号 wms称PO负责人
		///</summary>
		
		private string buyerBy_;
		
		///<summary>
		/// 入库仓别
		///</summary>
		
		private string wareHouseCode_;
		
		///<summary>
		/// PO负责部门
		///</summary>
		
		private string dept_;
		
		///<summary>
		/// vis称需求日期 wms称预计到达时间
		///</summary>
		
		private string needByDate_;
		
		///<summary>
		/// 是否为外部3pl模式：1是/0否
		///</summary>
		
		private byte? is3pl_;
		
		///<summary>
		/// 核算一级部门编码
		///</summary>
		
		private string purchaseOffice1_;
		
		///<summary>
		/// 核算一级部门名称
		///</summary>
		
		private string purchaseOffice1Name_;
		
		///<summary>
		/// 核算二级部门编码
		///</summary>
		
		private string purchaseOffice_;
		
		///<summary>
		/// 核算二级部门名称
		///</summary>
		
		private string purchaseOfficeName_;
		
		///<summary>
		/// 核算三级部门编码
		///</summary>
		
		private string purchaseOfficeDivide_;
		
		///<summary>
		/// 核算三级部门名称
		///</summary>
		
		private string purchaseOfficeDivideName_;
		
		///<summary>
		/// 采购区域编码
		///</summary>
		
		private string purchaseArea_;
		
		///<summary>
		/// 采购区域名称
		///</summary>
		
		private string purchaseAreaName_;
		
		///<summary>
		/// 是否虚拟收货 0不是，1是
		///</summary>
		
		private int? isVWarehouse_;
		
		///<summary>
		/// 是否一般贸易 N不是，Y是
		///</summary>
		
		private string generalTrade_;
		
		///<summary>
		/// 采购公司名称 (通用wms需要)
		///</summary>
		
		private string purchaseCompany_;
		
		///<summary>
		/// 采购公司编码 (通用wms需要)
		///</summary>
		
		private string purchaseCompanyCode_;
		
		///<summary>
		/// 创建人工号 (通用wms需要)
		///</summary>
		
		private string createUserId_;
		
		///<summary>
		/// PO归属(BUSINESS_PURCHASE 商务采买  GROUP_PURCHASE 集团采买)
		///</summary>
		
		private com.vip.venus.po.service.Owner? owner_;
		
		///<summary>
		/// PO分货渠道编码
		///</summary>
		
		private string assignChannelCode_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public System.DateTime? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(System.DateTime? value){
			this.createTime_ = value;
		}
		public System.DateTime? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(System.DateTime? value){
			this.updateTime_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetVendorName(){
			return this.vendorName_;
		}
		
		public void SetVendorName(string value){
			this.vendorName_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetProvince(){
			return this.province_;
		}
		
		public void SetProvince(string value){
			this.province_ = value;
		}
		public string GetCountry(){
			return this.country_;
		}
		
		public void SetCountry(string value){
			this.country_ = value;
		}
		public string GetContacterTelephone(){
			return this.contacterTelephone_;
		}
		
		public void SetContacterTelephone(string value){
			this.contacterTelephone_ = value;
		}
		public string GetContacter(){
			return this.contacter_;
		}
		
		public void SetContacter(string value){
			this.contacter_ = value;
		}
		public string GetEmail(){
			return this.email_;
		}
		
		public void SetEmail(string value){
			this.email_ = value;
		}
		public string GetPurchaseTypeName(){
			return this.purchaseTypeName_;
		}
		
		public void SetPurchaseTypeName(string value){
			this.purchaseTypeName_ = value;
		}
		public string GetBuyerName(){
			return this.buyerName_;
		}
		
		public void SetBuyerName(string value){
			this.buyerName_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		public string GetBuyerBy(){
			return this.buyerBy_;
		}
		
		public void SetBuyerBy(string value){
			this.buyerBy_ = value;
		}
		public string GetWareHouseCode(){
			return this.wareHouseCode_;
		}
		
		public void SetWareHouseCode(string value){
			this.wareHouseCode_ = value;
		}
		public string GetDept(){
			return this.dept_;
		}
		
		public void SetDept(string value){
			this.dept_ = value;
		}
		public string GetNeedByDate(){
			return this.needByDate_;
		}
		
		public void SetNeedByDate(string value){
			this.needByDate_ = value;
		}
		public byte? GetIs3pl(){
			return this.is3pl_;
		}
		
		public void SetIs3pl(byte? value){
			this.is3pl_ = value;
		}
		public string GetPurchaseOffice1(){
			return this.purchaseOffice1_;
		}
		
		public void SetPurchaseOffice1(string value){
			this.purchaseOffice1_ = value;
		}
		public string GetPurchaseOffice1Name(){
			return this.purchaseOffice1Name_;
		}
		
		public void SetPurchaseOffice1Name(string value){
			this.purchaseOffice1Name_ = value;
		}
		public string GetPurchaseOffice(){
			return this.purchaseOffice_;
		}
		
		public void SetPurchaseOffice(string value){
			this.purchaseOffice_ = value;
		}
		public string GetPurchaseOfficeName(){
			return this.purchaseOfficeName_;
		}
		
		public void SetPurchaseOfficeName(string value){
			this.purchaseOfficeName_ = value;
		}
		public string GetPurchaseOfficeDivide(){
			return this.purchaseOfficeDivide_;
		}
		
		public void SetPurchaseOfficeDivide(string value){
			this.purchaseOfficeDivide_ = value;
		}
		public string GetPurchaseOfficeDivideName(){
			return this.purchaseOfficeDivideName_;
		}
		
		public void SetPurchaseOfficeDivideName(string value){
			this.purchaseOfficeDivideName_ = value;
		}
		public string GetPurchaseArea(){
			return this.purchaseArea_;
		}
		
		public void SetPurchaseArea(string value){
			this.purchaseArea_ = value;
		}
		public string GetPurchaseAreaName(){
			return this.purchaseAreaName_;
		}
		
		public void SetPurchaseAreaName(string value){
			this.purchaseAreaName_ = value;
		}
		public int? GetIsVWarehouse(){
			return this.isVWarehouse_;
		}
		
		public void SetIsVWarehouse(int? value){
			this.isVWarehouse_ = value;
		}
		public string GetGeneralTrade(){
			return this.generalTrade_;
		}
		
		public void SetGeneralTrade(string value){
			this.generalTrade_ = value;
		}
		public string GetPurchaseCompany(){
			return this.purchaseCompany_;
		}
		
		public void SetPurchaseCompany(string value){
			this.purchaseCompany_ = value;
		}
		public string GetPurchaseCompanyCode(){
			return this.purchaseCompanyCode_;
		}
		
		public void SetPurchaseCompanyCode(string value){
			this.purchaseCompanyCode_ = value;
		}
		public string GetCreateUserId(){
			return this.createUserId_;
		}
		
		public void SetCreateUserId(string value){
			this.createUserId_ = value;
		}
		public com.vip.venus.po.service.Owner? GetOwner(){
			return this.owner_;
		}
		
		public void SetOwner(com.vip.venus.po.service.Owner? value){
			this.owner_ = value;
		}
		public string GetAssignChannelCode(){
			return this.assignChannelCode_;
		}
		
		public void SetAssignChannelCode(string value){
			this.assignChannelCode_ = value;
		}
		
	}
	
}