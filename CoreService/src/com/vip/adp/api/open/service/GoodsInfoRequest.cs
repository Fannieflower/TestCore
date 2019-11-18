using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class GoodsInfoRequest {
		
		///<summary>
		/// 频道类型:0-超高佣，1-出单爆款，2-每日精选; 当请求类型为频道时必传
		///</summary>
		
		private int? channelType_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 分页大小:默认20，最大500
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 请求id：UUID,调用方自行定义，用于追踪请求
		///</summary>
		
		private string requestId_;
		
		///<summary>
		/// 是否查询商品评价信息
		///</summary>
		
		private bool? queryReputation_;
		
		///<summary>
		/// 是否查询店铺服务能力信息
		///</summary>
		
		private bool? queryStoreServiceCapability_;
		
		///<summary>
		/// 请求源类型：0-频道，1-组货
		///</summary>
		
		private int? sourceType_;
		
		///<summary>
		/// 精选组货码：当请求源类型为组货时必传
		///</summary>
		
		private string jxCode_;
		
		///<summary>
		/// 排序字段: COMMISSION-佣金，PRICE-价格,COMM_RATIO-佣金比例，DISCOUNT-折扣
		///</summary>
		
		private string fieldName_;
		
		///<summary>
		/// 排序顺序：0-正序，1-逆序，默认正序
		///</summary>
		
		private int? order_;
		
		public int? GetChannelType(){
			return this.channelType_;
		}
		
		public void SetChannelType(int? value){
			this.channelType_ = value;
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
		public bool? GetQueryReputation(){
			return this.queryReputation_;
		}
		
		public void SetQueryReputation(bool? value){
			this.queryReputation_ = value;
		}
		public bool? GetQueryStoreServiceCapability(){
			return this.queryStoreServiceCapability_;
		}
		
		public void SetQueryStoreServiceCapability(bool? value){
			this.queryStoreServiceCapability_ = value;
		}
		public int? GetSourceType(){
			return this.sourceType_;
		}
		
		public void SetSourceType(int? value){
			this.sourceType_ = value;
		}
		public string GetJxCode(){
			return this.jxCode_;
		}
		
		public void SetJxCode(string value){
			this.jxCode_ = value;
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
		
	}
	
}