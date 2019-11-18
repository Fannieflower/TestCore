using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.stock{
	
	
	
	
	
	public class updateVendorWarehouseAndVIPWarehouseMapResult {
		
		///<summary>
		/// 供应商操作仓库编号
		/// @sampleValue vendor_warehouse_id 
		///</summary>
		
		private string vendor_warehouse_id_;
		
		///<summary>
		/// 唯品会仓库编码
		/// @sampleValue vip_warehouse_code 
		///</summary>
		
		private string vip_warehouse_code_;
		
		///<summary>
		/// 是否处理成功
		/// @sampleValue result 
		///</summary>
		
		private string result_;
		
		///<summary>
		/// 错误信息
		/// @sampleValue msg 
		///</summary>
		
		private string msg_;
		
		public string GetVendor_warehouse_id(){
			return this.vendor_warehouse_id_;
		}
		
		public void SetVendor_warehouse_id(string value){
			this.vendor_warehouse_id_ = value;
		}
		public string GetVip_warehouse_code(){
			return this.vip_warehouse_code_;
		}
		
		public void SetVip_warehouse_code(string value){
			this.vip_warehouse_code_ = value;
		}
		public string GetResult(){
			return this.result_;
		}
		
		public void SetResult(string value){
			this.result_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		
	}
	
}