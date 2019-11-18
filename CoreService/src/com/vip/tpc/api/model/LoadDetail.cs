using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class LoadDetail {
		
		///<summary>
		/// 唯品会订单号，向海关申报的电商客户订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logisticNum_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetLogisticNum(){
			return this.logisticNum_;
		}
		
		public void SetLogisticNum(string value){
			this.logisticNum_ = value;
		}
		
	}
	
}