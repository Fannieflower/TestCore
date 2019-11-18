using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	
	
	public class UpdateResult {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 是否更新成功
		///</summary>
		
		private bool? isOk_;
		
		///<summary>
		/// 更新失败情况下错误信息
		///</summary>
		
		private string message_;
		
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
		public bool? GetIsOk(){
			return this.isOk_;
		}
		
		public void SetIsOk(bool? value){
			this.isOk_ = value;
		}
		public string GetMessage(){
			return this.message_;
		}
		
		public void SetMessage(string value){
			this.message_ = value;
		}
		
	}
	
}