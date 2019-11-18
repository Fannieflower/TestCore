using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class MobileInfo {
		
		///<summary>
		/// 主信息表
		///</summary>
		
		private long? mainId_;
		
		///<summary>
		/// 活动类型（1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级专享价,12:人群专享价,13:新老客专享价,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动）
		///</summary>
		
		private byte? activityType_;
		
		///<summary>
		/// 移动端描述(移动专享)
		///</summary>
		
		private string mobileRemark_;
		
		///<summary>
		/// 费用承担
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.VendorBearInfo vendorBearInfo_;
		
		public long? GetMainId(){
			return this.mainId_;
		}
		
		public void SetMainId(long? value){
			this.mainId_ = value;
		}
		public byte? GetActivityType(){
			return this.activityType_;
		}
		
		public void SetActivityType(byte? value){
			this.activityType_ = value;
		}
		public string GetMobileRemark(){
			return this.mobileRemark_;
		}
		
		public void SetMobileRemark(string value){
			this.mobileRemark_ = value;
		}
		public com.vip.api.promotion.vis.protcontract.service.VendorBearInfo GetVendorBearInfo(){
			return this.vendorBearInfo_;
		}
		
		public void SetVendorBearInfo(com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value){
			this.vendorBearInfo_ = value;
		}
		
	}
	
}