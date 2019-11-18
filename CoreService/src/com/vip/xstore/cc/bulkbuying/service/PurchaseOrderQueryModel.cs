using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderQueryModel {
		
		///<summary>
		/// 查询编号
		///</summary>
		
		private List<string> queryNo_;
		
		///<summary>
		/// 编号类型 0-批次号，1-采购订单号
		///</summary>
		
		private long? queryType_;
		
		///<summary>
		/// 采购主体(xstorebuy/maxxbuy)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 可见范围(0-我可见的部门，1-我创建的)
		///</summary>
		
		private long? visibility_;
		
		///<summary>
		/// 审核状态，0=草稿，1=待审批，2=审批通过，3=已驳回
		///</summary>
		
		private byte? approvalStatus_;
		
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
		/// 分页大小
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
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
		
		private string purchaseType_;
		
		///<summary>
		/// 当前审核节点的权限编码
		///</summary>
		
		private string approvalRole_;
		
		///<summary>
		/// 条码类型:0-商品条码,1-商品原条码
		///</summary>
		
		private byte? barcodeType_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private List<string> barcodes_;
		
		///<summary>
		/// 货品类型
		///</summary>
		
		private byte? goodsType_;
		
		///<summary>
		/// 订单来源
		///</summary>
		
		private string source_;
		
		///<summary>
		/// 合作模式
		///</summary>
		
		private byte? cooperationMode_;
		
		///<summary>
		/// 货品渠道
		///</summary>
		
		private string goodsChannel_;
		
		///<summary>
		/// 收货类型
		///</summary>
		
		private byte? receivingType_;
		
		///<summary>
		/// 收货仓库/门店编码
		///</summary>
		
		private string receiveWarehouseCode_;
		
		///<summary>
		/// 结算模式(1:供货价;2:扣点)
		///</summary>
		
		private byte? settlementMode_;
		
		public List<string> GetQueryNo(){
			return this.queryNo_;
		}
		
		public void SetQueryNo(List<string> value){
			this.queryNo_ = value;
		}
		public long? GetQueryType(){
			return this.queryType_;
		}
		
		public void SetQueryType(long? value){
			this.queryType_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public long? GetVisibility(){
			return this.visibility_;
		}
		
		public void SetVisibility(long? value){
			this.visibility_ = value;
		}
		public byte? GetApprovalStatus(){
			return this.approvalStatus_;
		}
		
		public void SetApprovalStatus(byte? value){
			this.approvalStatus_ = value;
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
		public string GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(string value){
			this.purchaseType_ = value;
		}
		public string GetApprovalRole(){
			return this.approvalRole_;
		}
		
		public void SetApprovalRole(string value){
			this.approvalRole_ = value;
		}
		public byte? GetBarcodeType(){
			return this.barcodeType_;
		}
		
		public void SetBarcodeType(byte? value){
			this.barcodeType_ = value;
		}
		public List<string> GetBarcodes(){
			return this.barcodes_;
		}
		
		public void SetBarcodes(List<string> value){
			this.barcodes_ = value;
		}
		public byte? GetGoodsType(){
			return this.goodsType_;
		}
		
		public void SetGoodsType(byte? value){
			this.goodsType_ = value;
		}
		public string GetSource(){
			return this.source_;
		}
		
		public void SetSource(string value){
			this.source_ = value;
		}
		public byte? GetCooperationMode(){
			return this.cooperationMode_;
		}
		
		public void SetCooperationMode(byte? value){
			this.cooperationMode_ = value;
		}
		public string GetGoodsChannel(){
			return this.goodsChannel_;
		}
		
		public void SetGoodsChannel(string value){
			this.goodsChannel_ = value;
		}
		public byte? GetReceivingType(){
			return this.receivingType_;
		}
		
		public void SetReceivingType(byte? value){
			this.receivingType_ = value;
		}
		public string GetReceiveWarehouseCode(){
			return this.receiveWarehouseCode_;
		}
		
		public void SetReceiveWarehouseCode(string value){
			this.receiveWarehouseCode_ = value;
		}
		public byte? GetSettlementMode(){
			return this.settlementMode_;
		}
		
		public void SetSettlementMode(byte? value){
			this.settlementMode_ = value;
		}
		
	}
	
}