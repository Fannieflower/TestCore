using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class ShipmentTraceResult {
		
		///<summary>
		/// 第三方承运商编码
		///</summary>
		
		private string outer_carrier_code_;
		
		///<summary>
		/// 承运商编码(唯品会)
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 处理结果（200：成功，其它失败）
		///</summary>
		
		private string result_code_;
		
		///<summary>
		/// 处理结果描述
		///</summary>
		
		private string result_msg_;
		
		public string GetOuter_carrier_code(){
			return this.outer_carrier_code_;
		}
		
		public void SetOuter_carrier_code(string value){
			this.outer_carrier_code_ = value;
		}
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public string GetResult_code(){
			return this.result_code_;
		}
		
		public void SetResult_code(string value){
			this.result_code_ = value;
		}
		public string GetResult_msg(){
			return this.result_msg_;
		}
		
		public void SetResult_msg(string value){
			this.result_msg_ = value;
		}
		
	}
	
}