using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class ProductAlteration {
		
		///<summary>
		/// 消息ID
		///</summary>
		
		private long? message_id_;
		
		///<summary>
		/// SPU或者SKU，以prodType来区分
		///</summary>
		
		private string prod_id_;
		
		///<summary>
		/// 变动类型
		///</summary>
		
		private com.vip.vop.cup.api.product.EventType? event_type_;
		
		///<summary>
		/// 商品ID类型
		///</summary>
		
		private com.vip.vop.cup.api.product.ProductType? product_type_;
		
		public long? GetMessage_id(){
			return this.message_id_;
		}
		
		public void SetMessage_id(long? value){
			this.message_id_ = value;
		}
		public string GetProd_id(){
			return this.prod_id_;
		}
		
		public void SetProd_id(string value){
			this.prod_id_ = value;
		}
		public com.vip.vop.cup.api.product.EventType? GetEvent_type(){
			return this.event_type_;
		}
		
		public void SetEvent_type(com.vip.vop.cup.api.product.EventType? value){
			this.event_type_ = value;
		}
		public com.vip.vop.cup.api.product.ProductType? GetProduct_type(){
			return this.product_type_;
		}
		
		public void SetProduct_type(com.vip.vop.cup.api.product.ProductType? value){
			this.product_type_ = value;
		}
		
	}
	
}