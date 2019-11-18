using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class ProductSkuStatus {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private string partnerId_;
		
		///<summary>
		/// sku_id
		///</summary>
		
		private string skuId_;
		
		///<summary>
		/// sku号码
		///</summary>
		
		private string sku_;
		
		///<summary>
		/// 官网校验状态
		///</summary>
		
		private byte? vdgValidateStatus_;
		
		///<summary>
		/// 推送官网状态
		///</summary>
		
		private byte? pushVdgStatus_;
		
		///<summary>
		/// viplux校验状态
		///</summary>
		
		private byte? pdcValidateStatus_;
		
		///<summary>
		/// viplux推送状态
		///</summary>
		
		private byte? pushPdcStatus_;
		
		public string GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(string value){
			this.partnerId_ = value;
		}
		public string GetSkuId(){
			return this.skuId_;
		}
		
		public void SetSkuId(string value){
			this.skuId_ = value;
		}
		public string GetSku(){
			return this.sku_;
		}
		
		public void SetSku(string value){
			this.sku_ = value;
		}
		public byte? GetVdgValidateStatus(){
			return this.vdgValidateStatus_;
		}
		
		public void SetVdgValidateStatus(byte? value){
			this.vdgValidateStatus_ = value;
		}
		public byte? GetPushVdgStatus(){
			return this.pushVdgStatus_;
		}
		
		public void SetPushVdgStatus(byte? value){
			this.pushVdgStatus_ = value;
		}
		public byte? GetPdcValidateStatus(){
			return this.pdcValidateStatus_;
		}
		
		public void SetPdcValidateStatus(byte? value){
			this.pdcValidateStatus_ = value;
		}
		public byte? GetPushPdcStatus(){
			return this.pushPdcStatus_;
		}
		
		public void SetPushPdcStatus(byte? value){
			this.pushPdcStatus_ = value;
		}
		
	}
	
}