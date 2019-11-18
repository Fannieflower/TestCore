using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class ExpressCabinetTraceReq {
		
		///<summary>
		/// 运单轨迹列表，批量最大50
		///</summary>
		
		private List<com.vip.vop.logistics.cabinet.ShipmentTraceList> shipment_traces_;
		
		public List<com.vip.vop.logistics.cabinet.ShipmentTraceList> GetShipment_traces(){
			return this.shipment_traces_;
		}
		
		public void SetShipment_traces(List<com.vip.vop.logistics.cabinet.ShipmentTraceList> value){
			this.shipment_traces_ = value;
		}
		
	}
	
}