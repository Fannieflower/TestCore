using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class CreateOrderReq {
		
		///<summary>
		/// 订单基础信息
		///</summary>
		
		private com.vip.vop.cup.api.order.OrderBasicInfo order_basic_info_;
		
		///<summary>
		/// 订单商品信息列表
		///</summary>
		
		private List<com.vip.vop.cup.api.order.OrderGoodsInfo> order_goods_list_;
		
		///<summary>
		/// 订单收货人信息
		///</summary>
		
		private com.vip.vop.cup.api.order.OrderConsigneeInfo order_consignee_info_;
		
		public com.vip.vop.cup.api.order.OrderBasicInfo GetOrder_basic_info(){
			return this.order_basic_info_;
		}
		
		public void SetOrder_basic_info(com.vip.vop.cup.api.order.OrderBasicInfo value){
			this.order_basic_info_ = value;
		}
		public List<com.vip.vop.cup.api.order.OrderGoodsInfo> GetOrder_goods_list(){
			return this.order_goods_list_;
		}
		
		public void SetOrder_goods_list(List<com.vip.vop.cup.api.order.OrderGoodsInfo> value){
			this.order_goods_list_ = value;
		}
		public com.vip.vop.cup.api.order.OrderConsigneeInfo GetOrder_consignee_info(){
			return this.order_consignee_info_;
		}
		
		public void SetOrder_consignee_info(com.vip.vop.cup.api.order.OrderConsigneeInfo value){
			this.order_consignee_info_ = value;
		}
		
	}
	
}