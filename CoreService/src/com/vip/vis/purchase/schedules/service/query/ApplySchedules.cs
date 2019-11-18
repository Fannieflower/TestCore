using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class ApplySchedules {
		
		///<summary>
		/// 档期ID
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 分仓
		///</summary>
		
		private string sellArea_;
		
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public string GetSellArea(){
			return this.sellArea_;
		}
		
		public void SetSellArea(string value){
			this.sellArea_ = value;
		}
		
	}
	
}