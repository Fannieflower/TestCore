using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class OrderResponse {
		
		///<summary>
		/// 业绩查询响应结果
		///</summary>
		
		private List<com.vip.adp.api.open.service.OrderInfo> orderInfoList_;
		
		///<summary>
		/// 业绩总条数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 当前页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 页面大小
		///</summary>
		
		private int? pageSize_;
		
		public List<com.vip.adp.api.open.service.OrderInfo> GetOrderInfoList(){
			return this.orderInfoList_;
		}
		
		public void SetOrderInfoList(List<com.vip.adp.api.open.service.OrderInfo> value){
			this.orderInfoList_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}