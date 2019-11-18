using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class GetAscsRequest {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 售后申请单创建开始时间
		///</summary>
		
		private string query_start_time_;
		
		///<summary>
		/// 售后申请单创建结束时间
		///</summary>
		
		private string query_end_time_;
		
		///<summary>
		/// 售后申请单类型： 0拒收，1客退
		///</summary>
		
		private byte? asc_type_;
		
		///<summary>
		/// 状态：0 待审核，1 已审核，2 审核不通过，3 已同意退款，4 已拒绝退款，9 已完成，10 已取消
		///</summary>
		
		private byte? asc_status_;
		
		///<summary>
		/// 退款状态：1 未发起退款，2 已发起退款，99 无需退款
		///</summary>
		
		private int? refund_status_;
		
		///<summary>
		/// 每页数量，默认50 最大200
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operator_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetQuery_start_time(){
			return this.query_start_time_;
		}
		
		public void SetQuery_start_time(string value){
			this.query_start_time_ = value;
		}
		public string GetQuery_end_time(){
			return this.query_end_time_;
		}
		
		public void SetQuery_end_time(string value){
			this.query_end_time_ = value;
		}
		public byte? GetAsc_type(){
			return this.asc_type_;
		}
		
		public void SetAsc_type(byte? value){
			this.asc_type_ = value;
		}
		public byte? GetAsc_status(){
			return this.asc_status_;
		}
		
		public void SetAsc_status(byte? value){
			this.asc_status_ = value;
		}
		public int? GetRefund_status(){
			return this.refund_status_;
		}
		
		public void SetRefund_status(int? value){
			this.refund_status_ = value;
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
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		
	}
	
}