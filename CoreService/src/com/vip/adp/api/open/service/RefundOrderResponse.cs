using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class RefundOrderResponse {
		
		///<summary>
		/// 联盟维权订单信息
		///</summary>
		
		private List<com.vip.adp.api.open.service.RefundOrderInfo> refundOrderInfoList_;
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 当前页
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 分页大小
		///</summary>
		
		private int? pageSize_;
		
		public List<com.vip.adp.api.open.service.RefundOrderInfo> GetRefundOrderInfoList(){
			return this.refundOrderInfoList_;
		}
		
		public void SetRefundOrderInfoList(List<com.vip.adp.api.open.service.RefundOrderInfo> value){
			this.refundOrderInfoList_ = value;
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