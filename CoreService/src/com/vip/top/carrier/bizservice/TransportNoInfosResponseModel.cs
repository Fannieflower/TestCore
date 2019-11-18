using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class TransportNoInfosResponseModel {
		
		///<summary>
		/// 状态 0 正常 1 失败
		///</summary>
		
		private string returnCode_;
		
		///<summary>
		/// 返回信息 正常情况为空，异常情况，返回异常原因
		///</summary>
		
		private string returnMsg_;
		
		///<summary>
		/// 运单号信息列表
		///</summary>
		
		private List<com.vip.top.carrier.bizservice.TransportNoInfoModel> transportNoInfos_;
		
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
		public List<com.vip.top.carrier.bizservice.TransportNoInfoModel> GetTransportNoInfos(){
			return this.transportNoInfos_;
		}
		
		public void SetTransportNoInfos(List<com.vip.top.carrier.bizservice.TransportNoInfoModel> value){
			this.transportNoInfos_ = value;
		}
		
	}
	
}