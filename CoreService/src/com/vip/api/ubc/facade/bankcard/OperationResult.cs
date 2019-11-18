using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	
	
	public class OperationResult {
		
		///<summary>
		/// 操作序号,与json中的serialNumber对应,用于查看对应的数据操作结果
		///</summary>
		
		private string serialNumber_;
		
		///<summary>
		/// 操作结果码
		///</summary>
		
		private string resultCode_;
		
		///<summary>
		/// 操作结果信息
		///</summary>
		
		private string resultMsg_;
		
		public string GetSerialNumber(){
			return this.serialNumber_;
		}
		
		public void SetSerialNumber(string value){
			this.serialNumber_ = value;
		}
		public string GetResultCode(){
			return this.resultCode_;
		}
		
		public void SetResultCode(string value){
			this.resultCode_ = value;
		}
		public string GetResultMsg(){
			return this.resultMsg_;
		}
		
		public void SetResultMsg(string value){
			this.resultMsg_ = value;
		}
		
	}
	
}