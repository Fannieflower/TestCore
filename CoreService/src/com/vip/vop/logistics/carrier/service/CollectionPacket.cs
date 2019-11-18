using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class CollectionPacket {
		
		///<summary>
		/// 包裹明细
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.CollectionPacketItem> items_;
		
		public List<com.vip.vop.logistics.carrier.service.CollectionPacketItem> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<com.vip.vop.logistics.carrier.service.CollectionPacketItem> value){
			this.items_ = value;
		}
		
	}
	
}