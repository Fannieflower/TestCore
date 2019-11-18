using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetTheTimeSvipPriceResult {
		
		///<summary>
		/// 详情列表
		///</summary>
		
		private List<com.vip.svip.osp.service.PriceItem> detailList_;
		
		public List<com.vip.svip.osp.service.PriceItem> GetDetailList(){
			return this.detailList_;
		}
		
		public void SetDetailList(List<com.vip.svip.osp.service.PriceItem> value){
			this.detailList_ = value;
		}
		
	}
	
}