using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class ForwarderCompanyVO {
		
		///<summary>
		/// 货代公司名称
		///</summary>
		
		private string forwarderCompanyName_;
		
		///<summary>
		/// 承运商名称
		///</summary>
		
		private string custName_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 货代公司编码
		///</summary>
		
		private string forwarderCompanyCode_;
		
		///<summary>
		/// 订单所属承运商
		///</summary>
		
		private string orderCustCode_;
		
		public string GetForwarderCompanyName(){
			return this.forwarderCompanyName_;
		}
		
		public void SetForwarderCompanyName(string value){
			this.forwarderCompanyName_ = value;
		}
		public string GetCustName(){
			return this.custName_;
		}
		
		public void SetCustName(string value){
			this.custName_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetForwarderCompanyCode(){
			return this.forwarderCompanyCode_;
		}
		
		public void SetForwarderCompanyCode(string value){
			this.forwarderCompanyCode_ = value;
		}
		public string GetOrderCustCode(){
			return this.orderCustCode_;
		}
		
		public void SetOrderCustCode(string value){
			this.orderCustCode_ = value;
		}
		
	}
	
}