using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class OdsOrderMessageDetail {
		
		///<summary>
		/// 订购数量/赠品数量，订单明细的amount不能为空。
		///</summary>
		
		private long? amount_;
		
		///<summary>
		/// 品牌外文名称
		///</summary>
		
		private string brandForeignName_;
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 商品等级
		///</summary>
		
		private string brandType_;
		
		///<summary>
		/// 商品前置名
		///</summary>
		
		private string foreWord_;
		
		///<summary>
		/// 商品外文名称
		///</summary>
		
		private string foreignName_;
		
		///<summary>
		/// 商品行小计
		///</summary>
		
		private double? goodsLineMoney_;
		
		///<summary>
		/// 商品图片的链接地址
		///</summary>
		
		private string goodsPic_;
		
		///<summary>
		/// 单品毛重，TMS匹配承运商时使用，单位：kg
		///</summary>
		
		private double? grossWeight_;
		
		///<summary>
		/// 明细流水号
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 是否是礼品
		///</summary>
		
		private string isGift_;
		
		///<summary>
		/// 专场标识，0-普通专场，1-VI夜场，2-品购...
		///</summary>
		
		private int? isVip_;
		
		///<summary>
		/// 商品描述
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 该档期需要绑定PO
		///</summary>
		
		private int? noPo_;
		
		///<summary>
		/// 对应的订单流水号
		///</summary>
		
		private string orderId_;
		
		///<summary>
		/// 订单号码
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		///  PO号-商品对应的档期（采购单号）
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 单价，赠品：单价为0。
		///</summary>
		
		private double? price_;
		
		///<summary>
		/// 商品尺码
		///</summary>
		
		private string size_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string sizeSn_;
		
		///<summary>
		/// 单位
		///</summary>
		
		private string unit_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 供应商名称，例如，东莞市丽元堂化妆品有限公司。
		///</summary>
		
		private string vendorName_;
		
		///<summary>
		/// 条码对应的仓库，
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 区域小仓编码
		///</summary>
		
		private string receivingWarehouse_;
		
		///<summary>
		///</summary>
		
		private string hsCode_;
		
		///<summary>
		///</summary>
		
		private double? finalPrice_;
		
		///<summary>
		///</summary>
		
		private string productsCustomCnName_;
		
		///<summary>
		///</summary>
		
		private string productsCustomEnName_;
		
		///<summary>
		///</summary>
		
		private string noGoodCatagory_;
		
		public long? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(long? value){
			this.amount_ = value;
		}
		public string GetBrandForeignName(){
			return this.brandForeignName_;
		}
		
		public void SetBrandForeignName(string value){
			this.brandForeignName_ = value;
		}
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandType(){
			return this.brandType_;
		}
		
		public void SetBrandType(string value){
			this.brandType_ = value;
		}
		public string GetForeWord(){
			return this.foreWord_;
		}
		
		public void SetForeWord(string value){
			this.foreWord_ = value;
		}
		public string GetForeignName(){
			return this.foreignName_;
		}
		
		public void SetForeignName(string value){
			this.foreignName_ = value;
		}
		public double? GetGoodsLineMoney(){
			return this.goodsLineMoney_;
		}
		
		public void SetGoodsLineMoney(double? value){
			this.goodsLineMoney_ = value;
		}
		public string GetGoodsPic(){
			return this.goodsPic_;
		}
		
		public void SetGoodsPic(string value){
			this.goodsPic_ = value;
		}
		public double? GetGrossWeight(){
			return this.grossWeight_;
		}
		
		public void SetGrossWeight(double? value){
			this.grossWeight_ = value;
		}
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetIsGift(){
			return this.isGift_;
		}
		
		public void SetIsGift(string value){
			this.isGift_ = value;
		}
		public int? GetIsVip(){
			return this.isVip_;
		}
		
		public void SetIsVip(int? value){
			this.isVip_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public int? GetNoPo(){
			return this.noPo_;
		}
		
		public void SetNoPo(int? value){
			this.noPo_ = value;
		}
		public string GetOrderId(){
			return this.orderId_;
		}
		
		public void SetOrderId(string value){
			this.orderId_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public double? GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(double? value){
			this.price_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public string GetSizeSn(){
			return this.sizeSn_;
		}
		
		public void SetSizeSn(string value){
			this.sizeSn_ = value;
		}
		public string GetUnit(){
			return this.unit_;
		}
		
		public void SetUnit(string value){
			this.unit_ = value;
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
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetReceivingWarehouse(){
			return this.receivingWarehouse_;
		}
		
		public void SetReceivingWarehouse(string value){
			this.receivingWarehouse_ = value;
		}
		public string GetHsCode(){
			return this.hsCode_;
		}
		
		public void SetHsCode(string value){
			this.hsCode_ = value;
		}
		public double? GetFinalPrice(){
			return this.finalPrice_;
		}
		
		public void SetFinalPrice(double? value){
			this.finalPrice_ = value;
		}
		public string GetProductsCustomCnName(){
			return this.productsCustomCnName_;
		}
		
		public void SetProductsCustomCnName(string value){
			this.productsCustomCnName_ = value;
		}
		public string GetProductsCustomEnName(){
			return this.productsCustomEnName_;
		}
		
		public void SetProductsCustomEnName(string value){
			this.productsCustomEnName_ = value;
		}
		public string GetNoGoodCatagory(){
			return this.noGoodCatagory_;
		}
		
		public void SetNoGoodCatagory(string value){
			this.noGoodCatagory_ = value;
		}
		
	}
	
}