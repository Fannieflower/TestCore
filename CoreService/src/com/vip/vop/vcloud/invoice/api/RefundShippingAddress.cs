using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	
	
	public class RefundShippingAddress {
		
		///<summary>
		/// 退款id
		///</summary>
		
		private long? refundId_;
		
		///<summary>
		/// 用户id
		///</summary>
		
		private long? customerId_;
		
		///<summary>
		/// 姓名
		///</summary>
		
		private string firstname_;
		
		///<summary>
		/// 姓名
		///</summary>
		
		private string lastname_;
		
		///<summary>
		/// 电话
		///</summary>
		
		private string telephone_;
		
		///<summary>
		/// 邮箱
		///</summary>
		
		private string email_;
		
		///<summary>
		/// 省
		///</summary>
		
		private string region_;
		
		///<summary>
		/// 市
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 区
		///</summary>
		
		private string district_;
		
		///<summary>
		/// 街道
		///</summary>
		
		private string street_;
		
		///<summary>
		/// 邮编
		///</summary>
		
		private string postcode_;
		
		public long? GetRefundId(){
			return this.refundId_;
		}
		
		public void SetRefundId(long? value){
			this.refundId_ = value;
		}
		public long? GetCustomerId(){
			return this.customerId_;
		}
		
		public void SetCustomerId(long? value){
			this.customerId_ = value;
		}
		public string GetFirstname(){
			return this.firstname_;
		}
		
		public void SetFirstname(string value){
			this.firstname_ = value;
		}
		public string GetLastname(){
			return this.lastname_;
		}
		
		public void SetLastname(string value){
			this.lastname_ = value;
		}
		public string GetTelephone(){
			return this.telephone_;
		}
		
		public void SetTelephone(string value){
			this.telephone_ = value;
		}
		public string GetEmail(){
			return this.email_;
		}
		
		public void SetEmail(string value){
			this.email_ = value;
		}
		public string GetRegion(){
			return this.region_;
		}
		
		public void SetRegion(string value){
			this.region_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetDistrict(){
			return this.district_;
		}
		
		public void SetDistrict(string value){
			this.district_ = value;
		}
		public string GetStreet(){
			return this.street_;
		}
		
		public void SetStreet(string value){
			this.street_ = value;
		}
		public string GetPostcode(){
			return this.postcode_;
		}
		
		public void SetPostcode(string value){
			this.postcode_ = value;
		}
		
	}
	
}