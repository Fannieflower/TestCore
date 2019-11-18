using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class GetShippingReq {
		
		///<summary>
		/// 承运商编码（唯品会），跟第三方承运商编码只能二选一
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 第三方承运商编码,跟承运商编码（唯品会）只能二选一
		///</summary>
		
		private string outer_carrier_code_;
		
		///<summary>
		/// 运单号 批量支持50
		///</summary>
		
		private List<string> logistics_nos_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetOuter_carrier_code(){
			return this.outer_carrier_code_;
		}
		
		public void SetOuter_carrier_code(string value){
			this.outer_carrier_code_ = value;
		}
		public List<string> GetLogistics_nos(){
			return this.logistics_nos_;
		}
		
		public void SetLogistics_nos(List<string> value){
			this.logistics_nos_ = value;
		}
		
	}
	
}