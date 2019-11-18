using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class TransportNoInfosMapResponseModel {
		
		///<summary>
		/// 返回码
		///</summary>
		
		private string returnCode_;
		
		///<summary>
		/// 返回说明
		///</summary>
		
		private string returnMsg_;
		
		///<summary>
		/// 运单号信息列表
		///</summary>
		
		private Dictionary<string, List<com.vip.top.carrier.bizservice.TransportNoInfo>> transportNoInfosMap_;
		
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
		public Dictionary<string, List<com.vip.top.carrier.bizservice.TransportNoInfo>> GetTransportNoInfosMap(){
			return this.transportNoInfosMap_;
		}
		
		public void SetTransportNoInfosMap(Dictionary<string, List<com.vip.top.carrier.bizservice.TransportNoInfo>> value){
			this.transportNoInfosMap_ = value;
		}
		
	}
	
}