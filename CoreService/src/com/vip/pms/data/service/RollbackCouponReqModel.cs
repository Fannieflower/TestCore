using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class RollbackCouponReqModel {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 需要回滚的券SN列表
		///</summary>
		
		private List<string> couponSns_;
		
		///<summary>
		/// 需要回滚的订单SN列表
		///</summary>
		
		private List<string> orderSns_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public List<string> GetCouponSns(){
			return this.couponSns_;
		}
		
		public void SetCouponSns(List<string> value){
			this.couponSns_ = value;
		}
		public List<string> GetOrderSns(){
			return this.orderSns_;
		}
		
		public void SetOrderSns(List<string> value){
			this.orderSns_ = value;
		}
		
	}
	
}