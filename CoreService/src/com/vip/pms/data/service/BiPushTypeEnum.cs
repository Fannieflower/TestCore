using System;

namespace com.vip.pms.data.service{
	
	
	public enum BiPushTypeEnum {
		
		
		///<summary>
		/// 买赠黑名单表
		///</summary>
		RiskBuygiftBlacklist = 1 
	}
	
	public class BiPushTypeEnumUtil{
		
		private readonly int value;
		private BiPushTypeEnumUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static BiPushTypeEnum? FindByValue(int value){
			
			switch(value){
				
				case 1: return BiPushTypeEnum.RiskBuygiftBlacklist; 
				
				default: return null; 
				
			}
			
		}
		
		public static BiPushTypeEnum? FindByName(string name){
			
			if(BiPushTypeEnum.RiskBuygiftBlacklist.ToString().Equals(name)){
				
				return BiPushTypeEnum.RiskBuygiftBlacklist; 
			}
			
			
			return null;
			
		}
		
	}
	
}