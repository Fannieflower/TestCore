using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class UpdateTrusteeshipInfoRequestModel {
		
		///<summary>
		/// 店铺来源（1为MP）
		///</summary>
		
		private byte? storeSource_;
		
		///<summary>
		/// 店铺ID
		///</summary>
		
		private string storeId_;
		
		///<summary>
		/// 纳税人识别号等
		///</summary>
		
		private string taxRegisterNo_;
		
		///<summary>
		/// 托管（签约）状态
		///</summary>
		
		private byte? trusteeshipStatus_;
		
		///<summary>
		/// 签约时间
		///</summary>
		
		private long? signTime_;
		
		///<summary>
		/// 服务开始时间
		///</summary>
		
		private long? trusteeshipStartTime_;
		
		///<summary>
		/// 服务结束时间
		///</summary>
		
		private long? trusteeshipEndTime_;
		
		///<summary>
		/// 第三方开票平台标记
		///</summary>
		
		private string trusteeshipPlatform_;
		
		///<summary>
		/// 服务类型
		///</summary>
		
		private byte? trusteeshipType_;
		
		///<summary>
		/// 单张发票金额上限
		///</summary>
		
		private string singleInvoiceAmountLimit_;
		
		///<summary>
		/// 发票类型。026为电子发票
		///</summary>
		
		private string invoiceType_;
		
		///<summary>
		/// 销售方名称
		///</summary>
		
		private string sellerName_;
		
		public byte? GetStoreSource(){
			return this.storeSource_;
		}
		
		public void SetStoreSource(byte? value){
			this.storeSource_ = value;
		}
		public string GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(string value){
			this.storeId_ = value;
		}
		public string GetTaxRegisterNo(){
			return this.taxRegisterNo_;
		}
		
		public void SetTaxRegisterNo(string value){
			this.taxRegisterNo_ = value;
		}
		public byte? GetTrusteeshipStatus(){
			return this.trusteeshipStatus_;
		}
		
		public void SetTrusteeshipStatus(byte? value){
			this.trusteeshipStatus_ = value;
		}
		public long? GetSignTime(){
			return this.signTime_;
		}
		
		public void SetSignTime(long? value){
			this.signTime_ = value;
		}
		public long? GetTrusteeshipStartTime(){
			return this.trusteeshipStartTime_;
		}
		
		public void SetTrusteeshipStartTime(long? value){
			this.trusteeshipStartTime_ = value;
		}
		public long? GetTrusteeshipEndTime(){
			return this.trusteeshipEndTime_;
		}
		
		public void SetTrusteeshipEndTime(long? value){
			this.trusteeshipEndTime_ = value;
		}
		public string GetTrusteeshipPlatform(){
			return this.trusteeshipPlatform_;
		}
		
		public void SetTrusteeshipPlatform(string value){
			this.trusteeshipPlatform_ = value;
		}
		public byte? GetTrusteeshipType(){
			return this.trusteeshipType_;
		}
		
		public void SetTrusteeshipType(byte? value){
			this.trusteeshipType_ = value;
		}
		public string GetSingleInvoiceAmountLimit(){
			return this.singleInvoiceAmountLimit_;
		}
		
		public void SetSingleInvoiceAmountLimit(string value){
			this.singleInvoiceAmountLimit_ = value;
		}
		public string GetInvoiceType(){
			return this.invoiceType_;
		}
		
		public void SetInvoiceType(string value){
			this.invoiceType_ = value;
		}
		public string GetSellerName(){
			return this.sellerName_;
		}
		
		public void SetSellerName(string value){
			this.sellerName_ = value;
		}
		
	}
	
}