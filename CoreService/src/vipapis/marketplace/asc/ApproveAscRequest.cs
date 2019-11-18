using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class ApproveAscRequest {
		
		///<summary>
		/// 售后申请单号
		///</summary>
		
		private string asc_sn_;
		
		///<summary>
		/// 售后明细id
		///</summary>
		
		private string asc_product_id_;
		
		///<summary>
		/// 操作人信息
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 商家客退地址（明文文本信息）
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 商家联系人
		///</summary>
		
		private string contact_name_;
		
		///<summary>
		/// 商家联系电话
		///</summary>
		
		private string contact_mobile_;
		
		///<summary>
		/// 客退地址邮编
		///</summary>
		
		private string zipcode_;
		
		public string GetAsc_sn(){
			return this.asc_sn_;
		}
		
		public void SetAsc_sn(string value){
			this.asc_sn_ = value;
		}
		public string GetAsc_product_id(){
			return this.asc_product_id_;
		}
		
		public void SetAsc_product_id(string value){
			this.asc_product_id_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetContact_name(){
			return this.contact_name_;
		}
		
		public void SetContact_name(string value){
			this.contact_name_ = value;
		}
		public string GetContact_mobile(){
			return this.contact_mobile_;
		}
		
		public void SetContact_mobile(string value){
			this.contact_mobile_ = value;
		}
		public string GetZipcode(){
			return this.zipcode_;
		}
		
		public void SetZipcode(string value){
			this.zipcode_ = value;
		}
		
	}
	
}