using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class ExpressList {
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 售卖价格
		///</summary>
		
		private double? salePrice_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private long? spuId_;
		
		///<summary>
		/// skuId
		///</summary>
		
		private long? skuId_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public double? GetSalePrice(){
			return this.salePrice_;
		}
		
		public void SetSalePrice(double? value){
			this.salePrice_ = value;
		}
		public int? GetQuantity(){
			return this.quantity_;
		}
		
		public void SetQuantity(int? value){
			this.quantity_ = value;
		}
		public long? GetSpuId(){
			return this.spuId_;
		}
		
		public void SetSpuId(long? value){
			this.spuId_ = value;
		}
		public long? GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(long? value){
			this.skuId_ = value;
		}
		
	}
	
}