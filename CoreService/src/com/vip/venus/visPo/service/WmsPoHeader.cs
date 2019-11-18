using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class WmsPoHeader {
		
		///<summary>
		/// 采购订单号码 POH.PO_NO
		///</summary>
		
		private string po_number_;
		
		///<summary>
		/// 
		///</summary>
		
		private System.DateTime? created_time_;
		
		///<summary>
		/// 取头或者行，最后的更新时间
		///</summary>
		
		private System.DateTime? update_time_;
		
		///<summary>
		/// 供应商编码PO头表vendorcode字段
		///</summary>
		
		private string vendor_code_;
		
		///<summary>
		/// 供应商名称PO头表vendorname字段
		///</summary>
		
		private string vendor_name_;
		
		///<summary>
		/// 供应商地点1PO头表address字段
		///</summary>
		
		private string address1_;
		
		///<summary>
		/// 供应商地点2PO头表address字段
		///</summary>
		
		private string address2_;
		
		///<summary>
		/// 供应商地点3PO头表address字段
		///</summary>
		
		private string address3_;
		
		///<summary>
		/// 城市PO头表city字段
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 州PO头表state字段
		///</summary>
		
		private string state_;
		
		///<summary>
		/// 邮政编码 传空
		///</summary>
		
		private string zip_;
		
		///<summary>
		/// 电子邮件 从PO头表的email取值
		///</summary>
		
		private string email_;
		
		///<summary>
		/// 国家PO头表country字段
		///</summary>
		
		private string country_;
		
		///<summary>
		/// 联络人电话取PO头表 contacter字段
		///</summary>
		
		private string contact_telephone_;
		
		///<summary>
		/// 联络人名称取PO头表 contacter_telephone字段	
		///</summary>
		
		private string contacter_;
		
		///<summary>
		/// 采购单类型PO头表purchasetype
		///</summary>
		
		private string po_type_;
		
		///<summary>
		/// 负责采购人员PO头表buyer_name
		///</summary>
		
		private string buyer_;
		
		///<summary>
		/// 用来标识SCM传送采购订单行表的状态	枚举以下值NEW/UPDATE
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 流水号对应下个请求的maxID	一个PO编号，只对应一个流水号，从1开始。如果一个PO需要分发多次，则流水号不同。
		///</summary>
		
		private string poh_id_;
		
		///<summary>
		/// 传送行记录数取改PO的行的总数
		///</summary>
		
		private string lines_count_;
		
		///<summary>
		/// 销售区域只填写一个区域	根据PO头表的sell_area字段，再根据仓库编码的映射关系，取到WMS对应的仓库编码，特殊逻辑，请看逻辑说明
		///</summary>
		
		private string sale_area_;
		
		///<summary>
		/// PO负责人同BUYER字段
		///</summary>
		
		private string brand_admin_;
		
		///<summary>
		/// 入库仓别标识该PO应再对应仓库标识的仓库中入库，其他仓库不允许入库	本字段不存在于PO头表中，属于特殊字段，需要看特殊说明。只用在一个PO在一个仓库入库，但是别的仓库也需要获取PO的场景，3pl。
		///</summary>
		
		private string warehouse_code_;
		
		///<summary>
		/// PO负责部门标识该PO的负责部门名称	 dept改为DEPT，取自PO头表的dept字段
		///</summary>
		
		private string dept_;
		
		///<summary>
		/// 需求日期、预计大货到货日期 
		///</summary>
		
		private string need_by_date_;
		
		///<summary>
		/// 是否3PL送货 
		///</summary>
		
		private byte? is_3pl_;
		
		///<summary>
		/// 核算一级部门编码
		///</summary>
		
		private string purchase_office_1_;
		
		///<summary>
		/// 核算一级部门名称
		///</summary>
		
		private string purchase_office_1_name_;
		
		///<summary>
		/// 核算二级部门编码
		///</summary>
		
		private string purchase_office_;
		
		///<summary>
		/// 核算二级部门名称
		///</summary>
		
		private string purchase_office_name_;
		
		///<summary>
		/// 核算三级部门编码
		///</summary>
		
		private string purchase_office_divide_;
		
		///<summary>
		/// 核算三级部门编码名称
		///</summary>
		
		private string purchase_office_divide_name_;
		
		///<summary>
		/// 采购区域编码
		///</summary>
		
		private string purchase_area_;
		
		///<summary>
		/// 采购区域名称
		///</summary>
		
		private string purchase_area_name_;
		
		///<summary>
		/// 是否虚拟仓收货
		///</summary>
		
		private string isVWarehouse_;
		
		///<summary>
		/// 是否一般贸易
		///</summary>
		
		private string generalTrade_;
		
		///<summary>
		/// 采购子公司
		///</summary>
		
		private string purchaseCompany_;
		
		///<summary>
		/// 采购子公司编码
		///</summary>
		
		private string purchaseCompanyCode_;
		
		///<summary>
		/// 创建人id
		///</summary>
		
		private string createUser_;
		
		///<summary>
		/// 销售网站
		///</summary>
		
		private string sales_site_;
		
		///<summary>
		/// 囤货标识(RELEASE : 释放囤货    STOREGOODS : 囤货)
		///</summary>
		
		private string store_goods_status_;
		
		///<summary>
		/// 预计销售时间
		///</summary>
		
		private System.DateTime? expect_sales_time_;
		
		///<summary>
		/// PO归属(BUSINESS_PURCHASE 商务采买  GROUP_PURCHASE 集团采买)
		///</summary>
		
		private com.vip.venus.po.service.Owner? owner_;
		
		///<summary>
		/// PO分货渠道编码
		///</summary>
		
		private string assignChannelCode_;
		
		///<summary>
		/// 币种
		///</summary>
		
		private string currency_;
		
		///<summary>
		/// 商品残次等级：0:良品 1:一残 2:二残 3:三残
		///</summary>
		
		private int? defectiveGrade_;
		
		public string GetPo_number(){
			return this.po_number_;
		}
		
		public void SetPo_number(string value){
			this.po_number_ = value;
		}
		public System.DateTime? GetCreated_time(){
			return this.created_time_;
		}
		
		public void SetCreated_time(System.DateTime? value){
			this.created_time_ = value;
		}
		public System.DateTime? GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(System.DateTime? value){
			this.update_time_ = value;
		}
		public string GetVendor_code(){
			return this.vendor_code_;
		}
		
		public void SetVendor_code(string value){
			this.vendor_code_ = value;
		}
		public string GetVendor_name(){
			return this.vendor_name_;
		}
		
		public void SetVendor_name(string value){
			this.vendor_name_ = value;
		}
		public string GetAddress1(){
			return this.address1_;
		}
		
		public void SetAddress1(string value){
			this.address1_ = value;
		}
		public string GetAddress2(){
			return this.address2_;
		}
		
		public void SetAddress2(string value){
			this.address2_ = value;
		}
		public string GetAddress3(){
			return this.address3_;
		}
		
		public void SetAddress3(string value){
			this.address3_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetState(){
			return this.state_;
		}
		
		public void SetState(string value){
			this.state_ = value;
		}
		public string GetZip(){
			return this.zip_;
		}
		
		public void SetZip(string value){
			this.zip_ = value;
		}
		public string GetEmail(){
			return this.email_;
		}
		
		public void SetEmail(string value){
			this.email_ = value;
		}
		public string GetCountry(){
			return this.country_;
		}
		
		public void SetCountry(string value){
			this.country_ = value;
		}
		public string GetContact_telephone(){
			return this.contact_telephone_;
		}
		
		public void SetContact_telephone(string value){
			this.contact_telephone_ = value;
		}
		public string GetContacter(){
			return this.contacter_;
		}
		
		public void SetContacter(string value){
			this.contacter_ = value;
		}
		public string GetPo_type(){
			return this.po_type_;
		}
		
		public void SetPo_type(string value){
			this.po_type_ = value;
		}
		public string GetBuyer(){
			return this.buyer_;
		}
		
		public void SetBuyer(string value){
			this.buyer_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetPoh_id(){
			return this.poh_id_;
		}
		
		public void SetPoh_id(string value){
			this.poh_id_ = value;
		}
		public string GetLines_count(){
			return this.lines_count_;
		}
		
		public void SetLines_count(string value){
			this.lines_count_ = value;
		}
		public string GetSale_area(){
			return this.sale_area_;
		}
		
		public void SetSale_area(string value){
			this.sale_area_ = value;
		}
		public string GetBrand_admin(){
			return this.brand_admin_;
		}
		
		public void SetBrand_admin(string value){
			this.brand_admin_ = value;
		}
		public string GetWarehouse_code(){
			return this.warehouse_code_;
		}
		
		public void SetWarehouse_code(string value){
			this.warehouse_code_ = value;
		}
		public string GetDept(){
			return this.dept_;
		}
		
		public void SetDept(string value){
			this.dept_ = value;
		}
		public string GetNeed_by_date(){
			return this.need_by_date_;
		}
		
		public void SetNeed_by_date(string value){
			this.need_by_date_ = value;
		}
		public byte? GetIs_3pl(){
			return this.is_3pl_;
		}
		
		public void SetIs_3pl(byte? value){
			this.is_3pl_ = value;
		}
		public string GetPurchase_office_1(){
			return this.purchase_office_1_;
		}
		
		public void SetPurchase_office_1(string value){
			this.purchase_office_1_ = value;
		}
		public string GetPurchase_office_1_name(){
			return this.purchase_office_1_name_;
		}
		
		public void SetPurchase_office_1_name(string value){
			this.purchase_office_1_name_ = value;
		}
		public string GetPurchase_office(){
			return this.purchase_office_;
		}
		
		public void SetPurchase_office(string value){
			this.purchase_office_ = value;
		}
		public string GetPurchase_office_name(){
			return this.purchase_office_name_;
		}
		
		public void SetPurchase_office_name(string value){
			this.purchase_office_name_ = value;
		}
		public string GetPurchase_office_divide(){
			return this.purchase_office_divide_;
		}
		
		public void SetPurchase_office_divide(string value){
			this.purchase_office_divide_ = value;
		}
		public string GetPurchase_office_divide_name(){
			return this.purchase_office_divide_name_;
		}
		
		public void SetPurchase_office_divide_name(string value){
			this.purchase_office_divide_name_ = value;
		}
		public string GetPurchase_area(){
			return this.purchase_area_;
		}
		
		public void SetPurchase_area(string value){
			this.purchase_area_ = value;
		}
		public string GetPurchase_area_name(){
			return this.purchase_area_name_;
		}
		
		public void SetPurchase_area_name(string value){
			this.purchase_area_name_ = value;
		}
		public string GetIsVWarehouse(){
			return this.isVWarehouse_;
		}
		
		public void SetIsVWarehouse(string value){
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
		public string GetCreateUser(){
			return this.createUser_;
		}
		
		public void SetCreateUser(string value){
			this.createUser_ = value;
		}
		public string GetSales_site(){
			return this.sales_site_;
		}
		
		public void SetSales_site(string value){
			this.sales_site_ = value;
		}
		public string GetStore_goods_status(){
			return this.store_goods_status_;
		}
		
		public void SetStore_goods_status(string value){
			this.store_goods_status_ = value;
		}
		public System.DateTime? GetExpect_sales_time(){
			return this.expect_sales_time_;
		}
		
		public void SetExpect_sales_time(System.DateTime? value){
			this.expect_sales_time_ = value;
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
		public string GetCurrency(){
			return this.currency_;
		}
		
		public void SetCurrency(string value){
			this.currency_ = value;
		}
		public int? GetDefectiveGrade(){
			return this.defectiveGrade_;
		}
		
		public void SetDefectiveGrade(int? value){
			this.defectiveGrade_ = value;
		}
		
	}
	
}