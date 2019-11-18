using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PurchaseOrderImportResponse {
		
		///<summary>
		/// 是否成功
		///</summary>
		
		private bool? isSuccess_;
		
		///<summary>
		/// 错误文件地址
		///</summary>
		
		private string errorFilePath_;
		
		public bool? GetIsSuccess(){
			return this.isSuccess_;
		}
		
		public void SetIsSuccess(bool? value){
			this.isSuccess_ = value;
		}
		public string GetErrorFilePath(){
			return this.errorFilePath_;
		}
		
		public void SetErrorFilePath(string value){
			this.errorFilePath_ = value;
		}
		
	}
	
}