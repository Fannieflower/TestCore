using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.newretail{
	
	
	
	
	
	public class Order {
		
		///<summary>
		/// 订单编号
		///</summary>
		
		private string order_id_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		
	}
	
}