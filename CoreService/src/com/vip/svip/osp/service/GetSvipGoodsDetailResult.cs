using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetSvipGoodsDetailResult {
		
		///<summary>
		/// 商品列表
		///</summary>
		
		private List<com.vip.svip.osp.service.SvipGoodsDetailItem> goodsList_;
		
		public List<com.vip.svip.osp.service.SvipGoodsDetailItem> GetGoodsList(){
			return this.goodsList_;
		}
		
		public void SetGoodsList(List<com.vip.svip.osp.service.SvipGoodsDetailItem> value){
			this.goodsList_ = value;
		}
		
	}
	
}