using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BrandGoodsPriceResult {
		
		///<summary>
		/// sizeId
		///</summary>
		
		private List<com.vip.svip.osp.service.BrandGoodsPriceItem> itemList_;
		
		public List<com.vip.svip.osp.service.BrandGoodsPriceItem> GetItemList(){
			return this.itemList_;
		}
		
		public void SetItemList(List<com.vip.svip.osp.service.BrandGoodsPriceItem> value){
			this.itemList_ = value;
		}
		
	}
	
}