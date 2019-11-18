using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.ofc.request.vop{
	
	
	
	
	
	public class WmsUpdateOrderStatusReq {
		
		///<summary>
		/// WMS客户订单状态VO,每次调用最大列表长度为100
		///</summary>
		
		private List<com.vip.ofc.request.vop.WmsOrderStatusVO> wmsOrderStatusList_;
		
		///<summary>
		/// 订单发货仓库
		/// @sampleValue warehouse 例如：VIP_NH
		///</summary>
		
		private string warehouse_;
		
		public List<com.vip.ofc.request.vop.WmsOrderStatusVO> GetWmsOrderStatusList(){
			return this.wmsOrderStatusList_;
		}
		
		public void SetWmsOrderStatusList(List<com.vip.ofc.request.vop.WmsOrderStatusVO> value){
			this.wmsOrderStatusList_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		
	}
	
}