using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.ordererp.api.request{
	
	
	
	
	
	public class AddInfErpOrderInfoReq {
		
		///<summary>
		/// erp订单列表
		///</summary>
		
		private List<com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO> erpOrderList_;
		
		public List<com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO> GetErpOrderList(){
			return this.erpOrderList_;
		}
		
		public void SetErpOrderList(List<com.vip.xstore.order.common.pojo.vo.InfErpOrderInfoVO> value){
			this.erpOrderList_ = value;
		}
		
	}
	
}