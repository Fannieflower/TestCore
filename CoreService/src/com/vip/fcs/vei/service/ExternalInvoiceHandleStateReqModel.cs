using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class ExternalInvoiceHandleStateReqModel {
		
		///<summary>
		/// 要查询的订单号集合
		///</summary>
		
		private List<string> orderSnList_;
		
		///<summary>
		/// 每个订单号对应发票的查询条数，不传的话默认每个订单最多返回20条数据
		///</summary>
		
		private int? limit_;
		
		public List<string> GetOrderSnList(){
			return this.orderSnList_;
		}
		
		public void SetOrderSnList(List<string> value){
			this.orderSnList_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}