using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetGoodsIdByPickNoResult {
		
		///<summary>
		/// 商品id列表
		///</summary>
		
		private List<com.vip.svip.osp.service.GoodsBaseItem> goodsItemList_;
		
		public List<com.vip.svip.osp.service.GoodsBaseItem> GetGoodsItemList(){
			return this.goodsItemList_;
		}
		
		public void SetGoodsItemList(List<com.vip.svip.osp.service.GoodsBaseItem> value){
			this.goodsItemList_ = value;
		}
		
	}
	
}