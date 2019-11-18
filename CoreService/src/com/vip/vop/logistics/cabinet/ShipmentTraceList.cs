using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class ShipmentTraceList {
		
		///<summary>
		/// 承运商编码（唯品会），跟第三方承运商编码二选一
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 第三方承运商编码,跟承运商编码（唯品会）二选一
		///</summary>
		
		private string outer_carrier_code_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 轨迹列表 批量最大100
		///</summary>
		
		private List<com.vip.vop.logistics.cabinet.ShipmentTrace> traces_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetOuter_carrier_code(){
			return this.outer_carrier_code_;
		}
		
		public void SetOuter_carrier_code(string value){
			this.outer_carrier_code_ = value;
		}
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public List<com.vip.vop.logistics.cabinet.ShipmentTrace> GetTraces(){
			return this.traces_;
		}
		
		public void SetTraces(List<com.vip.vop.logistics.cabinet.ShipmentTrace> value){
			this.traces_ = value;
		}
		
	}
	
}