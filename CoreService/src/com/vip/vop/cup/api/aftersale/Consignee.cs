using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class Consignee {
		
		///<summary>
		/// 地址类型：1-家庭，2-工作,3-其他 
		///</summary>
		
		private int? addr_type_;
		
		///<summary>
		/// 收货人姓名，最大长度：50
		///</summary>
		
		private string consignee_;
		
		///<summary>
		/// 地址编码
		///</summary>
		
		private string area_id_;
		
		///<summary>
		/// 详细地址描述，最大长度：250
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 收货人手机号，最大长度：20
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 收货人电话号码，最大长度：20
		///</summary>
		
		private string tel_;
		
		public int? GetAddr_type(){
			return this.addr_type_;
		}
		
		public void SetAddr_type(int? value){
			this.addr_type_ = value;
		}
		public string GetConsignee(){
			return this.consignee_;
		}
		
		public void SetConsignee(string value){
			this.consignee_ = value;
		}
		public string GetArea_id(){
			return this.area_id_;
		}
		
		public void SetArea_id(string value){
			this.area_id_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		
	}
	
}