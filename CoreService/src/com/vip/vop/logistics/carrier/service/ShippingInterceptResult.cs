using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ShippingInterceptResult {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 拦截状态, 0=成功，1=失败
		///</summary>
		
		private int? intercept_status_;
		
		///<summary>
		/// 拦截结果描述信息
		///</summary>
		
		private string msg_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public int? GetIntercept_status(){
			return this.intercept_status_;
		}
		
		public void SetIntercept_status(int? value){
			this.intercept_status_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		
	}
	
}