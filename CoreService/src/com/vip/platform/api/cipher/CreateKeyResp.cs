using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.platform.api.cipher{
	
	
	
	
	
	public class CreateKeyResp {
		
		///<summary>
		/// 是否处理成功
		///</summary>
		
		private bool? success_;
		
		///<summary>
		/// 响应码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 响应描述
		///</summary>
		
		private string desc_;
		
		///<summary>
		/// 详细描述
		///</summary>
		
		private string detailMsg_;
		
		public bool? GetSuccess(){
			return this.success_;
		}
		
		public void SetSuccess(bool? value){
			this.success_ = value;
		}
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetDesc(){
			return this.desc_;
		}
		
		public void SetDesc(string value){
			this.desc_ = value;
		}
		public string GetDetailMsg(){
			return this.detailMsg_;
		}
		
		public void SetDetailMsg(string value){
			this.detailMsg_ = value;
		}
		
	}
	
}