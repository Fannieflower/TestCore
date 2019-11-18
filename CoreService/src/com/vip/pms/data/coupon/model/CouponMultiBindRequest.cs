using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.coupon.model{
	
	
	
	
	
	public class CouponMultiBindRequest {
		
		///<summary>
		/// 券的批次号(老系统命名为coupon_id)
		///</summary>
		
		private string groupNo_;
		
		///<summary>
		/// 待派券的用户ID列表
		///</summary>
		
		private List<long?> userIds_;
		
		public string GetGroupNo(){
			return this.groupNo_;
		}
		
		public void SetGroupNo(string value){
			this.groupNo_ = value;
		}
		public List<long?> GetUserIds(){
			return this.userIds_;
		}
		
		public void SetUserIds(List<long?> value){
			this.userIds_ = value;
		}
		
	}
	
}