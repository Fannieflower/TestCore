using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.price.api{
	
	
	
	
	
	public class QueryPricingReceiptReq {
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数，最大为100
		///</summary>
		
		private int? page_size_;
		
		///<summary>
		/// 开始价格变更单创建时间，时间跨度不超过3天
		///</summary>
		
		private System.DateTime? start_create_time_;
		
		///<summary>
		/// 结束价格变更单创建时间，时间跨度不超过3天
		///</summary>
		
		private System.DateTime? end_create_time_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPage_size(){
			return this.page_size_;
		}
		
		public void SetPage_size(int? value){
			this.page_size_ = value;
		}
		public System.DateTime? GetStart_create_time(){
			return this.start_create_time_;
		}
		
		public void SetStart_create_time(System.DateTime? value){
			this.start_create_time_ = value;
		}
		public System.DateTime? GetEnd_create_time(){
			return this.end_create_time_;
		}
		
		public void SetEnd_create_time(System.DateTime? value){
			this.end_create_time_ = value;
		}
		
	}
	
}