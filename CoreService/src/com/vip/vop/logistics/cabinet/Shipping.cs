using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class Shipping {
		
		///<summary>
		/// 承运商编码（唯品会）
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 第三方承运商编码
		///</summary>
		
		private string outer_carrier_code_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 联系人信息
		///</summary>
		
		private com.vip.vop.logistics.Linkman linkman_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public string GetOuter_carrier_code(){
			return this.outer_carrier_code_;
		}
		
		public void SetOuter_carrier_code(string value){
			this.outer_carrier_code_ = value;
		}
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public com.vip.vop.logistics.Linkman GetLinkman(){
			return this.linkman_;
		}
		
		public void SetLinkman(com.vip.vop.logistics.Linkman value){
			this.linkman_ = value;
		}
		
	}
	
}