using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponInstanceStatResponse {
		
		///<summary>
		/// 券批次号
		///</summary>
		
		private string couponNo_;
		
		///<summary>
		/// 激活数量
		///</summary>
		
		private long? activatedAmount_;
		
		///<summary>
		/// 使用数量
		///</summary>
		
		private long? usedAmount_;
		
		public string GetCouponNo(){
			return this.couponNo_;
		}
		
		public void SetCouponNo(string value){
			this.couponNo_ = value;
		}
		public long? GetActivatedAmount(){
			return this.activatedAmount_;
		}
		
		public void SetActivatedAmount(long? value){
			this.activatedAmount_ = value;
		}
		public long? GetUsedAmount(){
			return this.usedAmount_;
		}
		
		public void SetUsedAmount(long? value){
			this.usedAmount_ = value;
		}
		
	}
	
}