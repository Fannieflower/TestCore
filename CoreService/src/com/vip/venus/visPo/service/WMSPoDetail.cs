using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class WMSPoDetail {
		
		///<summary>
		/// PO编号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// PO头
		///</summary>
		
		private com.vip.venus.visPo.service.WmsPoHeaderNew poHeader_;
		
		///<summary>
		/// PO详情
		///</summary>
		
		private List<com.vip.venus.visPo.service.WmsPoDetailNew> poDetails_;
		
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public com.vip.venus.visPo.service.WmsPoHeaderNew GetPoHeader(){
			return this.poHeader_;
		}
		
		public void SetPoHeader(com.vip.venus.visPo.service.WmsPoHeaderNew value){
			this.poHeader_ = value;
		}
		public List<com.vip.venus.visPo.service.WmsPoDetailNew> GetPoDetails(){
			return this.poDetails_;
		}
		
		public void SetPoDetails(List<com.vip.venus.visPo.service.WmsPoDetailNew> value){
			this.poDetails_ = value;
		}
		
	}
	
}