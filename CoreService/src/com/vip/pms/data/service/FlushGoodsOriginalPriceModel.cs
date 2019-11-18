using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class FlushGoodsOriginalPriceModel {
		
		///<summary>
		/// 商品SPU ID
		///</summary>
		
		private string spuId_;
		
		///<summary>
		/// 商品原定价
		///</summary>
		
		private string originalPrice_;
		
		public string GetSpuId(){
			return this.spuId_;
		}
		
		public void SetSpuId(string value){
			this.spuId_ = value;
		}
		public string GetOriginalPrice(){
			return this.originalPrice_;
		}
		
		public void SetOriginalPrice(string value){
			this.originalPrice_ = value;
		}
		
	}
	
}