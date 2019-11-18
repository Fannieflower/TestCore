using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class PoDetailData {
		
		///<summary>
		/// PO头信息
		///</summary>
		
		private com.vip.venus.visPo.service.PoHeaderInfo poHeaderInfo_;
		
		///<summary>
		/// PO明细信息
		///</summary>
		
		private List<com.vip.venus.visPo.service.PoItem> poItemList_;
		
		public com.vip.venus.visPo.service.PoHeaderInfo GetPoHeaderInfo(){
			return this.poHeaderInfo_;
		}
		
		public void SetPoHeaderInfo(com.vip.venus.visPo.service.PoHeaderInfo value){
			this.poHeaderInfo_ = value;
		}
		public List<com.vip.venus.visPo.service.PoItem> GetPoItemList(){
			return this.poItemList_;
		}
		
		public void SetPoItemList(List<com.vip.venus.visPo.service.PoItem> value){
			this.poItemList_ = value;
		}
		
	}
	
}