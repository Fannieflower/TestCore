using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class BrandGoods {
		
		///<summary>
		/// 品牌SN
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 商务:总货值(万元)，海淘:档期货值(万元)
		///</summary>
		
		private int? totalGoodsValue_;
		
		///<summary>
		/// 我司预估承担金额（万元）
		///</summary>
		
		private int? vipBearValue_;
		
		///<summary>
		/// 供应商预估承担金额（万元）
		///</summary>
		
		private int? vendorBearValue_;
		
		///<summary>
		/// 备注信息
		///</summary>
		
		private string memo_;
		
		///<summary>
		/// 商务：品牌扣点，海淘：原毛利
		///</summary>
		
		private byte? brandDeduction_;
		
		///<summary>
		/// 商务：新扣点，海淘：新毛利
		///</summary>
		
		private byte? newDeduction_;
		
		///<summary>
		/// 我司承担比例
		///</summary>
		
		private double? vipScaleValue_;
		
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public int? GetTotalGoodsValue(){
			return this.totalGoodsValue_;
		}
		
		public void SetTotalGoodsValue(int? value){
			this.totalGoodsValue_ = value;
		}
		public int? GetVipBearValue(){
			return this.vipBearValue_;
		}
		
		public void SetVipBearValue(int? value){
			this.vipBearValue_ = value;
		}
		public int? GetVendorBearValue(){
			return this.vendorBearValue_;
		}
		
		public void SetVendorBearValue(int? value){
			this.vendorBearValue_ = value;
		}
		public string GetMemo(){
			return this.memo_;
		}
		
		public void SetMemo(string value){
			this.memo_ = value;
		}
		public byte? GetBrandDeduction(){
			return this.brandDeduction_;
		}
		
		public void SetBrandDeduction(byte? value){
			this.brandDeduction_ = value;
		}
		public byte? GetNewDeduction(){
			return this.newDeduction_;
		}
		
		public void SetNewDeduction(byte? value){
			this.newDeduction_ = value;
		}
		public double? GetVipScaleValue(){
			return this.vipScaleValue_;
		}
		
		public void SetVipScaleValue(double? value){
			this.vipScaleValue_ = value;
		}
		
	}
	
}