using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ForwardShipping {
		
		///<summary>
		/// 新承运商编码
		///</summary>
		
		private string new_carrier_code_;
		
		///<summary>
		/// 新运单号
		///</summary>
		
		private string new_logistics_no_;
		
		///<summary>
		/// 原运单号
		///</summary>
		
		private string origin_logistics_no_;
		
		///<summary>
		/// 收件人信息
		///</summary>
		
		private com.vip.vop.logistics.Linkman receiver_;
		
		///<summary>
		/// 收件人地址
		///</summary>
		
		private com.vip.vop.logistics.Address receiver_address_;
		
		public string GetNew_carrier_code(){
			return this.new_carrier_code_;
		}
		
		public void SetNew_carrier_code(string value){
			this.new_carrier_code_ = value;
		}
		public string GetNew_logistics_no(){
			return this.new_logistics_no_;
		}
		
		public void SetNew_logistics_no(string value){
			this.new_logistics_no_ = value;
		}
		public string GetOrigin_logistics_no(){
			return this.origin_logistics_no_;
		}
		
		public void SetOrigin_logistics_no(string value){
			this.origin_logistics_no_ = value;
		}
		public com.vip.vop.logistics.Linkman GetReceiver(){
			return this.receiver_;
		}
		
		public void SetReceiver(com.vip.vop.logistics.Linkman value){
			this.receiver_ = value;
		}
		public com.vip.vop.logistics.Address GetReceiver_address(){
			return this.receiver_address_;
		}
		
		public void SetReceiver_address(com.vip.vop.logistics.Address value){
			this.receiver_address_ = value;
		}
		
	}
	
}