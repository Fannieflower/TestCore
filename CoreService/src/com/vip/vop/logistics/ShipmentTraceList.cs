using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics{
	
	
	
	
	
	public class ShipmentTraceList {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 轨迹列表
		///</summary>
		
		private List<com.vip.vop.logistics.ShipmentTrace> traces_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public List<com.vip.vop.logistics.ShipmentTrace> GetTraces(){
			return this.traces_;
		}
		
		public void SetTraces(List<com.vip.vop.logistics.ShipmentTrace> value){
			this.traces_ = value;
		}
		
	}
	
}