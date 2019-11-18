using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.activity{
	
	
	
	
	
	public class Coupon {
		
		///<summary>
		/// 优惠劵名称
		///</summary>
		
		private string coupon_name_;
		
		///<summary>
		/// 券类型,(1:买赠 2:满减 3:折扣 4:免邮)
		///</summary>
		
		private int? coupon_type_;
		
		///<summary>
		/// 券使用类型,(1:绝对时间 2:相对时间)
		///</summary>
		
		private int? use_type_;
		
		///<summary>
		/// 使用门槛
		///</summary>
		
		private double? buy_;
		
		///<summary>
		/// 优惠金额
		///</summary>
		
		private double? fav_;
		
		///<summary>
		/// 券激活开始时间,毫秒级时间戳
		///</summary>
		
		private long? activate_begin_time_;
		
		///<summary>
		/// 券激活结束时间,毫秒级时间戳
		///</summary>
		
		private long? activate_end_time_;
		
		///<summary>
		/// 有效期相对天数,针对相对劵有效
		///</summary>
		
		private int? use_relative_days_;
		
		///<summary>
		/// 使用开始时间，毫秒级时间戳
		///</summary>
		
		private long? use_begin_time_;
		
		///<summary>
		/// 使用结束时间，毫秒级时间戳
		///</summary>
		
		private long? use_end_time_;
		
		public string GetCoupon_name(){
			return this.coupon_name_;
		}
		
		public void SetCoupon_name(string value){
			this.coupon_name_ = value;
		}
		public int? GetCoupon_type(){
			return this.coupon_type_;
		}
		
		public void SetCoupon_type(int? value){
			this.coupon_type_ = value;
		}
		public int? GetUse_type(){
			return this.use_type_;
		}
		
		public void SetUse_type(int? value){
			this.use_type_ = value;
		}
		public double? GetBuy(){
			return this.buy_;
		}
		
		public void SetBuy(double? value){
			this.buy_ = value;
		}
		public double? GetFav(){
			return this.fav_;
		}
		
		public void SetFav(double? value){
			this.fav_ = value;
		}
		public long? GetActivate_begin_time(){
			return this.activate_begin_time_;
		}
		
		public void SetActivate_begin_time(long? value){
			this.activate_begin_time_ = value;
		}
		public long? GetActivate_end_time(){
			return this.activate_end_time_;
		}
		
		public void SetActivate_end_time(long? value){
			this.activate_end_time_ = value;
		}
		public int? GetUse_relative_days(){
			return this.use_relative_days_;
		}
		
		public void SetUse_relative_days(int? value){
			this.use_relative_days_ = value;
		}
		public long? GetUse_begin_time(){
			return this.use_begin_time_;
		}
		
		public void SetUse_begin_time(long? value){
			this.use_begin_time_ = value;
		}
		public long? GetUse_end_time(){
			return this.use_end_time_;
		}
		
		public void SetUse_end_time(long? value){
			this.use_end_time_ = value;
		}
		
	}
	
}