using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class VendorInfoModel {
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 确认函编号
		///</summary>
		
		private string protNo_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 处理状态
		///</summary>
		
		private byte? isValid_;
		
		///<summary>
		/// 业务类型（1：商务，2：海淘）
		///</summary>
		
		private byte? businessType_;
		
		///<summary>
		/// 确认函维度（1：专场维度，2：品牌维度，3：商品维度）
		///</summary>
		
		private byte? contractDimension_;
		
		///<summary>
		/// 活动列表
		///</summary>
		
		private List<com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel> activityList_;
		
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetProtNo(){
			return this.protNo_;
		}
		
		public void SetProtNo(string value){
			this.protNo_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public byte? GetIsValid(){
			return this.isValid_;
		}
		
		public void SetIsValid(byte? value){
			this.isValid_ = value;
		}
		public byte? GetBusinessType(){
			return this.businessType_;
		}
		
		public void SetBusinessType(byte? value){
			this.businessType_ = value;
		}
		public byte? GetContractDimension(){
			return this.contractDimension_;
		}
		
		public void SetContractDimension(byte? value){
			this.contractDimension_ = value;
		}
		public List<com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel> GetActivityList(){
			return this.activityList_;
		}
		
		public void SetActivityList(List<com.vip.api.promotion.vis.protcontract.service.ActivityInfoModel> value){
			this.activityList_ = value;
		}
		
	}
	
}