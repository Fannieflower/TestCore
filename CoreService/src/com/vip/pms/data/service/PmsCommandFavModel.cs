using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsCommandFavModel {
		
		///<summary>
		/// 计算源起始数量。
		///</summary>
		
		private double? buy_;
		
		///<summary>
		/// 计算目标数量。
		///</summary>
		
		private double? cut_;
		
		public double? GetBuy(){
			return this.buy_;
		}
		
		public void SetBuy(double? value){
			this.buy_ = value;
		}
		public double? GetCut(){
			return this.cut_;
		}
		
		public void SetCut(double? value){
			this.cut_ = value;
		}
		
	}
	
}