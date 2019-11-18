using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	
	
	public class BankDataResponse {
		
		///<summary>
		/// 接收到并且解密成功的数据总个数
		///</summary>
		
		private int? dataNum_;
		
		///<summary>
		/// 成功写入或更新数据库的数据个数
		///</summary>
		
		private int? successDataNum_;
		
		///<summary>
		/// 写入或更新失败的数据个数
		///</summary>
		
		private int? failedDataNum_;
		
		///<summary>
		/// 数据来源,广发:CGB,建行:CCB,招行:CMB,浦发:SPDB,中行:BOC
		///</summary>
		
		private string bankName_;
		
		///<summary>
		/// 每一个数据的详细操作结果
		///</summary>
		
		private List<com.vip.api.ubc.facade.bankcard.OperationResult> result_;
		
		public int? GetDataNum(){
			return this.dataNum_;
		}
		
		public void SetDataNum(int? value){
			this.dataNum_ = value;
		}
		public int? GetSuccessDataNum(){
			return this.successDataNum_;
		}
		
		public void SetSuccessDataNum(int? value){
			this.successDataNum_ = value;
		}
		public int? GetFailedDataNum(){
			return this.failedDataNum_;
		}
		
		public void SetFailedDataNum(int? value){
			this.failedDataNum_ = value;
		}
		public string GetBankName(){
			return this.bankName_;
		}
		
		public void SetBankName(string value){
			this.bankName_ = value;
		}
		public List<com.vip.api.ubc.facade.bankcard.OperationResult> GetResult(){
			return this.result_;
		}
		
		public void SetResult(List<com.vip.api.ubc.facade.bankcard.OperationResult> value){
			this.result_ = value;
		}
		
	}
	
}