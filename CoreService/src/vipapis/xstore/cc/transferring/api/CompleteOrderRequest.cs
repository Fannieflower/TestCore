using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class CompleteOrderRequest {
		
		///<summary>
		/// 调拨单号
		///</summary>
		
		private string transferring_order_no_;
		
		///<summary>
		/// 实际入库数量
		///</summary>
		
		private int? total_qty_;
		
		public string GetTransferring_order_no(){
			return this.transferring_order_no_;
		}
		
		public void SetTransferring_order_no(string value){
			this.transferring_order_no_ = value;
		}
		public int? GetTotal_qty(){
			return this.total_qty_;
		}
		
		public void SetTotal_qty(int? value){
			this.total_qty_ = value;
		}
		
	}
	
}