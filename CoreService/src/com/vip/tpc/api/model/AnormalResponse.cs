using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class AnormalResponse {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 唯品会订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 状态 1 成功，0 失败
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 原因描述
		///</summary>
		
		private string result_;
		
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetResult(){
			return this.result_;
		}
		
		public void SetResult(string value){
			this.result_ = value;
		}
		
	}
	
}