using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.lbs.lpc.service.common{
	
	
	
	
	
	public class LbsResponseHeader {
		
		///<summary>
		/// 业务响应编码
		///</summary>
		
		private string resultCode_;
		
		///<summary>
		/// 业务响应结果描述
		///</summary>
		
		private string resultMsg_;
		
		///<summary>
		/// 响应机器地址
		///</summary>
		
		private string hostIp_;
		
		///<summary>
		/// 响应耗时
		///</summary>
		
		private string costTime_;
		
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
		public string GetHostIp(){
			return this.hostIp_;
		}
		
		public void SetHostIp(string value){
			this.hostIp_ = value;
		}
		public string GetCostTime(){
			return this.costTime_;
		}
		
		public void SetCostTime(string value){
			this.costTime_ = value;
		}
		
	}
	
}