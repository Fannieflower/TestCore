using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.invoice{
	
	
	
	
	
	public class GetInvoicesRequest {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 开始下单时间
		///</summary>
		
		private string query_start_time_;
		
		///<summary>
		/// 结束下单时间
		///</summary>
		
		private string query_end_time_;
		
		///<summary>
		/// 发票类型：1 纸质发票 2电子发票
		///</summary>
		
		private string invoice_type_;
		
		///<summary>
		/// 发票状态：0-未开具，1-开具中，2-已开具，9-开具失败
		///</summary>
		
		private string invoice_status_;
		
		///<summary>
		/// 每页数量，默认50 最大200
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetQuery_start_time(){
			return this.query_start_time_;
		}
		
		public void SetQuery_start_time(string value){
			this.query_start_time_ = value;
		}
		public string GetQuery_end_time(){
			return this.query_end_time_;
		}
		
		public void SetQuery_end_time(string value){
			this.query_end_time_ = value;
		}
		public string GetInvoice_type(){
			return this.invoice_type_;
		}
		
		public void SetInvoice_type(string value){
			this.invoice_type_ = value;
		}
		public string GetInvoice_status(){
			return this.invoice_status_;
		}
		
		public void SetInvoice_status(string value){
			this.invoice_status_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		
	}
	
}