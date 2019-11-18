using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class PricingReceiptResp {
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? hasNext_;
		
		///<summary>
		/// 定价单列表
		///</summary>
		
		private List<com.vip.xstore.cc.price.PricingReceipt> pricingReceipts_;
		
		public bool? GetHasNext(){
			return this.hasNext_;
		}
		
		public void SetHasNext(bool? value){
			this.hasNext_ = value;
		}
		public List<com.vip.xstore.cc.price.PricingReceipt> GetPricingReceipts(){
			return this.pricingReceipts_;
		}
		
		public void SetPricingReceipts(List<com.vip.xstore.cc.price.PricingReceipt> value){
			this.pricingReceipts_ = value;
		}
		
	}
	
}