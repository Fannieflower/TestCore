using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.newretail{
	
	
	
	
	
	public class GetOrdersResponse {
		
		///<summary>
		/// 售前订单列表
		///</summary>
		
		private List<com.vip.vop.cup.api.newretail.Order> orders_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		public List<com.vip.vop.cup.api.newretail.Order> GetOrders(){
			return this.orders_;
		}
		
		public void SetOrders(List<com.vip.vop.cup.api.newretail.Order> value){
			this.orders_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		
	}
	
}