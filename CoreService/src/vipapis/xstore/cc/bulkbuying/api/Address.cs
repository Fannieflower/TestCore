using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class Address {
		
		///<summary>
		/// 联系人
		///</summary>
		
		private string contacter_;
		
		///<summary>
		/// 联系人电话
		///</summary>
		
		private string contacter_tel_;
		
		///<summary>
		/// 联系人手机
		///</summary>
		
		private string contacter_mobile_;
		
		///<summary>
		/// 国家
		///</summary>
		
		private string country_;
		
		///<summary>
		/// 省名称
		///</summary>
		
		private string province_name_;
		
		///<summary>
		/// 市名称
		///</summary>
		
		private string city_name_;
		
		///<summary>
		/// 地区编码
		///</summary>
		
		private string district_name_;
		
		///<summary>
		/// 详细地址
		///</summary>
		
		private string detail_address_;
		
		///<summary>
		/// 邮箱
		///</summary>
		
		private string email_;
		
		public string GetContacter(){
			return this.contacter_;
		}
		
		public void SetContacter(string value){
			this.contacter_ = value;
		}
		public string GetContacter_tel(){
			return this.contacter_tel_;
		}
		
		public void SetContacter_tel(string value){
			this.contacter_tel_ = value;
		}
		public string GetContacter_mobile(){
			return this.contacter_mobile_;
		}
		
		public void SetContacter_mobile(string value){
			this.contacter_mobile_ = value;
		}
		public string GetCountry(){
			return this.country_;
		}
		
		public void SetCountry(string value){
			this.country_ = value;
		}
		public string GetProvince_name(){
			return this.province_name_;
		}
		
		public void SetProvince_name(string value){
			this.province_name_ = value;
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
		public string GetDetail_address(){
			return this.detail_address_;
		}
		
		public void SetDetail_address(string value){
			this.detail_address_ = value;
		}
		public string GetEmail(){
			return this.email_;
		}
		
		public void SetEmail(string value){
			this.email_ = value;
		}
		
	}
	
}