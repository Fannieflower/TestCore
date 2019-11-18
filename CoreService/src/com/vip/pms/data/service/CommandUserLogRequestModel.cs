using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CommandUserLogRequestModel {
		
		///<summary>
		/// 写日志通用参数对象
		///</summary>
		
		private com.vip.pms.data.service.UserLogRequestModel baseRequestModel_;
		
		public com.vip.pms.data.service.UserLogRequestModel GetBaseRequestModel(){
			return this.baseRequestModel_;
		}
		
		public void SetBaseRequestModel(com.vip.pms.data.service.UserLogRequestModel value){
			this.baseRequestModel_ = value;
		}
		
	}
	
}