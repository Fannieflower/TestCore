using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class DiscountInfoModel {
		
		///<summary>
		/// 满减活动力度
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.FullCutInfo fullCutInfo_;
		
		///<summary>
		/// 移动专享活动力度
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.MobileInfo mobileInfo_;
		
		///<summary>
		/// 优惠券活动力度
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.CouponInfo couponInfo_;
		
		///<summary>
		/// 预付活动力度
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.PrepayInfo prepayInfo_;
		
		///<summary>
		/// 专享价
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.ExclusivePrice exclusivePrice_;
		
		public com.vip.api.promotion.vis.protcontract.service.FullCutInfo GetFullCutInfo(){
			return this.fullCutInfo_;
		}
		
		public void SetFullCutInfo(com.vip.api.promotion.vis.protcontract.service.FullCutInfo value){
			this.fullCutInfo_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.MobileInfo GetMobileInfo(){
			return this.mobileInfo_;
		}
		
		public void SetMobileInfo(com.vip.api.promotion.vis.protcontract.service.MobileInfo value){
			this.mobileInfo_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.CouponInfo GetCouponInfo(){
			return this.couponInfo_;
		}
		
		public void SetCouponInfo(com.vip.api.promotion.vis.protcontract.service.CouponInfo value){
			this.couponInfo_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.PrepayInfo GetPrepayInfo(){
			return this.prepayInfo_;
		}
		
		public void SetPrepayInfo(com.vip.api.promotion.vis.protcontract.service.PrepayInfo value){
			this.prepayInfo_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.ExclusivePrice GetExclusivePrice(){
			return this.exclusivePrice_;
		}
		
		public void SetExclusivePrice(com.vip.api.promotion.vis.protcontract.service.ExclusivePrice value){
			this.exclusivePrice_ = value;
		}
		
	}
	
}