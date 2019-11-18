using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class SyncResult {
		
		///<summary>
		/// 结果状态码，1：成功，0：失败
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 错误编码
		///</summary>
		
		private int? errorCode_;
		
		///<summary>
		/// 错误详情
		///</summary>
		
		private string errorMessage_;
		
		///<summary>
		/// 不存在的actNo列表
		///</summary>
		
		private List<string> spilthList_;
		
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public int? GetErrorCode(){
			return this.errorCode_;
		}
		
		public void SetErrorCode(int? value){
			this.errorCode_ = value;
		}
		public string GetErrorMessage(){
			return this.errorMessage_;
		}
		
		public void SetErrorMessage(string value){
			this.errorMessage_ = value;
		}
		public List<string> GetSpilthList(){
			return this.spilthList_;
		}
		
		public void SetSpilthList(List<string> value){
			this.spilthList_ = value;
		}
		
	}
	
}