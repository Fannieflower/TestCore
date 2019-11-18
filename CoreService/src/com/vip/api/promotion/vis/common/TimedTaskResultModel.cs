using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.common{
	
	
	
	
	
	public class TimedTaskResultModel {
		
		///<summary>
		/// 返回码（I200：执行正常，I204：执行正常但无数据处理，E500：接口程序触发代码异常）
		/// @sampleValue ResultCode I200
		///</summary>
		
		private string ResultCode_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string Message_;
		
		public string GetResultCode(){
			return this.ResultCode_;
		}
		
		public void SetResultCode(string value){
			this.ResultCode_ = value;
		}
		public string GetMessage(){
			return this.Message_;
		}
		
		public void SetMessage(string value){
			this.Message_ = value;
		}
		
	}
	
}