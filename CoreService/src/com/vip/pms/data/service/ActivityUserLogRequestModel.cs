using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ActivityUserLogRequestModel {
		
		///<summary>
		/// 写日志通用参数对象
		///</summary>
		
		private List<com.vip.pms.data.service.UserLogRequestModel> baseRequestModels_;
		
		///<summary>
		/// user id
		///</summary>
		
		private long? userId_;
		
		public List<com.vip.pms.data.service.UserLogRequestModel> GetBaseRequestModels(){
			return this.baseRequestModels_;
		}
		
		public void SetBaseRequestModels(List<com.vip.pms.data.service.UserLogRequestModel> value){
			this.baseRequestModels_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		
	}
	
}