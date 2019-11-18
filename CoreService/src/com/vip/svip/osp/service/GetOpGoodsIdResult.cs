using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetOpGoodsIdResult {
		
		///<summary>
		/// 商品id列表
		///</summary>
		
		private List<string> goodsIdList_;
		
		public List<string> GetGoodsIdList(){
			return this.goodsIdList_;
		}
		
		public void SetGoodsIdList(List<string> value){
			this.goodsIdList_ = value;
		}
		
	}
	
}