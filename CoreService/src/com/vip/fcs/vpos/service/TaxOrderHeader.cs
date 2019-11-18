using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vpos.service{
	
	
	
	
	
	public class TaxOrderHeader {
		
		///<summary>
		/// 零售单号
		///</summary>
		
		private string vposOrderNum_;
		
		///<summary>
		/// 店铺id
		///</summary>
		
		private string xstoreId_;
		
		///<summary>
		/// 订单金额
		///</summary>
		
		private double? orderAmount_;
		
		///<summary>
		/// 不开票金额
		///</summary>
		
		private double? invoiceDeductMoney_;
		
		///<summary>
		/// 开票方税号
		///</summary>
		
		private string cAutoBillTaxNo_;
		
		///<summary>
		/// 开票人
		///</summary>
		
		private string cTaxCompany_;
		
		///<summary>
		/// 法人代表
		///</summary>
		
		private string cTaxContact_;
		
		///<summary>
		/// 联系人
		///</summary>
		
		private string cTaxLegend_;
		
		///<summary>
		/// 联系电话
		///</summary>
		
		private string cTaxContactTel_;
		
		///<summary>
		/// 邮箱地址
		///</summary>
		
		private string cTaxEmail_;
		
		public string GetVposOrderNum(){
			return this.vposOrderNum_;
		}
		
		public void SetVposOrderNum(string value){
			this.vposOrderNum_ = value;
		}
		public string GetXstoreId(){
			return this.xstoreId_;
		}
		
		public void SetXstoreId(string value){
			this.xstoreId_ = value;
		}
		public double? GetOrderAmount(){
			return this.orderAmount_;
		}
		
		public void SetOrderAmount(double? value){
			this.orderAmount_ = value;
		}
		public double? GetInvoiceDeductMoney(){
			return this.invoiceDeductMoney_;
		}
		
		public void SetInvoiceDeductMoney(double? value){
			this.invoiceDeductMoney_ = value;
		}
		public string GetCAutoBillTaxNo(){
			return this.cAutoBillTaxNo_;
		}
		
		public void SetCAutoBillTaxNo(string value){
			this.cAutoBillTaxNo_ = value;
		}
		public string GetCTaxCompany(){
			return this.cTaxCompany_;
		}
		
		public void SetCTaxCompany(string value){
			this.cTaxCompany_ = value;
		}
		public string GetCTaxContact(){
			return this.cTaxContact_;
		}
		
		public void SetCTaxContact(string value){
			this.cTaxContact_ = value;
		}
		public string GetCTaxLegend(){
			return this.cTaxLegend_;
		}
		
		public void SetCTaxLegend(string value){
			this.cTaxLegend_ = value;
		}
		public string GetCTaxContactTel(){
			return this.cTaxContactTel_;
		}
		
		public void SetCTaxContactTel(string value){
			this.cTaxContactTel_ = value;
		}
		public string GetCTaxEmail(){
			return this.cTaxEmail_;
		}
		
		public void SetCTaxEmail(string value){
			this.cTaxEmail_ = value;
		}
		
	}
	
}