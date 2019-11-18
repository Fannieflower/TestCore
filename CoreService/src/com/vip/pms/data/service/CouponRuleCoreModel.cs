using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponRuleCoreModel {
		
		///<summary>
		/// 规则id
		///</summary>
		
		private int? id_;
		
		///<summary>
		/// 规则开始时间
		///</summary>
		
		private long? beginTime_;
		
		///<summary>
		/// 规则结束时间
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 券id列表
		///</summary>
		
		private List<string> couponNoList_;
		
		///<summary>
		/// 派发渠道列表
		///</summary>
		
		private List<com.vip.pms.data.service.CouponRuleChannelModel> couponRuleChannelModelList_;
		
		///<summary>
		/// 规则状态 0:取消或下线, 1:有效
		///</summary>
		
		private int? status_;
		
		public int? GetId(){
			return this.id_;
		}
		
		public void SetId(int? value){
			this.id_ = value;
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
		public List<string> GetCouponNoList(){
			return this.couponNoList_;
		}
		
		public void SetCouponNoList(List<string> value){
			this.couponNoList_ = value;
		}
		public List<com.vip.pms.data.service.CouponRuleChannelModel> GetCouponRuleChannelModelList(){
			return this.couponRuleChannelModelList_;
		}
		
		public void SetCouponRuleChannelModelList(List<com.vip.pms.data.service.CouponRuleChannelModel> value){
			this.couponRuleChannelModelList_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		
	}
	
}