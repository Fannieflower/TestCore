using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service.photorecord{
	
	
	
	
	
	public class XstorePhotoRecordResponse {
		
		///<summary>
		/// 是否成功
		///</summary>
		
		private bool? isSuccess_;
		
		///<summary>
		/// 错误编码
		///</summary>
		
		private string errorCode_;
		
		///<summary>
		/// 错误描述原因
		///</summary>
		
		private string errorDesc_;
		
		public bool? GetIsSuccess(){
			return this.isSuccess_;
		}
		
		public void SetIsSuccess(bool? value){
			this.isSuccess_ = value;
		}
		public string GetErrorCode(){
			return this.errorCode_;
		}
		
		public void SetErrorCode(string value){
			this.errorCode_ = value;
		}
		public string GetErrorDesc(){
			return this.errorDesc_;
		}
		
		public void SetErrorDesc(string value){
			this.errorDesc_ = value;
		}
		
	}
	
}