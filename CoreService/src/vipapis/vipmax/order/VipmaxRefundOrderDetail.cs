using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class VipmaxRefundOrderDetail {
		
		///<summary>
		/// 商品SKU
		///</summary>
		
		private string sku_id_;
		
		///<summary>
		/// 退货数量
		///</summary>
		
		private int? refund_quantity_;
		
		///<summary>
		/// 退货商品单价
		///</summary>
		
		private double? refund_price_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string title_;
		
		public string GetSku_id(){
			return this.sku_id_;
		}
		
		public void SetSku_id(string value){
			this.sku_id_ = value;
		}
		public int? GetRefund_quantity(){
			return this.refund_quantity_;
		}
		
		public void SetRefund_quantity(int? value){
			this.refund_quantity_ = value;
		}
		public double? GetRefund_price(){
			return this.refund_price_;
		}
		
		public void SetRefund_price(double? value){
			this.refund_price_ = value;
		}
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		
	}
	
}