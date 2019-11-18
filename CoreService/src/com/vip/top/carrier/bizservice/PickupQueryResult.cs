using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class PickupQueryResult {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 件数
		///</summary>
		
		private int? qty_;
		
		///<summary>
		/// 交接时间
		///</summary>
		
		private string joinTime_;
		
		///<summary>
		/// 交接人
		///</summary>
		
		private string opName_;
		
		///<summary>
		/// 交件站点名称
		///</summary>
		
		private string pointName_;
		
		///<summary>
		/// 订单客户
		///</summary>
		
		private string customerName_;
		
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
		public int? GetQty(){
			return this.qty_;
		}
		
		public void SetQty(int? value){
			this.qty_ = value;
		}
		public string GetJoinTime(){
			return this.joinTime_;
		}
		
		public void SetJoinTime(string value){
			this.joinTime_ = value;
		}
		public string GetOpName(){
			return this.opName_;
		}
		
		public void SetOpName(string value){
			this.opName_ = value;
		}
		public string GetPointName(){
			return this.pointName_;
		}
		
		public void SetPointName(string value){
			this.pointName_ = value;
		}
		public string GetCustomerName(){
			return this.customerName_;
		}
		
		public void SetCustomerName(string value){
			this.customerName_ = value;
		}
		
	}
	
}