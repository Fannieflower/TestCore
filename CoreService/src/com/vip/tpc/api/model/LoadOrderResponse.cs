using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class LoadOrderResponse {
		
		///<summary>
		/// 装载批次ID，固定前缀+序列号，保证全局唯一
		///</summary>
		
		private string loadingId_;
		
		///<summary>
		/// 唯品会订单号,向海关申报的电商客户订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logisticNum_;
		
		///<summary>
		/// 状态，1：成功；0：失败
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 原因描述
		///</summary>
		
		private string remark_;
		
		public string GetLoadingId(){
			return this.loadingId_;
		}
		
		public void SetLoadingId(string value){
			this.loadingId_ = value;
		}
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
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}