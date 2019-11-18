using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderResponse {
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.vop.vcloud.common.api.Pagination pagination_;
		
		///<summary>
		/// 订单列表
		///</summary>
		
		private List<com.vip.vop.vcloud.order.Order> orders_;
		
		///<summary>
		/// 订单商品列表
		///</summary>
		
		private List<com.vip.vop.vcloud.order.OrderGoods> orderGoodsList_;
		
		public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
			this.pagination_ = value;
		}
		public List<com.vip.vop.vcloud.order.Order> GetOrders(){
			return this.orders_;
		}
		
		public void SetOrders(List<com.vip.vop.vcloud.order.Order> value){
			this.orders_ = value;
		}
		public List<com.vip.vop.vcloud.order.OrderGoods> GetOrderGoodsList(){
			return this.orderGoodsList_;
		}
		
		public void SetOrderGoodsList(List<com.vip.vop.vcloud.order.OrderGoods> value){
			this.orderGoodsList_ = value;
		}
		
	}
	
}