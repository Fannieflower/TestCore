using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class RefundOrderRequest {
		
		///<summary>
		/// 查询类型:0-维权发起时间，1-维权完成时间（佣金扣除入账时间），2-佣金扣除结算时间
		///</summary>
		
		private int? searchType_;
		
		///<summary>
		/// 目标时间起始：时间戳，单位毫秒; 当searchType=0时，为维权发起时间，
		///当searchType=1时，为维权完成时间（佣金扣除结算时间），
		///当searchType=2时，为佣金扣除结算时间
		///</summary>
		
		private long? searchTimeStart_;
		
		///<summary>
		/// 目标时间结束：时间戳，单位毫秒; 当searchType=0时，为维权发起时间，
		///当searchType=1时，为维权完成时间（佣金扣除结算时间），
		///当searchType=2时，为佣金扣除结算时间
		///</summary>
		
		private long? searchTimeEnd_;
		
		///<summary>
		/// 目标订单号集合:当指定订单号集合时，目标时间区间可以不传,否则必须指定目标时间区间
		///</summary>
		
		private List<string> orderSns_;
		
		///<summary>
		/// 当前页
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 分页大小：默认20
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 唯一请求id：单次请求唯一，调用方自行定义，用于追踪请求
		///</summary>
		
		private string requestId_;
		
		public int? GetSearchType(){
			return this.searchType_;
		}
		
		public void SetSearchType(int? value){
			this.searchType_ = value;
		}
		public long? GetSearchTimeStart(){
			return this.searchTimeStart_;
		}
		
		public void SetSearchTimeStart(long? value){
			this.searchTimeStart_ = value;
		}
		public long? GetSearchTimeEnd(){
			return this.searchTimeEnd_;
		}
		
		public void SetSearchTimeEnd(long? value){
			this.searchTimeEnd_ = value;
		}
		public List<string> GetOrderSns(){
			return this.orderSns_;
		}
		
		public void SetOrderSns(List<string> value){
			this.orderSns_ = value;
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
		public string GetRequestId(){
			return this.requestId_;
		}
		
		public void SetRequestId(string value){
			this.requestId_ = value;
		}
		
	}
	
}