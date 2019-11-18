using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponRequestModel {
		
		///<summary>
		/// 普通券参数对象
		///</summary>
		
		private com.vip.pms.data.service.CouponCoreModel couponCoreModel_;
		
		///<summary>
		/// 组合券参数对象
		///</summary>
		
		private com.vip.pms.data.service.CouponGroupCoreModel couponGroupCoreModel_;
		
		public com.vip.pms.data.service.CouponCoreModel GetCouponCoreModel(){
			return this.couponCoreModel_;
		}
		
		public void SetCouponCoreModel(com.vip.pms.data.service.CouponCoreModel value){
			this.couponCoreModel_ = value;
		}
		public com.vip.pms.data.service.CouponGroupCoreModel GetCouponGroupCoreModel(){
			return this.couponGroupCoreModel_;
		}
		
		public void SetCouponGroupCoreModel(com.vip.pms.data.service.CouponGroupCoreModel value){
			this.couponGroupCoreModel_ = value;
		}
		
	}
	
}