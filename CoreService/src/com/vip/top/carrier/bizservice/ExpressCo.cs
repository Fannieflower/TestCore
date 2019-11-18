using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class ExpressCo {
		
		///<summary>
		/// 快递商编码
		///</summary>
		
		private string code_;
		
		///<summary>
		/// 快递商简称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 快递商全称
		///</summary>
		
		private string fullname_;
		
		///<summary>
		/// 快递商唯一编号
		///</summary>
		
		private long? custNo_;
		
		public string GetCode(){
			return this.code_;
		}
		
		public void SetCode(string value){
			this.code_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetFullname(){
			return this.fullname_;
		}
		
		public void SetFullname(string value){
			this.fullname_ = value;
		}
		public long? GetCustNo(){
			return this.custNo_;
		}
		
		public void SetCustNo(long? value){
			this.custNo_ = value;
		}
		
	}
	
}