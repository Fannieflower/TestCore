using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BrandGoodsPriceItem {
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// pms价格
		///</summary>
		
		private string vipPrice_;
		
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		public string GetVipPrice(){
			return this.vipPrice_;
		}
		
		public void SetVipPrice(string value){
			this.vipPrice_ = value;
		}
		
	}
	
}