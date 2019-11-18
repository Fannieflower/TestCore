using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class GetVipmaxOrdersRequest {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? user_id_;
		
		///<summary>
		/// 商家订单号
		///</summary>
		
		private string out_order_sn_;
		
		///<summary>
		/// 用户手机号
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 每页数量，默认50 最大200
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 页码 默认1
		///</summary>
		
		private int? page_;
		
		public long? GetUser_id(){
			return this.user_id_;
		}
		
		public void SetUser_id(long? value){
			this.user_id_ = value;
		}
		public string GetOut_order_sn(){
			return this.out_order_sn_;
		}
		
		public void SetOut_order_sn(string value){
			this.out_order_sn_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
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