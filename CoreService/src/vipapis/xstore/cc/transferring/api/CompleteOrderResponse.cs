using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class CompleteOrderResponse {
		
		///<summary>
		/// 返回码, 0: 成功, 其他失败
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 错误信息
		///</summary>
		
		private string msg_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		
	}
	
}