using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class Result {
		
		///<summary>
		/// 消息码，全部成功返回200，部分或全部记录处理失败返回400208
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 消息
		///</summary>
		
		private string message_;
		
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}