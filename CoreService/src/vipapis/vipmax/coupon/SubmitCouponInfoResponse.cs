using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class SubmitCouponInfoResponse {
		
		///<summary>
		/// 总优惠金额
		///</summary>
		
		private string total_fav_;
		
		///<summary>
		/// 单件商品分摊的优惠明细，key-value结构 key为sku_id,value为分摊的优惠金额
		///</summary>
		
		private Dictionary<string, string> alloc_fav_;
		
		///<summary>
		/// 券的优惠信息列表
		///</summary>
		
		private List<vipapis.vipmax.coupon.CouponUseResult> coupons_;
		
		public string GetTotal_fav(){
			return this.total_fav_;
		}
		
		public void SetTotal_fav(string value){
			this.total_fav_ = value;
		}
		public Dictionary<string, string> GetAlloc_fav(){
			return this.alloc_fav_;
		}
		
		public void SetAlloc_fav(Dictionary<string, string> value){
			this.alloc_fav_ = value;
		}
		public List<vipapis.vipmax.coupon.CouponUseResult> GetCoupons(){
			return this.coupons_;
		}
		
		public void SetCoupons(List<vipapis.vipmax.coupon.CouponUseResult> value){
			this.coupons_ = value;
		}
		
	}
	
}