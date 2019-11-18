using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics{
	
	
	
	
	
	public class Address {
		
		///<summary>
		/// 国家
		/// @sampleValue country 中国
		///</summary>
		
		private string country_;
		
		///<summary>
		/// 省、州
		/// @sampleValue state_name 广东省
		///</summary>
		
		private string state_name_;
		
		///<summary>
		/// 城市
		/// @sampleValue city_name 广州市
		///</summary>
		
		private string city_name_;
		
		///<summary>
		/// 区
		/// @sampleValue district_name 荔湾区
		///</summary>
		
		private string district_name_;
		
		///<summary>
		/// 详细地址
		/// @sampleValue address 花海街2号
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 邮编
		/// @sampleValue zip 100010
		///</summary>
		
		private string zip_;
		
		///<summary>
		/// 街道
		/// @sampleValue street 荔湾街道
		///</summary>
		
		private string street_;
		
		public string GetCountry(){
			return this.country_;
		}
		
		public void SetCountry(string value){
			this.country_ = value;
		}
		public string GetState_name(){
			return this.state_name_;
		}
		
		public void SetState_name(string value){
			this.state_name_ = value;
		}
		public string GetCity_name(){
			return this.city_name_;
		}
		
		public void SetCity_name(string value){
			this.city_name_ = value;
		}
		public string GetDistrict_name(){
			return this.district_name_;
		}
		
		public void SetDistrict_name(string value){
			this.district_name_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetZip(){
			return this.zip_;
		}
		
		public void SetZip(string value){
			this.zip_ = value;
		}
		public string GetStreet(){
			return this.street_;
		}
		
		public void SetStreet(string value){
			this.street_ = value;
		}
		
	}
	
}