using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vipapis.productsale.service{
	
	
	
	
	
	public class ProductSaleInfo {
		
		///<summary>
		/// 明细ID（出入库记录唯一ID）
		///</summary>
		
		private long? globalId_;
		
		///<summary>
		/// 业务实体
		///</summary>
		
		private string poOuName_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 品牌代码
		///</summary>
		
		private string brandCode_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 订单编号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 下单时间,格式yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string addTime_;
		
		///<summary>
		/// 出入库时间,单位毫秒
		///</summary>
		
		private long? issueDate_;
		
		///<summary>
		/// 状态，ISSUE表示销售，RMA表示客退
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 币种
		///</summary>
		
		private string currencyCode_;
		
		///<summary>
		/// 商品单价
		///</summary>
		
		private double? sellingPrice_;
		
		///<summary>
		/// 发货数量,1代表卖了一个，-1代表退货一个
		///</summary>
		
		private double? issueQuantity_;
		
		///<summary>
		/// 商品条形码
		///</summary>
		
		private string itemNo_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string itemDesc_;
		
		///<summary>
		/// 订单金额
		///</summary>
		
		private double? orderAmount_;
		
		///<summary>
		/// 满减优惠金额
		///</summary>
		
		private double? moneyOver_;
		
		///<summary>
		/// 满减优惠力度
		///</summary>
		
		private string moneyDiscountLevel_;
		
		///<summary>
		/// 品牌红包优惠金额
		///</summary>
		
		private double? brandCut_;
		
		///<summary>
		/// 品牌红包优惠力度
		///</summary>
		
		private string brandDiscountLevel_;
		
		///<summary>
		/// 直降金额
		///</summary>
		
		private double? zjAmount_;
		
		///<summary>
		/// 市场价
		///</summary>
		
		private double? marketPrice_;
		
		///<summary>
		/// 国家
		///</summary>
		
		private string country_;
		
		///<summary>
		/// 省份
		///</summary>
		
		private string province_;
		
		///<summary>
		/// 城市
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 仓库
		///</summary>
		
		private string warehouseName_;
		
		///<summary>
		/// 序列号
		///</summary>
		
		private string serialNo_;
		
		///<summary>
		/// 实收金额,指唯品会实际收到的金额
		///</summary>
		
		private double? goodsActureAmt_;
		
		///<summary>
		/// 行号,如果销售了多件商品，则按照拆分为多行，顺序编号
		///</summary>
		
		private int? rn_;
		
		///<summary>
		/// 创建时间,单位毫秒
		///</summary>
		
		private long? createTime_;
		
		public long? GetGlobalId(){
			return this.globalId_;
		}
		
		public void SetGlobalId(long? value){
			this.globalId_ = value;
		}
		public string GetPoOuName(){
			return this.poOuName_;
		}
		
		public void SetPoOuName(string value){
			this.poOuName_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
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
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetAddTime(){
			return this.addTime_;
		}
		
		public void SetAddTime(string value){
			this.addTime_ = value;
		}
		public long? GetIssueDate(){
			return this.issueDate_;
		}
		
		public void SetIssueDate(long? value){
			this.issueDate_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetCurrencyCode(){
			return this.currencyCode_;
		}
		
		public void SetCurrencyCode(string value){
			this.currencyCode_ = value;
		}
		public double? GetSellingPrice(){
			return this.sellingPrice_;
		}
		
		public void SetSellingPrice(double? value){
			this.sellingPrice_ = value;
		}
		public double? GetIssueQuantity(){
			return this.issueQuantity_;
		}
		
		public void SetIssueQuantity(double? value){
			this.issueQuantity_ = value;
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
		public double? GetOrderAmount(){
			return this.orderAmount_;
		}
		
		public void SetOrderAmount(double? value){
			this.orderAmount_ = value;
		}
		public double? GetMoneyOver(){
			return this.moneyOver_;
		}
		
		public void SetMoneyOver(double? value){
			this.moneyOver_ = value;
		}
		public string GetMoneyDiscountLevel(){
			return this.moneyDiscountLevel_;
		}
		
		public void SetMoneyDiscountLevel(string value){
			this.moneyDiscountLevel_ = value;
		}
		public double? GetBrandCut(){
			return this.brandCut_;
		}
		
		public void SetBrandCut(double? value){
			this.brandCut_ = value;
		}
		public string GetBrandDiscountLevel(){
			return this.brandDiscountLevel_;
		}
		
		public void SetBrandDiscountLevel(string value){
			this.brandDiscountLevel_ = value;
		}
		public double? GetZjAmount(){
			return this.zjAmount_;
		}
		
		public void SetZjAmount(double? value){
			this.zjAmount_ = value;
		}
		public double? GetMarketPrice(){
			return this.marketPrice_;
		}
		
		public void SetMarketPrice(double? value){
			this.marketPrice_ = value;
		}
		public string GetCountry(){
			return this.country_;
		}
		
		public void SetCountry(string value){
			this.country_ = value;
		}
		public string GetProvince(){
			return this.province_;
		}
		
		public void SetProvince(string value){
			this.province_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetWarehouseName(){
			return this.warehouseName_;
		}
		
		public void SetWarehouseName(string value){
			this.warehouseName_ = value;
		}
		public string GetSerialNo(){
			return this.serialNo_;
		}
		
		public void SetSerialNo(string value){
			this.serialNo_ = value;
		}
		public double? GetGoodsActureAmt(){
			return this.goodsActureAmt_;
		}
		
		public void SetGoodsActureAmt(double? value){
			this.goodsActureAmt_ = value;
		}
		public int? GetRn(){
			return this.rn_;
		}
		
		public void SetRn(int? value){
			this.rn_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		
	}
	
}