using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class GrossProfitRateLadder {
		
		///<summary>
		/// 折扣起始值
		///</summary>
		
		private double? startDiscount_;
		
		///<summary>
		/// 折扣结束值
		///</summary>
		
		private double? endDiscount_;
		
		///<summary>
		/// 对应扣点
		///</summary>
		
		private double? point_;
		
		public double? GetStartDiscount(){
			return this.startDiscount_;
		}
		
		public void SetStartDiscount(double? value){
			this.startDiscount_ = value;
		}
		public double? GetEndDiscount(){
			return this.endDiscount_;
		}
		
		public void SetEndDiscount(double? value){
			this.endDiscount_ = value;
		}
		public double? GetPoint(){
			return this.point_;
		}
		
		public void SetPoint(double? value){
			this.point_ = value;
		}
		
	}
	
}