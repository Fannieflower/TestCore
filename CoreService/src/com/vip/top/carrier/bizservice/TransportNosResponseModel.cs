using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class TransportNosResponseModel {
		
		///<summary>
		/// 状态 0 正常 1 失败
		///</summary>
		
		private string returnCode_;
		
		///<summary>
		/// 返回信息 正常情况为空，异常情况，返回异常原因
		///</summary>
		
		private string returnMsg_;
		
		///<summary>
		/// 运单号列表
		///</summary>
		
		private List<string> transportNos_;
		
		public string GetReturnCode(){
			return this.returnCode_;
		}
		
		public void SetReturnCode(string value){
			this.returnCode_ = value;
		}
		public string GetReturnMsg(){
			return this.returnMsg_;
		}
		
		public void SetReturnMsg(string value){
			this.returnMsg_ = value;
		}
		public List<string> GetTransportNos(){
			return this.transportNos_;
		}
		
		public void SetTransportNos(List<string> value){
			this.transportNos_ = value;
		}
		
	}
	
}