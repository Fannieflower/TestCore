using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics{
	
	
	
	
	
	public class Linkman {
		
		///<summary>
		/// 联系人名称
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 联系人电话
		///</summary>
		
		private string tel_;
		
		///<summary>
		/// 联系人手机号
		///</summary>
		
		private string mobile_;
		
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		
	}
	
}