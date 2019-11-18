using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.ordererp.api.response{
	
	
	
	
	
	public class AddFailMsgVO {
		
		///<summary>
		/// 外部订单号
		///</summary>
		
		private string extOrderSn_;
		
		///<summary>
		/// 失败原因描述
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 错误码
		///</summary>
		
		private string failCode_;
		
		public string GetExtOrderSn(){
			return this.extOrderSn_;
		}
		
		public void SetExtOrderSn(string value){
			this.extOrderSn_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetFailCode(){
			return this.failCode_;
		}
		
		public void SetFailCode(string value){
			this.failCode_ = value;
		}
		
	}
	
}