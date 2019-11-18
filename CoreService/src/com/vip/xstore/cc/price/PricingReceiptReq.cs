using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.price{
	
	
	
	
	
	public class PricingReceiptReq {
		
		///<summary>
		/// 请求上下文
		///</summary>
		
		private com.vip.xstore.cc.price.ReqContext reqContext_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 开始创建时间
		///</summary>
		
		private System.DateTime? startCreateTime_;
		
		///<summary>
		/// 结束创建时间
		///</summary>
		
		private System.DateTime? endCreateTime_;
		
		public com.vip.xstore.cc.price.ReqContext GetReqContext(){
			return this.reqContext_;
		}
		
		public void SetReqContext(com.vip.xstore.cc.price.ReqContext value){
			this.reqContext_ = value;
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
		public System.DateTime? GetStartCreateTime(){
			return this.startCreateTime_;
		}
		
		public void SetStartCreateTime(System.DateTime? value){
			this.startCreateTime_ = value;
		}
		public System.DateTime? GetEndCreateTime(){
			return this.endCreateTime_;
		}
		
		public void SetEndCreateTime(System.DateTime? value){
			this.endCreateTime_ = value;
		}
		
	}
	
}