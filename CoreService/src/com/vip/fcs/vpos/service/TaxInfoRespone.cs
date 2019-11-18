using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class TaxInfoRespone {
		
		///<summary>
		/// 返回码（0：成功，1：失败）
		///</summary>
		
		private string ret_;
		
		///<summary>
		/// 返回说明信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 返回说明信息
		///</summary>
		
		private string data_;
		
		public string GetRet(){
			return this.ret_;
		}
		
		public void SetRet(string value){
			this.ret_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public string GetData(){
			return this.data_;
		}
		
		public void SetData(string value){
			this.data_ = value;
		}
		
	}
	
}