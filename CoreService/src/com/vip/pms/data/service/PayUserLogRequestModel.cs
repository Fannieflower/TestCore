using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PayUserLogRequestModel {
		
		///<summary>
		/// 可以同时传多个订单的数据，但须保证每个订单的数据是完整的。
		///</summary>
		
		private List<com.vip.pms.data.service.UserLogRequestModel> logModels_;
		
		///<summary>
		/// user id
		///</summary>
		
		private long? userId_;
		
		public List<com.vip.pms.data.service.UserLogRequestModel> GetLogModels(){
			return this.logModels_;
		}
		
		public void SetLogModels(List<com.vip.pms.data.service.UserLogRequestModel> value){
			this.logModels_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		
	}
	
}