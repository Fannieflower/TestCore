using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ShippingInterceptResp {
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 运单拦截处理结果列表
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.InterceptResult> intercept_results_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public List<com.vip.vop.logistics.carrier.service.InterceptResult> GetIntercept_results(){
			return this.intercept_results_;
		}
		
		public void SetIntercept_results(List<com.vip.vop.logistics.carrier.service.InterceptResult> value){
			this.intercept_results_ = value;
		}
		
	}
	
}