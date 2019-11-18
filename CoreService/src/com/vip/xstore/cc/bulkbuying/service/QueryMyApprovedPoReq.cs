using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class QueryMyApprovedPoReq {
		
		///<summary>
		/// 0:待办;1:已办
		///</summary>
		
		private byte? dealType_;
		
		///<summary>
		/// 前台登记人OA帐号
		///</summary>
		
		private string currentUserId_;
		
		///<summary>
		/// 查询编号
		///</summary>
		
		private List<string> queryNo_;
		
		///<summary>
		/// 编号类型 0-批次号，1-采购订单号
		///</summary>
		
		private byte? queryType_;
		
		///<summary>
		/// 采购主体(xstorebuy/maxxbuy)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 发货状态， 0=未下发、1=已下发、2=占用失败、3=占用成功、4=已出仓、9=已取消
		///</summary>
		
		private byte? deliveryStatus_;
		
		///<summary>
		/// 库存属性，0=SI，1=VI
		///</summary>
		
		private byte? stockProps_;
		
		///<summary>
		/// 发货仓库
		///</summary>
		
		private string deliveryWarehouse_;
		
		///<summary>
		/// 创建开始时间
		///</summary>
		
		private System.DateTime? createTimeStart_;
		
		///<summary>
		/// 采购员
		///</summary>
		
		private string buyerId_;
		
		///<summary>
		/// 创建结束时间
		///</summary>
		
		private System.DateTime? createTimeEnd_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 采购类型
		///</summary>
		
		private byte? purchaseType_;
		
		///<summary>
		/// 分页大小
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 货品类型：0、现货 1、囤货
		///</summary>
		
		private byte? goodsType_;
		
		public byte? GetDealType(){
			return this.dealType_;
		}
		
		public void SetDealType(byte? value){
			this.dealType_ = value;
		}
		public string GetCurrentUserId(){
			return this.currentUserId_;
		}
		
		public void SetCurrentUserId(string value){
			this.currentUserId_ = value;
		}
		public List<string> GetQueryNo(){
			return this.queryNo_;
		}
		
		public void SetQueryNo(List<string> value){
			this.queryNo_ = value;
		}
		public byte? GetQueryType(){
			return this.queryType_;
		}
		
		public void SetQueryType(byte? value){
			this.queryType_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public byte? GetDeliveryStatus(){
			return this.deliveryStatus_;
		}
		
		public void SetDeliveryStatus(byte? value){
			this.deliveryStatus_ = value;
		}
		public byte? GetStockProps(){
			return this.stockProps_;
		}
		
		public void SetStockProps(byte? value){
			this.stockProps_ = value;
		}
		public string GetDeliveryWarehouse(){
			return this.deliveryWarehouse_;
		}
		
		public void SetDeliveryWarehouse(string value){
			this.deliveryWarehouse_ = value;
		}
		public System.DateTime? GetCreateTimeStart(){
			return this.createTimeStart_;
		}
		
		public void SetCreateTimeStart(System.DateTime? value){
			this.createTimeStart_ = value;
		}
		public string GetBuyerId(){
			return this.buyerId_;
		}
		
		public void SetBuyerId(string value){
			this.buyerId_ = value;
		}
		public System.DateTime? GetCreateTimeEnd(){
			return this.createTimeEnd_;
		}
		
		public void SetCreateTimeEnd(System.DateTime? value){
			this.createTimeEnd_ = value;
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
		public byte? GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(byte? value){
			this.purchaseType_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public byte? GetGoodsType(){
			return this.goodsType_;
		}
		
		public void SetGoodsType(byte? value){
			this.goodsType_ = value;
		}
		
	}
	
}