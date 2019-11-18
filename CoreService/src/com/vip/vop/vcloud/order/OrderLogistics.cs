using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class OrderLogistics {
		
		///<summary>
		/// 母订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 子订单号
		///</summary>
		
		private string subOrderSn_;
		
		///<summary>
		/// 快递信息列表
		///</summary>
		
		private List<com.vip.vop.vcloud.order.Express> expresses_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetSubOrderSn(){
			return this.subOrderSn_;
		}
		
		public void SetSubOrderSn(string value){
			this.subOrderSn_ = value;
		}
		public List<com.vip.vop.vcloud.order.Express> GetExpresses(){
			return this.expresses_;
		}
		
		public void SetExpresses(List<com.vip.vop.vcloud.order.Express> value){
			this.expresses_ = value;
		}
		
	}
	
}