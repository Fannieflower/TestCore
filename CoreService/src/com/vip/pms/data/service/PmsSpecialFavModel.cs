using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsSpecialFavModel {
		
		///<summary>
		/// 会员等级 对应于pms_sales_price_fav.condition_value
		///</summary>
		
		private string customerLevel_;
		
		///<summary>
		/// 废弃
		///</summary>
		
		private double? discount_;
		
		///<summary>
		/// 优惠-折扣或立减,等同于PmsSpecialCoreModel.favorable
		///</summary>
		
		private double? favorable_;
		
		public string GetCustomerLevel(){
			return this.customerLevel_;
		}
		
		public void SetCustomerLevel(string value){
			this.customerLevel_ = value;
		}
		public double? GetDiscount(){
			return this.discount_;
		}
		
		public void SetDiscount(double? value){
			this.discount_ = value;
		}
		public double? GetFavorable(){
			return this.favorable_;
		}
		
		public void SetFavorable(double? value){
			this.favorable_ = value;
		}
		
	}
	
}