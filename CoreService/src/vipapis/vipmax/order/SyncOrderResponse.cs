using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class SyncOrderResponse {
		
		///<summary>
		/// 商家订单号
		///</summary>
		
		private string out_order_sn_;
		
		public string GetOut_order_sn(){
			return this.out_order_sn_;
		}
		
		public void SetOut_order_sn(string value){
			this.out_order_sn_ = value;
		}
		
	}
	
}