using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.ofc.vo{
	
	
	
	
	
	public class VopRequestHeader {
		
		///<summary>
		/// 操作
		/// @sampleValue operation 例如更新订单状态 ： UPDATE_ORDER_STATUS
		///</summary>
		
		private string operation_;
		
		///<summary>
		/// 请求方系统编码
		/// @sampleValue sourceSys 例如高捷快运 ： GJKY
		///</summary>
		
		private string sourceSys_;
		
		///<summary>
		/// 交易流水号
		///</summary>
		
		private string transId_;
		
		///<summary>
		/// 交易时间 unix timestamp 精确到秒
		///</summary>
		
		private long? transTimestamp_;
		
		///<summary>
		/// 操作人的工号，系统操作填系统标识，客服操作填客服工号
		///</summary>
		
		private string operatorCode_;
		
		///<summary>
		/// 操作人姓名
		///</summary>
		
		private string operatorName_;
		
		///<summary>
		/// 客户端ip
		///</summary>
		
		private string clientIp_;
		
		public string GetOperation(){
			return this.operation_;
		}
		
		public void SetOperation(string value){
			this.operation_ = value;
		}
		public string GetSourceSys(){
			return this.sourceSys_;
		}
		
		public void SetSourceSys(string value){
			this.sourceSys_ = value;
		}
		public string GetTransId(){
			return this.transId_;
		}
		
		public void SetTransId(string value){
			this.transId_ = value;
		}
		public long? GetTransTimestamp(){
			return this.transTimestamp_;
		}
		
		public void SetTransTimestamp(long? value){
			this.transTimestamp_ = value;
		}
		public string GetOperatorCode(){
			return this.operatorCode_;
		}
		
		public void SetOperatorCode(string value){
			this.operatorCode_ = value;
		}
		public string GetOperatorName(){
			return this.operatorName_;
		}
		
		public void SetOperatorName(string value){
			this.operatorName_ = value;
		}
		public string GetClientIp(){
			return this.clientIp_;
		}
		
		public void SetClientIp(string value){
			this.clientIp_ = value;
		}
		
	}
	
}