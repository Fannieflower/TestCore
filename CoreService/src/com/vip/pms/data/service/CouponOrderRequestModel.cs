using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponOrderRequestModel {
		
		///<summary>
		/// 优惠券明细
		///</summary>
		
		private List<com.vip.pms.data.service.CouponUserLogRequestModel> couponUserList_;
		
		///<summary>
		/// 用户ID，分库使用
		///</summary>
		
		private long? userId_;
		
		public List<com.vip.pms.data.service.CouponUserLogRequestModel> GetCouponUserList(){
			return this.couponUserList_;
		}
		
		public void SetCouponUserList(List<com.vip.pms.data.service.CouponUserLogRequestModel> value){
			this.couponUserList_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		
	}
	
}