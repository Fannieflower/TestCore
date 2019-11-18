using System;

namespace com.vip.pms.data.enums{
	
	
	public enum SupportPrepayFlag {
		
		
		///<summary>
		/// 支持预付活动
		///</summary>
		SUPPORT_PREPAY = 1, 
		
		///<summary>
		/// 不支持预付活动
		///</summary>
		NON_SUPPORT_PREPAY = 0 
	}
	
	public class SupportPrepayFlagUtil{
		
		private readonly int value;
		private SupportPrepayFlagUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static SupportPrepayFlag? FindByValue(int value){
			
			switch(value){
				
				case 1: return SupportPrepayFlag.SUPPORT_PREPAY; 
				case 0: return SupportPrepayFlag.NON_SUPPORT_PREPAY; 
				
				default: return null; 
				
			}
			
		}
		
		public static SupportPrepayFlag? FindByName(string name){
			
			if(SupportPrepayFlag.SUPPORT_PREPAY.ToString().Equals(name)){
				
				return SupportPrepayFlag.SUPPORT_PREPAY; 
			}
			
			if(SupportPrepayFlag.NON_SUPPORT_PREPAY.ToString().Equals(name)){
				
				return SupportPrepayFlag.NON_SUPPORT_PREPAY; 
			}
			
			
			return null;
			
		}
		
	}
	
}