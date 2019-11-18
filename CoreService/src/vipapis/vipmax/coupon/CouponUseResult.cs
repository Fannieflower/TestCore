using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class CouponUseResult {
		
		///<summary>
		/// 券号
		///</summary>
		
		private string coupon_sn_;
		
		///<summary>
		/// 券类型(2、满减)
		///</summary>
		
		private int? coupon_type_;
		
		///<summary>
		/// 券维度（1、全场券，2、商品券）
		///</summary>
		
		private int? coupon_field_;
		
		///<summary>
		/// 券类型名称
		///</summary>
		
		private string coupon_type_name_;
		
		///<summary>
		/// 券描述
		///</summary>
		
		private string coupon_fav_desc_;
		
		///<summary>
		/// 使用此券的spuID列表
		///</summary>
		
		private List<string> sku_ids_;
		
		public string GetCoupon_sn(){
			return this.coupon_sn_;
		}
		
		public void SetCoupon_sn(string value){
			this.coupon_sn_ = value;
		}
		public int? GetCoupon_type(){
			return this.coupon_type_;
		}
		
		public void SetCoupon_type(int? value){
			this.coupon_type_ = value;
		}
		public int? GetCoupon_field(){
			return this.coupon_field_;
		}
		
		public void SetCoupon_field(int? value){
			this.coupon_field_ = value;
		}
		public string GetCoupon_type_name(){
			return this.coupon_type_name_;
		}
		
		public void SetCoupon_type_name(string value){
			this.coupon_type_name_ = value;
		}
		public string GetCoupon_fav_desc(){
			return this.coupon_fav_desc_;
		}
		
		public void SetCoupon_fav_desc(string value){
			this.coupon_fav_desc_ = value;
		}
		public List<string> GetSku_ids(){
			return this.sku_ids_;
		}
		
		public void SetSku_ids(List<string> value){
			this.sku_ids_ = value;
		}
		
	}
	
}