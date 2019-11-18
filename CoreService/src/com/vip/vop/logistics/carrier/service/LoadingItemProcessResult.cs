using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class LoadingItemProcessResult {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 唯品会订单号（向海申报的客户订单号）
		///</summary>
		
		private string trade_id_;
		
		///<summary>
		/// 处理状态（1=成功 0=重试）
		///</summary>
		
		private int? process_status_;
		
		///<summary>
		/// 错误说明
		///</summary>
		
		private string error_msg_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		public int? GetProcess_status(){
			return this.process_status_;
		}
		
		public void SetProcess_status(int? value){
			this.process_status_ = value;
		}
		public string GetError_msg(){
			return this.error_msg_;
		}
		
		public void SetError_msg(string value){
			this.error_msg_ = value;
		}
		
	}
	
}