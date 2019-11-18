using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class OrderQueryModel {
		
		///<summary>
		/// 订单状态:0-不合格，1-待定，2-已完结，该参数不设置默认代表全部状态
		///</summary>
		
		private short? status_;
		
		///<summary>
		/// 下单时间起始 时间戳 单位毫秒
		///</summary>
		
		private long? orderTimeStart_;
		
		///<summary>
		/// 下单时间结束 时间戳 单位毫秒
		///</summary>
		
		private long? orderTimeEnd_;
		
		///<summary>
		/// 页码：从1开始
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 页面大小：默认20
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 请求id：UUID
		///</summary>
		
		private string requestId_;
		
		///<summary>
		/// 更新时间-起始 时间戳 单位毫秒
		///</summary>
		
		private long? updateTimeStart_;
		
		///<summary>
		/// 下单时间-结束 时间戳 单位毫秒
		///</summary>
		
		private long? updateTimeEnd_;
		
		public short? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(short? value){
			this.status_ = value;
		}
		public long? GetOrderTimeStart(){
			return this.orderTimeStart_;
		}
		
		public void SetOrderTimeStart(long? value){
			this.orderTimeStart_ = value;
		}
		public long? GetOrderTimeEnd(){
			return this.orderTimeEnd_;
		}
		
		public void SetOrderTimeEnd(long? value){
			this.orderTimeEnd_ = value;
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
		public long? GetUpdateTimeStart(){
			return this.updateTimeStart_;
		}
		
		public void SetUpdateTimeStart(long? value){
			this.updateTimeStart_ = value;
		}
		public long? GetUpdateTimeEnd(){
			return this.updateTimeEnd_;
		}
		
		public void SetUpdateTimeEnd(long? value){
			this.updateTimeEnd_ = value;
		}
		
	}
	
}