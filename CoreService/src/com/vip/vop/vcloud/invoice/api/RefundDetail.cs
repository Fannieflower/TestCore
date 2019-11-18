using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	
	
	public class RefundDetail {
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? quantity_;
		
		///<summary>
		/// 单价
		///</summary>
		
		private double? amount_;
		
		///<summary>
		/// 行金额
		///</summary>
		
		private double? totalAmount_;
		
		///<summary>
		/// 行优惠金额
		///</summary>
		
		private double? discountAmount_;
		
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
		public double? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(double? value){
			this.amount_ = value;
		}
		public double? GetTotalAmount(){
			return this.totalAmount_;
		}
		
		public void SetTotalAmount(double? value){
			this.totalAmount_ = value;
		}
		public double? GetDiscountAmount(){
			return this.discountAmount_;
		}
		
		public void SetDiscountAmount(double? value){
			this.discountAmount_ = value;
		}
		
	}
	
}