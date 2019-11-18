using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class RegisteredCarrierModelModel {
		
		///<summary>
		/// 承运商唯一编号
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 短名称
		///</summary>
		
		private string custName_;
		
		///<summary>
		/// 名称
		///</summary>
		
		private string custCnname_;
		
		///<summary>
		/// 地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 联系人
		///</summary>
		
		private string contact_;
		
		///<summary>
		/// 联系电话
		///</summary>
		
		private string tel_;
		
		///<summary>
		/// 网址
		///</summary>
		
		private string url_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 状态
		///</summary>
		
		private int? active_;
		
		///<summary>
		/// 承运商类型
		///</summary>
		
		private int? custType_;
		
		///<summary>
		/// 业务类型
		///</summary>
		
		private string businessType_;
		
		///<summary>
		/// 承运商唯一编号
		///</summary>
		
		private long? custNo_;
		
		///<summary>
		/// 是否品骏系
		///</summary>
		
		private int? isPjGroup_;
		
		///<summary>
		/// EIQ分组
		///</summary>
		
		private string eiqGroup_;
		
		///<summary>
		/// 承运商标准名称
		///</summary>
		
		private string custStandardName_;
		
		///<summary>
		/// 承运商助记码
		///</summary>
		
		private string custUncode_;
		
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetCustName(){
			return this.custName_;
		}
		
		public void SetCustName(string value){
			this.custName_ = value;
		}
		public string GetCustCnname(){
			return this.custCnname_;
		}
		
		public void SetCustCnname(string value){
			this.custCnname_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetContact(){
			return this.contact_;
		}
		
		public void SetContact(string value){
			this.contact_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		public string GetUrl(){
			return this.url_;
		}
		
		public void SetUrl(string value){
			this.url_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public int? GetActive(){
			return this.active_;
		}
		
		public void SetActive(int? value){
			this.active_ = value;
		}
		public int? GetCustType(){
			return this.custType_;
		}
		
		public void SetCustType(int? value){
			this.custType_ = value;
		}
		public string GetBusinessType(){
			return this.businessType_;
		}
		
		public void SetBusinessType(string value){
			this.businessType_ = value;
		}
		public long? GetCustNo(){
			return this.custNo_;
		}
		
		public void SetCustNo(long? value){
			this.custNo_ = value;
		}
		public int? GetIsPjGroup(){
			return this.isPjGroup_;
		}
		
		public void SetIsPjGroup(int? value){
			this.isPjGroup_ = value;
		}
		public string GetEiqGroup(){
			return this.eiqGroup_;
		}
		
		public void SetEiqGroup(string value){
			this.eiqGroup_ = value;
		}
		public string GetCustStandardName(){
			return this.custStandardName_;
		}
		
		public void SetCustStandardName(string value){
			this.custStandardName_ = value;
		}
		public string GetCustUncode(){
			return this.custUncode_;
		}
		
		public void SetCustUncode(string value){
			this.custUncode_ = value;
		}
		
	}
	
}