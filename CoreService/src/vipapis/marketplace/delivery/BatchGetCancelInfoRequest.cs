using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class BatchGetCancelInfoRequest {
		
		///<summary>
		/// 订单号（订单号、取消申请单号和创建时间（开始+结束），至少必填其一！）
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 取消申请单号（订单号、取消申请单号和创建时间（开始+结束），至少必填其一！）
		///</summary>
		
		private string apply_sn_;
		
		///<summary>
		/// 取消申请单审核状态：1- 待审核，2-审核通过，3- 审核不通过，4-关闭
		/// @sampleValue audit_status 1
		///</summary>
		
		private int? audit_status_;
		
		///<summary>
		/// 取消申请单创建时间（开始），格式yyyy-MM-dd HH:mm:ss，必须在当前时间的90天内（订单号、取消申请单号和创建时间（开始+结束），至少必填其一！）
		/// @sampleValue start_time 2019-05-01 00:00:00
		///</summary>
		
		private string start_time_;
		
		///<summary>
		/// 取消申请单创建时间（结束），格式yyyy-MM-dd HH:mm:ss，必须在开始时间后的24小时内（订单号、取消申请单号和创建时间（开始+结束），至少必填其一！）
		/// @sampleValue end_time 2019-05-02 00:00:00
		///</summary>
		
		private string end_time_;
		
		///<summary>
		/// 页码，默认第一页
		/// @sampleValue page 1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页数量，默认20条
		/// @sampleValue limit 20
		///</summary>
		
		private int? limit_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetApply_sn(){
			return this.apply_sn_;
		}
		
		public void SetApply_sn(string value){
			this.apply_sn_ = value;
		}
		public int? GetAudit_status(){
			return this.audit_status_;
		}
		
		public void SetAudit_status(int? value){
			this.audit_status_ = value;
		}
		public string GetStart_time(){
			return this.start_time_;
		}
		
		public void SetStart_time(string value){
			this.start_time_ = value;
		}
		public string GetEnd_time(){
			return this.end_time_;
		}
		
		public void SetEnd_time(string value){
			this.end_time_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}