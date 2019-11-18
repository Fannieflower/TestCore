using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class InvTransDetail {
		
		///<summary>
		/// 事务日期
		///</summary>
		
		private System.DateTime? transactionDate_;
		
		///<summary>
		/// 业务发生期间
		///</summary>
		
		private string periodName_;
		
		///<summary>
		/// 事务类型
		///</summary>
		
		private string transactionTypeCommand_;
		
		///<summary>
		/// 事务类型指令名称
		///</summary>
		
		private string transactionTypeName_;
		
		///<summary>
		/// 全局唯一
		///</summary>
		
		private long? globalId_;
		
		///<summary>
		/// 收退货类型
		///</summary>
		
		private string lineType_;
		
		///<summary>
		/// 供应商编号
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 业务主体编码
		///</summary>
		
		private string orgId_;
		
		///<summary>
		/// 业务主体
		///</summary>
		
		private string orgName_;
		
		///<summary>
		/// PO
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// 条码,SKU
		///</summary>
		
		private string itemNo_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string itemDesc_;
		
		///<summary>
		/// 货号
		///</summary>
		
		private string goodsNo_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private double? quantity_;
		
		///<summary>
		/// 参考文档号
		///</summary>
		
		private string doc_;
		
		///<summary>
		/// 退供参考号
		///</summary>
		
		private string returnReqNo_;
		
		///<summary>
		/// 销售模式
		///</summary>
		
		private string sellingMode_;
		
		///<summary>
		/// 仓库
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandCode_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 一级分类
		///</summary>
		
		private string category1_;
		
		///<summary>
		/// 二级分类
		///</summary>
		
		private string category2_;
		
		///<summary>
		/// 三级分类
		///</summary>
		
		private string category3_;
		
		///<summary>
		/// 原PO
		///</summary>
		
		private string parentPoNo_;
		
		///<summary>
		/// 库存属性
		///</summary>
		
		private string whType_;
		
		///<summary>
		/// 数据生成时间
		///</summary>
		
		private string dataGenTime_;
		
		public System.DateTime? GetTransactionDate(){
			return this.transactionDate_;
		}
		
		public void SetTransactionDate(System.DateTime? value){
			this.transactionDate_ = value;
		}
		public string GetPeriodName(){
			return this.periodName_;
		}
		
		public void SetPeriodName(string value){
			this.periodName_ = value;
		}
		public string GetTransactionTypeCommand(){
			return this.transactionTypeCommand_;
		}
		
		public void SetTransactionTypeCommand(string value){
			this.transactionTypeCommand_ = value;
		}
		public string GetTransactionTypeName(){
			return this.transactionTypeName_;
		}
		
		public void SetTransactionTypeName(string value){
			this.transactionTypeName_ = value;
		}
		public long? GetGlobalId(){
			return this.globalId_;
		}
		
		public void SetGlobalId(long? value){
			this.globalId_ = value;
		}
		public string GetLineType(){
			return this.lineType_;
		}
		
		public void SetLineType(string value){
			this.lineType_ = value;
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
		public string GetOrgId(){
			return this.orgId_;
		}
		
		public void SetOrgId(string value){
			this.orgId_ = value;
		}
		public string GetOrgName(){
			return this.orgName_;
		}
		
		public void SetOrgName(string value){
			this.orgName_ = value;
		}
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public string GetItemNo(){
			return this.itemNo_;
		}
		
		public void SetItemNo(string value){
			this.itemNo_ = value;
		}
		public string GetItemDesc(){
			return this.itemDesc_;
		}
		
		public void SetItemDesc(string value){
			this.itemDesc_ = value;
		}
		public string GetGoodsNo(){
			return this.goodsNo_;
		}
		
		public void SetGoodsNo(string value){
			this.goodsNo_ = value;
		}
		public double? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(double? value){
			this.quantity_ = value;
		}
		public string GetDoc(){
			return this.doc_;
		}
		
		public void SetDoc(string value){
			this.doc_ = value;
		}
		public string GetReturnReqNo(){
			return this.returnReqNo_;
		}
		
		public void SetReturnReqNo(string value){
			this.returnReqNo_ = value;
		}
		public string GetSellingMode(){
			return this.sellingMode_;
		}
		
		public void SetSellingMode(string value){
			this.sellingMode_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetBrandCode(){
			return this.brandCode_;
		}
		
		public void SetBrandCode(string value){
			this.brandCode_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetCategory1(){
			return this.category1_;
		}
		
		public void SetCategory1(string value){
			this.category1_ = value;
		}
		public string GetCategory2(){
			return this.category2_;
		}
		
		public void SetCategory2(string value){
			this.category2_ = value;
		}
		public string GetCategory3(){
			return this.category3_;
		}
		
		public void SetCategory3(string value){
			this.category3_ = value;
		}
		public string GetParentPoNo(){
			return this.parentPoNo_;
		}
		
		public void SetParentPoNo(string value){
			this.parentPoNo_ = value;
		}
		public string GetWhType(){
			return this.whType_;
		}
		
		public void SetWhType(string value){
			this.whType_ = value;
		}
		public string GetDataGenTime(){
			return this.dataGenTime_;
		}
		
		public void SetDataGenTime(string value){
			this.dataGenTime_ = value;
		}
		
	}
	
}