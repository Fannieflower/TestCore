using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ReportPacketInfoResp {
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 包裹信息处理结果列表
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.Packets> packetsList_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public List<com.vip.vop.logistics.carrier.service.Packets> GetPacketsList(){
			return this.packetsList_;
		}
		
		public void SetPacketsList(List<com.vip.vop.logistics.carrier.service.Packets> value){
			this.packetsList_ = value;
		}
		
	}
	
}