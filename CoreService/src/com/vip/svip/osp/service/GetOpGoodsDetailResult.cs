using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetOpGoodsDetailResult {
		
		///<summary>
		/// 商品id列表
		///</summary>
		
		private List<com.vip.svip.osp.service.GetOpGoodsDetailItem> goodsDetailList_;
		
		public List<com.vip.svip.osp.service.GetOpGoodsDetailItem> GetGoodsDetailList(){
			return this.goodsDetailList_;
		}
		
		public void SetGoodsDetailList(List<com.vip.svip.osp.service.GetOpGoodsDetailItem> value){
			this.goodsDetailList_ = value;
		}
		
	}
	
}