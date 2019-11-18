using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderDetail {
		
		///<summary>
		/// skuId
		///</summary>
		
		private long? skuId_;
		
		///<summary>
		/// spuId
		///</summary>
		
		private long? spuId_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private string productName_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 价格
		///</summary>
		
		private double? price_;
		
		///<summary>
		/// 状态
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 图片地址
		///</summary>
		
		private string imageUrl_;
		
		///<summary>
		/// 款号
		///</summary>
		
		private string sn_;
		
		///<summary>
		/// 尺寸
		///</summary>
		
		private string size_;
		
		///<summary>
		/// 类别
		///</summary>
		
		private string categoryName_;
		
		///<summary>
		/// 颜色
		///</summary>
		
		private string color_;
		
		///<summary>
		/// 颜色码
		///</summary>
		
		private string colorCode_;
		
		///<summary>
		/// spu
		///</summary>
		
		private string spu_;
		
		///<summary>
		/// 剩余未装箱数
		///</summary>
		
		private int? leavingUnboxQuantity_;
		
		///<summary>
		/// 未装箱数
		///</summary>
		
		private int? unboxQuantity_;
		
		///<summary>
		/// 优惠价格
		///</summary>
		
		private double? discountPrice_;
		
		///<summary>
		/// 所属子订单号
		///</summary>
		
		private string subOrderSn_;
		
		public long? GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(long? value){
			this.skuId_ = value;
		}
		public long? GetSpuId(){
			return this.spuId_;
		}
		
		public void SetSpuId(long? value){
			this.spuId_ = value;
		}
		public string GetProductName(){
			return this.productName_;
		}
		
		public void SetProductName(string value){
			this.productName_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public double? GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(double? value){
			this.price_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetImageUrl(){
			return this.imageUrl_;
		}
		
		public void SetImageUrl(string value){
			this.imageUrl_ = value;
		}
		public string GetSn(){
			return this.sn_;
		}
		
		public void SetSn(string value){
			this.sn_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public string GetCategoryName(){
			return this.categoryName_;
		}
		
		public void SetCategoryName(string value){
			this.categoryName_ = value;
		}
		public string GetColor(){
			return this.color_;
		}
		
		public void SetColor(string value){
			this.color_ = value;
		}
		public string GetColorCode(){
			return this.colorCode_;
		}
		
		public void SetColorCode(string value){
			this.colorCode_ = value;
		}
		public string GetSpu(){
			return this.spu_;
		}
		
		public void SetSpu(string value){
			this.spu_ = value;
		}
		public int? GetLeavingUnboxQuantity(){
			return this.leavingUnboxQuantity_;
		}
		
		public void SetLeavingUnboxQuantity(int? value){
			this.leavingUnboxQuantity_ = value;
		}
		public int? GetUnboxQuantity(){
			return this.unboxQuantity_;
		}
		
		public void SetUnboxQuantity(int? value){
			this.unboxQuantity_ = value;
		}
		public double? GetDiscountPrice(){
			return this.discountPrice_;
		}
		
		public void SetDiscountPrice(double? value){
			this.discountPrice_ = value;
		}
		public string GetSubOrderSn(){
			return this.subOrderSn_;
		}
		
		public void SetSubOrderSn(string value){
			this.subOrderSn_ = value;
		}
		
	}
	
}