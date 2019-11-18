using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class CouponCheckResult {
		
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
		/// 使用此券的sku_id列表
		///</summary>
		
		private List<string> sku_ids_;
		
		///<summary>
		/// 1、可用使用，0不可使用
		///</summary>
		
		private int? usable_;
		
		///<summary>
		/// 不可用的原因编码:0、可用的 1、所选商品中包含不可使用优惠券商品 2、商品金额未到达满减要求 3、优惠券未到可使用时间4、该优惠券因其他原因不可使用5、券已经被使用6、券已经过期7、券未领取
		///</summary>
		
		private int? unusable_code_;
		
		///<summary>
		/// 不可用的原因描述
		///</summary>
		
		private string unusableReason_;
		
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
		public int? GetUsable(){
			return this.usable_;
		}
		
		public void SetUsable(int? value){
			this.usable_ = value;
		}
		public int? GetUnusable_code(){
			return this.unusable_code_;
		}
		
		public void SetUnusable_code(int? value){
			this.unusable_code_ = value;
		}
		public string GetUnusableReason(){
			return this.unusableReason_;
		}
		
		public void SetUnusableReason(string value){
			this.unusableReason_ = value;
		}
		
	}
	
}