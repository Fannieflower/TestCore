using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ShippingCollectionResult {
		
		///<summary>
		/// 交易id
		///</summary>
		
		private string trade_id_;
		
		///<summary>
		/// 状态，1=成功，2=揽件包裹明细不全，3=失败重试
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 描述信息
		///</summary>
		
		private string msg_;
		
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		
	}
	
}