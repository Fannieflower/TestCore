using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class Packets {
		
		///<summary>
		/// 交易ID
		///</summary>
		
		private string trade_id_;
		
		///<summary>
		/// 包裹处理结果列表
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.PacketResult> packet_results_;
		
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		public List<com.vip.vop.logistics.carrier.service.PacketResult> GetPacket_results(){
			return this.packet_results_;
		}
		
		public void SetPacket_results(List<com.vip.vop.logistics.carrier.service.PacketResult> value){
			this.packet_results_ = value;
		}
		
	}
	
}