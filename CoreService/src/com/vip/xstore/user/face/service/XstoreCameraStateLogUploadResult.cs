using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraStateLogUploadResult {
		
		///<summary>
		/// 返回码，默认成功200
		///</summary>
		
		private int? returnCode_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string returnMessage_;
		
		///<summary>
		/// 上传成功条数
		///</summary>
		
		private int? successCount_;
		
		public int? GetReturnCode(){
			return this.returnCode_;
		}
		
		public void SetReturnCode(int? value){
			this.returnCode_ = value;
		}
		public string GetReturnMessage(){
			return this.returnMessage_;
		}
		
		public void SetReturnMessage(string value){
			this.returnMessage_ = value;
		}
		public int? GetSuccessCount(){
			return this.successCount_;
		}
		
		public void SetSuccessCount(int? value){
			this.successCount_ = value;
		}
		
	}
	
}