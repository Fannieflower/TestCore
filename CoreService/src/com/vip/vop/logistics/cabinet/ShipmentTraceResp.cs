using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class ShipmentTraceResp {
		
		///<summary>
		/// 处理结果
		///</summary>
		
		private List<com.vip.vop.logistics.cabinet.ShipmentTraceResult> shipment_trace_result_;
		
		public List<com.vip.vop.logistics.cabinet.ShipmentTraceResult> GetShipment_trace_result(){
			return this.shipment_trace_result_;
		}
		
		public void SetShipment_trace_result(List<com.vip.vop.logistics.cabinet.ShipmentTraceResult> value){
			this.shipment_trace_result_ = value;
		}
		
	}
	
}