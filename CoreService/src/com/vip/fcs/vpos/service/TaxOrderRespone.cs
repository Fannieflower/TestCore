using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class TaxOrderRespone {
		
		///<summary>
		/// 订单头
		///</summary>
		
		private com.vip.fcs.vpos.service.TaxOrderHeader taxOrderHeader_;
		
		///<summary>
		/// 商品信息
		///</summary>
		
		private List<com.vip.fcs.vpos.service.TaxOrderItem> orderItemList_;
		
		public com.vip.fcs.vpos.service.TaxOrderHeader GetTaxOrderHeader(){
			return this.taxOrderHeader_;
		}
		
		public void SetTaxOrderHeader(com.vip.fcs.vpos.service.TaxOrderHeader value){
			this.taxOrderHeader_ = value;
		}
		public List<com.vip.fcs.vpos.service.TaxOrderItem> GetOrderItemList(){
			return this.orderItemList_;
		}
		
		public void SetOrderItemList(List<com.vip.fcs.vpos.service.TaxOrderItem> value){
			this.orderItemList_ = value;
		}
		
	}
	
}