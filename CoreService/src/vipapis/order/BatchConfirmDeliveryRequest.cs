using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class BatchConfirmDeliveryRequest {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private List<vipapis.order.ConfirmDelivery> data_;
		
		public List<vipapis.order.ConfirmDelivery> GetData(){
			return this.data_;
		}
		
		public void SetData(List<vipapis.order.ConfirmDelivery> value){
			this.data_ = value;
		}
		
	}
	
}