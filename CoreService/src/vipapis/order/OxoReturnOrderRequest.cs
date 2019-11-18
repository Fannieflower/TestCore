using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class OxoReturnOrderRequest {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private long? vendor_id_;
		
		///<summary>
		/// 开始时间，毫秒
		///</summary>
		
		private long? st_query_time_;
		
		///<summary>
		/// 结束时间，毫秒
		///</summary>
		
		private long? et_query_time_;
		
		///<summary>
		/// 每页数量，默认50 最大200
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 页码 默认1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private List<string> order_id_;
		
		public long? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(long? value){
			this.vendor_id_ = value;
		}
		public long? GetSt_query_time(){
			return this.st_query_time_;
		}
		
		public void SetSt_query_time(long? value){
			this.st_query_time_ = value;
		}
		public long? GetEt_query_time(){
			return this.et_query_time_;
		}
		
		public void SetEt_query_time(long? value){
			this.et_query_time_ = value;
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
		public List<string> GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(List<string> value){
			this.order_id_ = value;
		}
		
	}
	
}