using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.service{
	
	
	
	
	
	public class GetPackageTimeVo {
		
		///<summary>
		/// 上门揽件日期
		///</summary>
		
		private string dateStr_;
		
		///<summary>
		/// 上门揽件时段列表
		///</summary>
		
		private List<string> hourOptionList_;
		
		public string GetDateStr(){
			return this.dateStr_;
		}
		
		public void SetDateStr(string value){
			this.dateStr_ = value;
		}
		public List<string> GetHourOptionList(){
			return this.hourOptionList_;
		}
		
		public void SetHourOptionList(List<string> value){
			this.hourOptionList_ = value;
		}
		
	}
	
}