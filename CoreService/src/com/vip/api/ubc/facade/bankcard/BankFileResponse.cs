using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	
	
	public class BankFileResponse {
		
		///<summary>
		/// 成功接收并恢复解密的文件个数
		///</summary>
		
		private int? result_;
		
		///<summary>
		/// 文件来源,广发:CGB,建行:CCB,招行:CMB,浦发:SPDB,中行:BOC
		///</summary>
		
		private string bankName_;
		
		public int? GetResult(){
			return this.result_;
		}
		
		public void SetResult(int? value){
			this.result_ = value;
		}
		public string GetBankName(){
			return this.bankName_;
		}
		
		public void SetBankName(string value){
			this.bankName_ = value;
		}
		
	}
	
}