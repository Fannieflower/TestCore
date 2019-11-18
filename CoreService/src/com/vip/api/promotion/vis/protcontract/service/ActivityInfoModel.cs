using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ActivityInfoModel {
		
		///<summary>
		/// 活动类型 ,1:满减,2:买免,3:折扣,6:优惠卷红包,7:拼团,8:预付,9:N元任选,10:第N件折扣,11:会员等级,12:人群,13:新老客,14:限时快抢专享价,15:超级VIP专享价,16:加价购,17:单品促销,18:砍价活动
		///</summary>
		
		private byte? activityType_;
		
		///<summary>
		/// 承担方式,0:未知,1：账扣,2:电汇
		///</summary>
		
		private byte? bearType_;
		
		public byte? GetActivityType(){
			return this.activityType_;
		}
		
		public void SetActivityType(byte? value){
			this.activityType_ = value;
		}
		public byte? GetBearType(){
			return this.bearType_;
		}
		
		public void SetBearType(byte? value){
			this.bearType_ = value;
		}
		
	}
	
}