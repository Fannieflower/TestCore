using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ModifyInfoRequestModel {
		
		///<summary>
		/// 优惠券批次号
		///</summary>
		
		private int? couponId_;
		
		///<summary>
		/// 劵新的使用开始时间
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 劵新的使用结束时间
		///</summary>
		
		private long? endTime_;
		
		public int? GetCouponId(){
			return this.couponId_;
		}
		
		public void SetCouponId(int? value){
			this.couponId_ = value;
		}
		public long? GetBeginTime(){
			return this.beginTime_;
		}
		
		public void SetBeginTime(long? value){
			this.beginTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
		}
		
	}
	
}