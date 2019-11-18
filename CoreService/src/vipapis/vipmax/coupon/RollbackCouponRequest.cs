using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class RollbackCouponRequest {
		
		///<summary>
		/// 用户加密的openID
		///</summary>
		
		private string open_uid_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 券列表
		///</summary>
		
		private List<string> coupon_sn_lists_;
		
		public string GetOpen_uid(){
			return this.open_uid_;
		}
		
		public void SetOpen_uid(string value){
			this.open_uid_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public List<string> GetCoupon_sn_lists(){
			return this.coupon_sn_lists_;
		}
		
		public void SetCoupon_sn_lists(List<string> value){
			this.coupon_sn_lists_ = value;
		}
		
	}
	
}