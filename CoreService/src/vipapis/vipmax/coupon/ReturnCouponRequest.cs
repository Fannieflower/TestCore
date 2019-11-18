using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class ReturnCouponRequest {
		
		///<summary>
		/// 用户加密的openID
		///</summary>
		
		private string open_uid_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 取消订单的商品列表
		///</summary>
		
		private List<vipapis.vipmax.coupon.CancelledSkus> cancelled_skus_;
		
		///<summary>
		/// 券列表
		///</summary>
		
		private List<string> coupon_sns_;
		
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
		public List<vipapis.vipmax.coupon.CancelledSkus> GetCancelled_skus(){
			return this.cancelled_skus_;
		}
		
		public void SetCancelled_skus(List<vipapis.vipmax.coupon.CancelledSkus> value){
			this.cancelled_skus_ = value;
		}
		public List<string> GetCoupon_sns(){
			return this.coupon_sns_;
		}
		
		public void SetCoupon_sns(List<string> value){
			this.coupon_sns_ = value;
		}
		
	}
	
}