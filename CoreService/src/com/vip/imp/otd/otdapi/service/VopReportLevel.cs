using System;

namespace com.vip.imp.otd.otdapi.service{
	
	
	public enum VopReportLevel {
		
		
		///<summary>
		/// 推广计划级别
		///</summary>
		REPORT_LEVEL_CAMPAIGN = 1, 
		
		///<summary>
		/// 广告级别
		///</summary>
		REPORT_LEVEL_AD = 2 
	}
	
	public class VopReportLevelUtil{
		
		private readonly int value;
		private VopReportLevelUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static VopReportLevel? FindByValue(int value){
			
			switch(value){
				
				case 1: return VopReportLevel.REPORT_LEVEL_CAMPAIGN; 
				case 2: return VopReportLevel.REPORT_LEVEL_AD; 
				
				default: return null; 
				
			}
			
		}
		
		public static VopReportLevel? FindByName(string name){
			
			if(VopReportLevel.REPORT_LEVEL_CAMPAIGN.ToString().Equals(name)){
				
				return VopReportLevel.REPORT_LEVEL_CAMPAIGN; 
			}
			
			if(VopReportLevel.REPORT_LEVEL_AD.ToString().Equals(name)){
				
				return VopReportLevel.REPORT_LEVEL_AD; 
			}
			
			
			return null;
			
		}
		
	}
	
}