using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class CouponInfo {
		
		///<summary>
		/// 表示用户点击优惠券的顺序
		///</summary>
		
		private int? seq_;
		
		///<summary>
		/// 用户使用的优惠券券号
		///</summary>
		
		private string coupon_sn_;
		
		public int? GetSeq(){
			return this.seq_;
		}
		
		public void SetSeq(int? value){
			this.seq_ = value;
		}
		public string GetCoupon_sn(){
			return this.coupon_sn_;
		}
		
		public void SetCoupon_sn(string value){
			this.coupon_sn_ = value;
		}
		
	}
	
}