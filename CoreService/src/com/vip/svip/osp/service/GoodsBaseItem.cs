using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GoodsBaseItem {
		
		///<summary>
		/// 专场id
		///</summary>
		
		private string brandId_;
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		public string GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(string value){
			this.brandId_ = value;
		}
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		
	}
	
}