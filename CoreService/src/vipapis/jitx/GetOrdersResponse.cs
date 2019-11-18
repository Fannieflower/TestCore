using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class GetOrdersResponse {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 当前请求的返回订单列表
		///</summary>
		
		private List<vipapis.jitx.Order> orders_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.jitx.Order> GetOrders(){
			return this.orders_;
		}
		
		public void SetOrders(List<vipapis.jitx.Order> value){
			this.orders_ = value;
		}
		
	}
	
}