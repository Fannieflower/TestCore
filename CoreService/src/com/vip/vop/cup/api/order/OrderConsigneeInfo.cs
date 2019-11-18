using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.order{
	
	
	
	
	
	public class OrderConsigneeInfo {
		
		///<summary>
		/// 地址类型 1-家庭2-工作,3-其他 
		///</summary>
		
		private int? addr_type_;
		
		///<summary>
		/// 收货人姓名
		///</summary>
		
		private string consignee_;
		
		///<summary>
		/// 地址码
		///</summary>
		
		private string area_id_;
		
		///<summary>
		/// 详细地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 邮政编码
		///</summary>
		
		private string post_code_;
		
		///<summary>
		/// 手机号码
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 电话号码
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
		public string GetPost_code(){
			return this.post_code_;
		}
		
		public void SetPost_code(string value){
			this.post_code_ = value;
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