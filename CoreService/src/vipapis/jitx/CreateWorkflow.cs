using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class CreateWorkflow {
		
		///<summary>
		/// 请求流水号，在同一次申请时必须是全局唯一值
		///</summary>
		
		private string request_id_;
		
		///<summary>
		/// 唯品会订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 新发货仓标识
		///</summary>
		
		private string new_delivery_warehouse_;
		
		///<summary>
		/// 改仓原因代码
		///</summary>
		
		private string reason_code_;
		
		///<summary>
		/// 改仓备注（最大200个字符）
		///</summary>
		
		private string reason_remark_;
		
		public string GetRequest_id(){
			return this.request_id_;
		}
		
		public void SetRequest_id(string value){
			this.request_id_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetNew_delivery_warehouse(){
			return this.new_delivery_warehouse_;
		}
		
		public void SetNew_delivery_warehouse(string value){
			this.new_delivery_warehouse_ = value;
		}
		public string GetReason_code(){
			return this.reason_code_;
		}
		
		public void SetReason_code(string value){
			this.reason_code_ = value;
		}
		public string GetReason_remark(){
			return this.reason_remark_;
		}
		
		public void SetReason_remark(string value){
			this.reason_remark_ = value;
		}
		
	}
	
}