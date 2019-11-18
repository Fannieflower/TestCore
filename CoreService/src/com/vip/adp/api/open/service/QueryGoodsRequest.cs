using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class QueryGoodsRequest {
		
		///<summary>
		/// 关键词
		///</summary>
		
		private string keyword_;
		
		///<summary>
		/// 排序字段
		///</summary>
		
		private string fieldName_;
		
		///<summary>
		/// 排序顺序：0-正序，1-逆序，默认正序
		///</summary>
		
		private int? order_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 页面大小：默认20
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 请求id：UUID，调用方自行定义，用于追踪请求
		///</summary>
		
		private string requestId_;
		
		///<summary>
		/// 价格区间---start
		///</summary>
		
		private string priceStart_;
		
		///<summary>
		/// 价格区间---end
		///</summary>
		
		private string priceEnd_;
		
		public string GetKeyword(){
			return this.keyword_;
		}
		
		public void SetKeyword(string value){
			this.keyword_ = value;
		}
		public string GetFieldName(){
			return this.fieldName_;
		}
		
		public void SetFieldName(string value){
			this.fieldName_ = value;
		}
		public int? GetOrder(){
			return this.order_;
		}
		
		public void SetOrder(int? value){
			this.order_ = value;
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
		public string GetPriceStart(){
			return this.priceStart_;
		}
		
		public void SetPriceStart(string value){
			this.priceStart_ = value;
		}
		public string GetPriceEnd(){
			return this.priceEnd_;
		}
		
		public void SetPriceEnd(string value){
			this.priceEnd_ = value;
		}
		
	}
	
}