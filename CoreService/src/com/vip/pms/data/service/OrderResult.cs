using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class OrderResult {
		
		///<summary>
		/// 结果状态码，1：成功，0：失败
		///</summary>
		
		private int? status_;
		
		///<summary>
		/// 错误编码
		///</summary>
		
		private int? errorCode_;
		
		///<summary>
		/// 错误详情
		///</summary>
		
		private string errorMessage_;
		
		///<summary>
		///</summary>
		
		private List<com.vip.pms.data.service.Ordermid> ordermids_;
		
		public int? GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(int? value){
			this.status_ = value;
		}
		public int? GetErrorCode(){
			return this.errorCode_;
		}
		
		public void SetErrorCode(int? value){
			this.errorCode_ = value;
		}
		public string GetErrorMessage(){
			return this.errorMessage_;
		}
		
		public void SetErrorMessage(string value){
			this.errorMessage_ = value;
		}
		public List<com.vip.pms.data.service.Ordermid> GetOrdermids(){
			return this.ordermids_;
		}
		
		public void SetOrdermids(List<com.vip.pms.data.service.Ordermid> value){
			this.ordermids_ = value;
		}
		
	}
	
}