using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class PricingReceiptItemResp {
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? hasNext_;
		
		///<summary>
		/// 定价单明细列表
		///</summary>
		
		private List<com.vip.xstore.cc.price.PricingReceiptItem> pricingReceiptItems_;
		
		public bool? GetHasNext(){
			return this.hasNext_;
		}
		
		public void SetHasNext(bool? value){
			this.hasNext_ = value;
		}
		public List<com.vip.xstore.cc.price.PricingReceiptItem> GetPricingReceiptItems(){
			return this.pricingReceiptItems_;
		}
		
		public void SetPricingReceiptItems(List<com.vip.xstore.cc.price.PricingReceiptItem> value){
			this.pricingReceiptItems_ = value;
		}
		
	}
	
}