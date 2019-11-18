using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipOperateResult {
		
		///<summary>
		/// true:成功 false:失败
		///</summary>
		
		private bool? result_;
		
		///<summary>
		/// 错误编号
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// msg
		///</summary>
		
		private string msg_;
		
		public bool? GetResult(){
			return this.result_;
		}
		
		public void SetResult(bool? value){
			this.result_ = value;
		}
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		
	}
	
}