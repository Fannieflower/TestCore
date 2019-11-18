using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class PacketInfo {
		
		///<summary>
		/// 交易ID
		///</summary>
		
		private string trade_id_;
		
		///<summary>
		/// 包裹信息 批量最大50
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.Packet> packets_;
		
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		public List<com.vip.vop.logistics.carrier.service.Packet> GetPackets(){
			return this.packets_;
		}
		
		public void SetPackets(List<com.vip.vop.logistics.carrier.service.Packet> value){
			this.packets_ = value;
		}
		
	}
	
}