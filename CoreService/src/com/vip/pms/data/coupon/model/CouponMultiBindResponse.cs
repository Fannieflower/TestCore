using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.coupon.model{
	
	
	
	
	
	public class CouponMultiBindResponse {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 券号
		///</summary>
		
		private string couponSn_;
		
		///<summary>
		/// 券的状态
		///</summary>
		
		private byte? status_;
		
		///<summary>
		/// 是否派发成功
		///</summary>
		
		private bool? success_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetCouponSn(){
			return this.couponSn_;
		}
		
		public void SetCouponSn(string value){
			this.couponSn_ = value;
		}
		public byte? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(byte? value){
			this.status_ = value;
		}
		public bool? GetSuccess(){
			return this.success_;
		}
		
		public void SetSuccess(bool? value){
			this.success_ = value;
		}
		
	}
	
}