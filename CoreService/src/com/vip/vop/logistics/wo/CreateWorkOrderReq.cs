using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class CreateWorkOrderReq {
		
		///<summary>
		/// 承运商编码
		/// @sampleValue carrier_code shunfeng
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 物流单号
		/// @sampleValue logistics_no 1566437975000
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 问题编码
		/// @sampleValue pc3_code A361301
		///</summary>
		
		private string pc3_code_;
		
		///<summary>
		/// 处理内容
		/// @sampleValue content 快递丢失，需重新补寄
		///</summary>
		
		private string content_;
		
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
		public string GetPc3_code(){
			return this.pc3_code_;
		}
		
		public void SetPc3_code(string value){
			this.pc3_code_ = value;
		}
		public string GetContent(){
			return this.content_;
		}
		
		public void SetContent(string value){
			this.content_ = value;
		}
		
	}
	
}