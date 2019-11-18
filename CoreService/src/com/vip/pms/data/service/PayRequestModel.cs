using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PayRequestModel {
		
		///<summary>
		/// 支付优惠核心参数
		///</summary>
		
		private com.vip.pms.data.service.PmsPayCoreModel payCoreModel_;
		
		///<summary>
		/// 支付活动的优先级
		///</summary>
		
		private int? priorityLevel_;
		
		public com.vip.pms.data.service.PmsPayCoreModel GetPayCoreModel(){
			return this.payCoreModel_;
		}
		
		public void SetPayCoreModel(com.vip.pms.data.service.PmsPayCoreModel value){
			this.payCoreModel_ = value;
		}
		public int? GetPriorityLevel(){
			return this.priorityLevel_;
		}
		
		public void SetPriorityLevel(int? value){
			this.priorityLevel_ = value;
		}
		
	}
	
}