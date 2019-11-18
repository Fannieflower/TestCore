using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class StatPoCommonStruct {
		
		///<summary>
		/// 采购数量
		///</summary>
		
		private int? purchaseQuantity_;
		
		///<summary>
		/// 采购平均金额
		///</summary>
		
		private double? avgAmount_;
		
		///<summary>
		/// 采购总金额
		///</summary>
		
		private double? totalAmount_;
		
		///<summary>
		/// 折扣（0~1）
		///</summary>
		
		private double? discount_;
		
		public int? GetPurchaseQuantity(){
			return this.purchaseQuantity_;
		}
		
		public void SetPurchaseQuantity(int? value){
			this.purchaseQuantity_ = value;
		}
		public double? GetAvgAmount(){
			return this.avgAmount_;
		}
		
		public void SetAvgAmount(double? value){
			this.avgAmount_ = value;
		}
		public double? GetTotalAmount(){
			return this.totalAmount_;
		}
		
		public void SetTotalAmount(double? value){
			this.totalAmount_ = value;
		}
		public double? GetDiscount(){
			return this.discount_;
		}
		
		public void SetDiscount(double? value){
			this.discount_ = value;
		}
		
	}
	
}