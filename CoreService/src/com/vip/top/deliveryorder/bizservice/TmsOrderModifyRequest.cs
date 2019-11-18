using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class TmsOrderModifyRequest {
		
		///<summary>
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		///</summary>
		
		private int? isJitX_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public int? GetIsJitX(){
			return this.isJitX_;
		}
		
		public void SetIsJitX(int? value){
			this.isJitX_ = value;
		}
		
	}
	
}